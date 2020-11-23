using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ScottPlot;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AGV_GUI
{
	public partial class PID_Tuning : Form
	{
		private const int TIMER_BASE_PERIOD = 2;	// multiple of timer ticks from main form.
		private int timerCount = 0;
		private readonly double TRACK_GRAPH_LIMITS = 1.2;
		class SpeedSeries
		{
			private const int MAX_SERIES_SIZE = 200;	// # of points 
			public int currentSize;
			public List<double> sR;	// Setpoint right wheel
			public List<double> sL;	// Setpoint left wheel
			public List<double> wR;	// Angular speed of right wheel
			public List<double> wL; // Angular speed of left wheel
			public Color vR_color = Color.Blue;
			public Color wR_color = Color.Red;
			public Color vL_color = Color.Blue;
			public Color wL_color = Color.Red;
			public void AddData(double vRnew, double wRnew, double vLnew, double wLnew)
			{
				if(currentSize == MAX_SERIES_SIZE)
				{
					sR.RemoveAt(0);
					wR.RemoveAt(0);
					sL.RemoveAt(0);
					wL.RemoveAt(0);
					currentSize--;
				}
				sR.Add(vRnew);
				wR.Add(wRnew);
				sL.Add(vLnew);
				wL.Add(wLnew);
				currentSize++;
				
			}
			public SpeedSeries()
			{
				currentSize = 0;
				sR = new List<double>(MAX_SERIES_SIZE);
				sL = new List<double>(MAX_SERIES_SIZE);
				wR = new List<double>(MAX_SERIES_SIZE);
				wL = new List<double>(MAX_SERIES_SIZE);
				sR.Capacity = MAX_SERIES_SIZE;
				sL.Capacity = MAX_SERIES_SIZE;
				wR.Capacity = MAX_SERIES_SIZE;
				wL.Capacity = MAX_SERIES_SIZE;
			}
		}
		class TrackSeries
		{
			private const int MAX_SERIES_SIZE = 100;	// # of points 
			public int currentSize;
			public List<double> tError;	// Track error
			public List<double> xs;	// Data time vector
			public Color error_color = Color.Blue;
			public void AddData(double inNew)
			{
				if(currentSize == MAX_SERIES_SIZE)
				{
					xs.RemoveAt(0);
					tError.RemoveAt(0);
					currentSize--;
				}
				
				xs.Add(xs.Last()+1);	// add new time value
				tError.Add(inNew);		// Add new data value
				currentSize++;
			}
			public TrackSeries()
			{
				currentSize = 0;
				xs = new List<double>(MAX_SERIES_SIZE);
				xs.Capacity = MAX_SERIES_SIZE;
				tError = new List<double>(MAX_SERIES_SIZE);
				tError.Capacity = MAX_SERIES_SIZE;
			}
		}

		private AGV_ComPort agv;
		private Joystick joy = null;
		private SpeedSeries speedData;
		private TrackSeries trackData;
		private ScottPlot.PlottableSignal plot_sR;
		private ScottPlot.PlottableSignal plot_wR;
		private ScottPlot.PlottableSignal plot_sL;
		private ScottPlot.PlottableSignal plot_wL;
		private ScottPlot.PlottableScatter plot_track;
		enum MOTOR{
			R,
			L
		}

		public PID_Tuning(AGV_ComPort a, Joystick joys = null)
		{
			InitializeComponent();
			
			agv = a;
			agv.activeModules.pidTuning = true;
			agv.PortSendData("PIDV>START");
			speedData = new SpeedSeries();
			trackData = new TrackSeries();
			trackData.xs.Add(0);	// For algorithm init
			trackData.tError.Add(0);	
			plotter_trackError.plt.AxisBounds(-TRACK_GRAPH_LIMITS, TRACK_GRAPH_LIMITS);
			plotter_trackError.plt.Ticks(displayTicksY: false);
			plotter_trackError.Render();
			if(joys != null)
				PID_AddJoystick(joys);
		}
		public void PID_AddJoystick(Joystick joys)
		{
			joy = joys;
		}
		public void PID_ProcessNewMsg()
		{
			AGV_Msg msg = agv.msgList.Last();
			if(msg.origin == MSG_ORIGIN_T.CM)
			{
				if(msg.id == "SPD")
				{
					if(msg.data.Count == 4)	// Ensure all 4 speeds arrived
					{
						status_speedMsg.BackColor = Color.Green;
						speedData.AddData(msg.data[0], msg.data[1], msg.data[2], msg.data[3]);	// Add data to series.
						PlotMotorData();
					}
					else
						status_speedMsg.BackColor = Color.Red;
				}
				else if(msg.id == "RPID")
				{
					txtBox_rMtr_Kp.Text = msg.data[0].ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_rMtr_Ki.Text = msg.data[1].ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_rMtr_Kd.Text = msg.data[2].ToString(CultureInfo.GetCultureInfo("en-US"));
				}
				else if(msg.id == "LPID")
				{
					txtBox_lMtr_Kp.Text = msg.data[0].ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_lMtr_Ki.Text = msg.data[1].ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_lMtr_Kd.Text = msg.data[2].ToString(CultureInfo.GetCultureInfo("en-US"));
				}
				else if(msg.id == "PPID")
				{
					txtbox_trackPID_Kp.Text = msg.data[0].ToString(CultureInfo.GetCultureInfo("en-US"));
					txtbox_trackPID_Ki.Text = msg.data[1].ToString(CultureInfo.GetCultureInfo("en-US"));
					txtbox_trackPID_Kd.Text = msg.data[2].ToString(CultureInfo.GetCultureInfo("en-US"));
				}
				else if(msg.id == "TSPD")
				{
					if(msg.data.Count == 5)	// Ensure all 4 speeds and track error arrived
					{
						status_speedMsg.BackColor = Color.Green;
						speedData.AddData(msg.data[0], msg.data[1], msg.data[2], msg.data[3]);	// Add data to series.
						trackData.AddData(msg.data[4]);
						PlotMotorData();
						PlotTrackData();
					}
					else
						status_speedMsg.BackColor = Color.Red;
				}

			}

		}
		void PlotMotorData()
		{
			// Plot right motor speed
			plotter_rMotor.plt.Clear();
			plot_sR = plotter_rMotor.plt.PlotSignal(speedData.sR.ToArray(), color: speedData.vR_color);
			plot_wR = plotter_rMotor.plt.PlotSignal(speedData.wR.ToArray(), color: speedData.wR_color);
			plotter_rMotor.plt.AxisAuto();
			plotter_rMotor.Render();
			// Plot left motor speed
			plotter_lMotor.plt.Clear();
			plot_sL = plotter_lMotor.plt.PlotSignal(speedData.sL.ToArray(), color: speedData.vL_color);
			plot_wL = plotter_lMotor.plt.PlotSignal(speedData.wL.ToArray(), color: speedData.wL_color);
			plotter_lMotor.plt.AxisAuto();
			plotter_lMotor.Render();
		}
		void PlotTrackData()
		{
			plotter_trackError.plt.Clear();
			plot_track = plotter_trackError.plt.PlotScatter(trackData.tError.ToArray(), trackData.xs.ToArray());
			plotter_trackError.plt.PlotVLine(x: 0, color:Color.Red, label: "SetPoint", lineStyle: LineStyle.Dot);
			plotter_lMotor.plt.AxisAuto();
		//	plotter_trackError.plt.AxisAutoY();
		//	plotter_trackError.plt.AxisAutoX();
		//	plotter_trackError.plt.Axis(-TRACK_GRAPH_LIMITS, TRACK_GRAPH_LIMITS);
			plotter_trackError.Render();
		}
	/*	public void PIDViewer_TimerCallback()
		{
			if(++timerCount >= TIMER_BASE_PERIOD )
			{
				timerCount = 0;
				AskAgvForSpeed();
			}
		}*/
		private void PID_Config_FormClosing(object sender, FormClosingEventArgs e)
		{
			agv.PortSendData("PIDV>STOP");
			agv.activeModules.pidTuning = false;
		}

		private string PidComs_GetStringForKpid(string Kp, string Ki, string Kd)
		{
			double tempValue = 0.0;
			string retVal = null;

			if(double.TryParse(Kp, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempValue) == false)
				return null;
			else
				retVal += tempValue.ToString("F2", CultureInfo.GetCultureInfo("en-US"));

			if(double.TryParse(Ki, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempValue) == false)
				return null;
			else
				retVal += ";" + tempValue.ToString("F2", CultureInfo.GetCultureInfo("en-US"));;
				

			if(double.TryParse(Kd, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempValue) == false)
				return null;
			else
				retVal += ";" + tempValue.ToString("F2", CultureInfo.GetCultureInfo("en-US"));;


			return retVal;
		}
		private void AskAgvForSpeed()
		{
			agv.PortSendData("PIDV>" + (chkbox_startTrackGraph.Checked ? "WTSPD" : "WHSPD" ));	// Ask for track error and wheel speed or wheel speed only
		}
		private void AskAgvForPidSettings(MOTOR x)
		{
			agv.PortSendData("PIDV>" + (x==MOTOR.R ? "rRPID" : "rLPID"));
		}
		private void rMotor_sendKpid_Click(object sender, EventArgs e)
		{
			string values = PidComs_GetStringForKpid(txtBox_rMtr_Kp.Text, txtBox_rMtr_Ki.Text, txtBox_rMtr_Kd.Text);
			if( values != null)
				agv.PortSendData("PIDV>wRPID;" + values);
			else
				MessageBox.Show("Error parseando valores de Kpid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void lMtr_sendKpid_Click(object sender, EventArgs e)
		{
			string values = PidComs_GetStringForKpid(txtBox_lMtr_Kp.Text, txtBox_lMtr_Ki.Text, txtBox_lMtr_Kd.Text);
			if( values != null)
				agv.PortSendData("PIDV>wLPID;" + values);
			else
				MessageBox.Show("Error parseando valores de Kpid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void rMtr_updateKpid_Click(object sender, EventArgs e)
		{
			txtBox_rMtr_Kp.Text = "";
			txtBox_rMtr_Ki.Text = "";
			txtBox_rMtr_Kd.Text = "";
			AskAgvForPidSettings(MOTOR.R);
		}
		private void lMtr_updateKpid_Click(object sender, EventArgs e)
		{
			txtBox_lMtr_Kp.Text = "";
			txtBox_lMtr_Ki.Text = "";
			txtBox_lMtr_Kd.Text = "";
			AskAgvForPidSettings(MOTOR.L);
		}

		private void but_rMot_exportCSV_Click(object sender, EventArgs e)
		{
			plot_wR.SaveCSV("./RIGHT ENCODER MEAS.csv");
			plot_wL.SaveCSV("./LEFT ENCODER MEAS.csv");
		}


		private void chkBox_filterInput_CheckedChanged(object sender, EventArgs e)
		{
			agv.PortSendData("PIDV>FILT;"+ (chkBox_filterInput.Checked ? "1.0" : "0.0"));
		}


		private void but_trackPID_Update_Click(object sender, EventArgs e)
		{
			txtbox_trackPID_Kp.Text = "";
			txtbox_trackPID_Ki.Text = "";
			txtbox_trackPID_Kd.Text = "";
			AskAgvForTrackPidSettings();
		}
		private void AskAgvForTrackPidSettings()
		{
			agv.PortSendData("PIDV>rPPID");
		}

		private void but_trackPID_Send_Click(object sender, EventArgs e)
		{
			string values = PidComs_GetStringForKpid(txtbox_trackPID_Kp.Text, txtbox_trackPID_Ki.Text, txtbox_trackPID_Kd.Text);
			if( values != null)
				agv.PortSendData("PIDV>wPPID;" + values);
			else
				MessageBox.Show("Error parseando valores de Kpid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void chkbox_startTrackGraph_CheckedChanged(object sender, EventArgs e)
		{
			agv.PortSendData("PIDV>TRACK;" + (chkbox_startTrackGraph.Checked ? "1.0" : "0.0"));
		}


		private void PID_Tuning_KeyPress(object sender, KeyEventArgs e)
		{
			if(joy != null)
				joy.Joystick_KeyPressed(sender, e);
		}

		private void PID_Tuning_KeyReleased(object sender, KeyEventArgs e)
		{
			if(joy != null)
				joy.Joystick_KeyReleased(sender, e);
		}
	}
}
