using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AGV_GUI
{
	public partial class PID_Tuning : Form
	{
		class SpeedSeries
		{
			private const int MAX_SERIES_SIZE = 500;	// # of points 
			public int currentSize;
			public List<double> vR;
			public List<double> vL;
			public List<double> wR;
			public List<double> wL;
			public Color vR_color = Color.Blue;
			public Color wR_color = Color.Red;
			public Color vL_color = Color.Blue;
			public Color wL_color = Color.Red;
			public void AddData(double vRnew, double wRnew, double vLnew, double wLnew)
			{
				if(currentSize == MAX_SERIES_SIZE)
				{
					vR.RemoveAt(0);
					wR.RemoveAt(0);
					vL.RemoveAt(0);
					wL.RemoveAt(0);
					currentSize--;
				}
				vR.Add(vRnew);
				wR.Add(wRnew);
				vL.Add(vLnew);
				wL.Add(wLnew);
				currentSize++;
			}
			public SpeedSeries()
			{
				currentSize = 0;
				vR = new List<double>(MAX_SERIES_SIZE);
				vL = new List<double>(MAX_SERIES_SIZE);
				wR = new List<double>(MAX_SERIES_SIZE);
				wL = new List<double>(MAX_SERIES_SIZE);
				vR.Capacity = MAX_SERIES_SIZE;
				vL.Capacity = MAX_SERIES_SIZE;
				wR.Capacity = MAX_SERIES_SIZE;
				wL.Capacity = MAX_SERIES_SIZE;
			}

		}

		private AGV_ComPort agv;
		private SpeedSeries speedData;
		private ScottPlot.PlottableSignal plot_vR;
		private ScottPlot.PlottableSignal plot_wR;
		private ScottPlot.PlottableSignal plot_vL;
		private ScottPlot.PlottableSignal plot_wL;
		enum MOTOR{
			R,
			L
		}

		public PID_Tuning(AGV_ComPort a)
		{
			InitializeComponent();
			
			agv = a;
			agv.activeModules.pidTuning = true;
			agv.PortSendData("PIDV>START");
			speedData = new SpeedSeries();
			
			AskAgvForPidSettings(MOTOR.R);
			AskAgvForPidSettings(MOTOR.L);
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
						// Plot right motor speed
						plotter_rMotor.plt.Clear();
						plot_vR = plotter_rMotor.plt.PlotSignal(speedData.vR.ToArray(), color: speedData.vR_color);
						plot_wR = plotter_rMotor.plt.PlotSignal(speedData.wR.ToArray(), color: speedData.wR_color);
						plotter_rMotor.plt.AxisAuto();
						plotter_rMotor.Render();
						// Plot left motor speed
						plotter_lMotor.plt.Clear();
						plot_vL = plotter_lMotor.plt.PlotSignal(speedData.vL.ToArray(), color: speedData.vL_color);
						plot_wL = plotter_lMotor.plt.PlotSignal(speedData.wL.ToArray(), color: speedData.wL_color);
						plotter_lMotor.plt.AxisAuto();
						plotter_lMotor.Render();
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

			}

		}
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
			AskAgvForPidSettings(MOTOR.R);
		}
		private void lMtr_updateKpid_Click(object sender, EventArgs e)
		{
			AskAgvForPidSettings(MOTOR.L);
		}
	}
}
