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
		private const int TIMER_BASE_PERIOD = 2;	// multiple of timer ticks from main form.
		private readonly double[] LINEAR_SPEED_MAP = {0, 1};	// Linear speed goes from 0 to 1m/s
		private readonly double[] ANGULAR_SPEED_MAP = {-1, 1};	// Angular speed goes from -1 to 1rad/s
		private readonly int[] LINEAR_SPEED_TRACK_LIMITS = {0, 100};
		private readonly int[] ANGULAR_SPEED_TRACK_LIMITS = {-100, 100};
		private readonly int[] DIGITAL_LINEAR_SPEED = {0, 40};
		private readonly int[] DIGITAL_ANGULAR_SPEED = {-25, 25};

		private double linearMapAlpha;
		private double angularMapAlpha;
		private int timerCount = 0;
		private AGV_ComPort agv;
		private bool cmdRun;
		public Joystick(AGV_ComPort a)
		{
			InitializeComponent();

			trackBar_angularSpeed.Value = 0;
			trackBar_linealSpeed.Value = 0;
			trackBar_linealSpeed.Minimum= LINEAR_SPEED_TRACK_LIMITS[0];
			trackBar_linealSpeed.Maximum = LINEAR_SPEED_TRACK_LIMITS[1];
			trackBar_angularSpeed.Minimum= ANGULAR_SPEED_TRACK_LIMITS[0];
			trackBar_angularSpeed.Maximum = ANGULAR_SPEED_TRACK_LIMITS[1];
			linearMapAlpha = (LINEAR_SPEED_MAP[1]-LINEAR_SPEED_MAP[0])/(LINEAR_SPEED_TRACK_LIMITS[1]-LINEAR_SPEED_TRACK_LIMITS[0]);
			angularMapAlpha = (ANGULAR_SPEED_MAP[1]-ANGULAR_SPEED_MAP[0])/(ANGULAR_SPEED_TRACK_LIMITS[1]-ANGULAR_SPEED_TRACK_LIMITS[0]);
			txt_linearMin.Text = LINEAR_SPEED_MAP[0].ToString();
			txt_linearMax.Text = LINEAR_SPEED_MAP[1].ToString();
			txt_angularMin.Text = ANGULAR_SPEED_MAP[0].ToString();
			txt_angularMax.Text = ANGULAR_SPEED_MAP[1].ToString();
			trackBar_linealSpeed.Value = 0;
			trackBar_angularSpeed.Value = 0;

			agv = a;
			agv.activeModules.joystick = true;
			agv.PortSendData("JOY>START");
			cmdRun = true;
		}
		public void Joystick_TimerCallback() 
		{
			if(++timerCount >= TIMER_BASE_PERIOD )
			{
				timerCount = 0;
				if(cmdRun == true)
					SendSpeedValues(v:  MapLinearControlToSpeed(trackBar_linealSpeed.Value), w: MapAngularControlToSpeed(trackBar_angularSpeed.Value));
				else
					eStop();
			}
		}

		private void Joystick_KeyPressed(object sender, KeyEventArgs e)
		{
			bool binarySpeed = chkbox_binarySpeed.Checked;
			switch(e.KeyCode)
			{
				case Keys.W:
					if(binarySpeed)
						trackBar_linealSpeed.Value = DIGITAL_LINEAR_SPEED[1];
					else
						trackBar_linealSpeed.Value += (trackBar_linealSpeed.Value < trackBar_linealSpeed.Maximum ? 1 : 0);
					break;
				case Keys.S:
					if(binarySpeed)
						trackBar_linealSpeed.Value = DIGITAL_LINEAR_SPEED[0];
					else
						trackBar_linealSpeed.Value -= (trackBar_linealSpeed.Value > trackBar_linealSpeed.Minimum ? 1 : 0);
					break;
				case Keys.A:
					if(binarySpeed)
						trackBar_angularSpeed.Value = DIGITAL_ANGULAR_SPEED[0];
					else
						trackBar_angularSpeed.Value += (trackBar_angularSpeed.Value < trackBar_angularSpeed.Maximum ? 1 : 0);
					break;
				case Keys.D:
					if(binarySpeed)
						trackBar_angularSpeed.Value = DIGITAL_ANGULAR_SPEED[1];
					else
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
			txt_actualLinearSpeed.Text = v.ToString("F2", CultureInfo.GetCultureInfo("en-US"));
			txt_actualAngularSpeed.Text = w.ToString("F2", CultureInfo.GetCultureInfo("en-US"));
			agv.PortSendData("JOY>VWSPD;"+ txt_actualLinearSpeed.Text + ";" + txt_actualAngularSpeed.Text);
		}
		private double MapLinearControlToSpeed(int v_track)
		{
			return (linearMapAlpha * (v_track - LINEAR_SPEED_TRACK_LIMITS[0]) + LINEAR_SPEED_MAP[0]);
		}
		private double MapAngularControlToSpeed(int w_track)
		{
			return (angularMapAlpha * (w_track - ANGULAR_SPEED_TRACK_LIMITS[0]) + ANGULAR_SPEED_MAP[0]);
		}
		private void Joystick_FormClosing(object sender, FormClosingEventArgs e)
		{
			agv.PortSendData("JOY>STOP");
			agv.activeModules.joystick = false;
		}

		private void trackBar_linealSpeed_Scroll(object sender, EventArgs e)
		{

		}

		private void Joystick_KeyReleased(object sender, KeyEventArgs e)
		{
			if(chkbox_binarySpeed.Checked == false)	// nothing to do
				return;
			// Reset all speed to 0
			switch(e.KeyCode)
			{
				case Keys.W:
						trackBar_linealSpeed.Value = DIGITAL_LINEAR_SPEED[0];
					break;
				case Keys.A:
						trackBar_angularSpeed.Value = 0;
					break;
				case Keys.D:
						trackBar_angularSpeed.Value = 0;
					break;
				case Keys.Space:
					if(cmdRun == true)
						eStop();
					else
						eStopResume();
					break;
			}
		}
	}
}
