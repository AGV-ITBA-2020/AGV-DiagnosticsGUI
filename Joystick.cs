using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			timer1 = new System.Windows.Forms.Timer();
			timer1.Interval = 1000;	// 500ms period
			timer1.Tick += new EventHandler(TimerEventProcessor);
			timer1.Start();

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
					eStop();
					break;
			}
		}
		private void eStop()
		{
			cmdRun = false;
			SendSpeedValues(0, 0);
		}
		private void but_stop_Click(object sender, EventArgs e)
		{
			eStop();
		}
		private void SendSpeedValues(double? v=null, double? w=null)
		{
			if(v!=null)
				agv.PortSendData("JOY>V="+v.ToString());
			if(w!=null)
				agv.PortSendData("JOY>W="+w.ToString());
		}

		private void Joystick_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Stop();
			timer1.Dispose();
		}
	}
}
