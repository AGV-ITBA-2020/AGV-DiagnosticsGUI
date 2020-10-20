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
	public partial class Joystick : Form
	{
		private AGV_ComPort agv;
		private bool cmdRun;
		public Joystick(AGV_ComPort a)
		{
			InitializeComponent();
			trackBar_angularSpeed.Value = 0;
			trackBar_linealSpeed.Value = 0;
			agv = a;
			agv.activeModules.joystick = true;
			timer1 = new System.Windows.Forms.Timer();
			timer1.Interval = 500;	// 500ms period
			timer1.Tick += new EventHandler(TimerEventProcessor);
			timer1.Start();
			agv.PortSendData("JOY>START");
			cmdRun = true;
		}
		private void TimerEventProcessor(Object myObject, EventArgs myEventArgs) 
		{
			if(cmdRun == true)
			{
				SendSpeedValues(v:trackBar_linealSpeed.Value, w: trackBar_angularSpeed.Value);
			}
			else
				eStop();
		}

		private void Joystick_KeyPressed(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.W:
					trackBar_linealSpeed.Value += (trackBar_linealSpeed.Value < trackBar_linealSpeed.Maximum ? 1 : 0);
					break;
				case Keys.S:
					trackBar_linealSpeed.Value -= (trackBar_linealSpeed.Value > trackBar_linealSpeed.Minimum ? 1 : 0);
					break;
				case Keys.A:
					trackBar_angularSpeed.Value += (trackBar_angularSpeed.Value < trackBar_angularSpeed.Maximum ? 1 : 0);
					break;
				case Keys.D:
					trackBar_angularSpeed.Value -= (trackBar_angularSpeed.Value > trackBar_angularSpeed.Minimum ? 1 : 0);
					break;
				case Keys.Space:
					if(cmdRun == true)
						eStop();
					else
						eStopResume();
					break;
			}
		}
		private void eStopResume()
		{
			but_stop.BackColor = Color.Firebrick;
			but_stop.Text = "STOP (SPC)";
			cmdRun = true;
		}
		private void eStop()
		{
			cmdRun = false;
			trackBar_linealSpeed.Value = 0;
			trackBar_angularSpeed.Value = 0;
			SendSpeedValues(0, 0);

			but_stop.BackColor = Color.Green;
			but_stop.Text = "RESUME (SPC)";
		}
		private void but_stop_Click(object sender, EventArgs e)
		{
			eStop();
		}
		private void SendSpeedValues(double v, double w)
		{
			agv.PortSendData("JOY>VWSPD;"+ v.ToString(CultureInfo.GetCultureInfo("en-US")) + ";" + w.ToString(CultureInfo.GetCultureInfo("en-US")));
		}

		private void Joystick_FormClosing(object sender, FormClosingEventArgs e)
		{
			agv.PortSendData("JOY>STOP");
			agv.activeModules.joystick = false;
			timer1.Stop();
			timer1.Dispose();
		}
	}
}
