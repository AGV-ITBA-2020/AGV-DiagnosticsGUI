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

		public PID_Tuning(AGV_ComPort a)
		{
			InitializeComponent();
			agv = a;
			agv.activeModules.pidTuning = true;

			speedData = new SpeedSeries();
			speedData.AddData(0,0,0,0);// Initialize only to start plotter
			
			AskAgvForPidSettings();
		}
		public void PID_ProcessNewMsg()
		{
			AGV_Msg msg = agv.msgList.Last();
			if(msg.origin == MSG_ORIGIN_T.CM)
			{
				if(msg.id == "SPEED")
				{
					speedData.AddData(msg.data[0].value, msg.data[1].value, msg.data[2].value, msg.data[3].value);	// Add data to series.
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
				else if(msg.id == "RKPID")
				{
					txtBox_rMtr_Kp.Text = msg.data[0].value.ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_rMtr_Ki.Text = msg.data[1].value.ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_rMtr_Kd.Text = msg.data[2].value.ToString(CultureInfo.GetCultureInfo("en-US"));
				}
				else if(msg.id == "LKPID")
				{
					txtBox_lMtr_Kp.Text = msg.data[0].value.ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_lMtr_Ki.Text = msg.data[1].value.ToString(CultureInfo.GetCultureInfo("en-US"));
					txtBox_lMtr_Kd.Text = msg.data[2].value.ToString(CultureInfo.GetCultureInfo("en-US"));
				}

			}

		}
		private void AskAgvForPidSettings()
		{
			agv.PortSendData("CM>Kpid");
		}
		private void PID_Config_FormClosing(object sender, FormClosingEventArgs e)
		{
			agv.activeModules.pidTuning = false;
		}

		private void rMotor_sendKpid_Click(object sender, EventArgs e)
		{
			string values = PidComs_GetStringForKpid(txtBox_rMtr_Kp.Text, txtBox_rMtr_Ki.Text, txtBox_rMtr_Kd.Text);
			if( values != null)
				agv.PortSendData("CM>RKPID;" + values);
			else
				MessageBox.Show("Error parseando valores de Kpid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private string PidComs_GetStringForKpid(string Kp, string Ki, string Kd)
		{
			double tempValue = 0.0;
			string retVal = null;

			if(double.TryParse(Kp, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempValue) == false)
				return null;
			else
				retVal += "Kp=" + tempValue.ToString("F2", CultureInfo.GetCultureInfo("en-US"));

			if(double.TryParse(Ki, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempValue) == false)
				return null;
			else
				retVal += "Ki=" + tempValue.ToString("F2", CultureInfo.GetCultureInfo("en-US"));;
				

			if(double.TryParse(Kd, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempValue) == false)
				return null;
			else
				retVal += "Kd=" + tempValue.ToString("F2", CultureInfo.GetCultureInfo("en-US"));;


			return retVal;
		}

		private void rMtr_updateKpid_Click(object sender, EventArgs e)
		{
			agv.PortSendData("CM>RKPID");
		}

		private void lMtr_sendKpid_Click(object sender, EventArgs e)
		{
			string values = PidComs_GetStringForKpid(txtBox_lMtr_Kp.Text, txtBox_lMtr_Ki.Text, txtBox_lMtr_Kd.Text);
			if( values != null)
				agv.PortSendData("CM>LKPID;" + values);
			else
				MessageBox.Show("Error parseando valores de Kpid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void lMtr_updateKpid_Click(object sender, EventArgs e)
		{
			agv.PortSendData("CM>LKPID");
		}
	}
}
