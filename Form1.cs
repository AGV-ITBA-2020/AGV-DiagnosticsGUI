using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace AGV_GUI
{
	public partial class Form1 : Form
	{
		PID_Tuning pidForm;
		Joystick joystickForm;
		public Form1()
		{
			InitializeComponent();
			mainTimer = new System.Windows.Forms.Timer();
			mainTimer.Interval = 200;	// 200ms period
			mainTimer.Tick += new EventHandler(MainTimerCallback);
		}
		#region MAIN_FORM_MISC_METHODS
		private void Form1_Load(object sender, EventArgs e)
		{
			serialPort1 = new SerialPort();
			serialPort1.NewLine = "\r\n";
			serialPort1.ReadTimeout = 1000;
			serialPort1.WriteTimeout = 500;
			PortsUpdateSelectBox();
			if(selBox_ComPorts.Items.Count == 1)
				selBox_ComPorts.SelectedItem = selBox_ComPorts.Items[0];
			CheckForIllegalCrossThreadCalls = false;
			agv = new AGV_ComPort(serialPort1);
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			PortDisconnect();
		}
		private void selBox_ComPorts_UpdateComPorts(object sender, EventArgs e)
		{
			PortsUpdateSelectBox();
		}
		private void PortsUpdateSelectBox()
		{
			selBox_ComPorts.Items.Clear();
			string[] ports = SerialPort.GetPortNames();
			foreach(string port in ports)
				selBox_ComPorts.Items.Add(port);
		}
		private void but_OpenPort_Click(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)	
				PortDisconnect();
			else
				PortConnect();
		}
		private void PortConnect()
		{
			if(selBox_ComPorts.SelectedItem == null)
				return;
			bool error = false;
			if(serialPort1.IsOpen == false)
			{
				serialPort1.PortName = selBox_ComPorts.SelectedItem.ToString();
				serialPort1.BaudRate = int.Parse(selBox_baudRate.Text);      //convert Text to Integer
				serialPort1.Parity = Parity.None;
				serialPort1.DataBits = 8;
				serialPort1.StopBits = StopBits.One;
				try  //always try to use this try and catch method to open your port. //if there is an error your program will not display a message instead of freezing.
                {
                    serialPort1.Open();
                    serialPort1.DataReceived += SerialDataRx;  //Check for received data. When there is data in the receive buffer, it will raise this event, we need to subscribe to it to know when there is data
				}
                catch (UnauthorizedAccessException) { error = true; }
                catch (System.IO.IOException) { error = true; }
                catch (ArgumentException) { error = true; }
			}
			if (error) MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			
			if(serialPort1.IsOpen)
			{
				but_OpenPort.Text = "Close";
			}
		}
		private void PortDisconnect()
		{
			if(serialPort1.IsOpen)
			{
				serialPort1.Close();
				but_OpenPort.Text = "Connect";
			}
		}
		#endregion

		#region MSG_RECEIVE
		private void SerialDataRx(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort serial = (SerialPort)sender;
			//	string msg = serial.ReadExisting();
			bool _continue = true;
			while(_continue)
			{
				try
				{
					string msg;
					try{
						msg = serial.ReadLine();
					}
					catch(System.IO.IOException){return;}
					Console_PrintMsg(msg + "\r\n");
					if(agv.PortProcessDataString(msg) == true)	// Message was identified OK
					{
						status_mainForm.BackColor = Color.Green;
						txtBox_LatestMsg_origin.Text = agv.msgList.Last().origin.ToString();
						txtBox_LatestMsg_id.Text = agv.msgList.Last().id;
					
						// Notify every form to read new message
						if(agv.activeModules.pidTuning == true)
							pidForm.PID_ProcessNewMsg();
					}		
					else
						status_mainForm.BackColor = Color.Red;
				}
				catch(TimeoutException){_continue = false;}
			}
			


		}
		#endregion
		private void Console_PrintMsg(string msg) 
		{
			if(rTxtBox_Output.Lines.Length > 100)
				rTxtBox_Output.Clear();
			rTxtBox_Output.AppendText(msg);
			rTxtBox_Output.SelectionStart = rTxtBox_Output.Text.Length;
			rTxtBox_Output.ScrollToCaret();
		}

		#region CONSOLE_SEND_METHODS
		private void rTxtBox_Output_ClearText(object sender, EventArgs e)
		{
			rTxtBox_Output.Clear();
		}

		private void but_Send_Click(object sender, EventArgs e)
		{
			String s = txtBox_sendData.Text;
            if (s.Length != 0)  
			{
				agv.PortSendData(s);
				rTxtBox_Output.AppendText( "TX>> " + s + "\r\n");
				txtBox_sendData.Clear();                       //clear screen after sending data
			}
		}


		private void txtBox_sendData_DetectEnter(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter)
				but_Send_Click(sender, e);
		}
		#endregion

		#region OPTIONAL

		//Data recived from the serial port is coming from another thread context than the UI thread.
		//Instead of reading the content directly in the SerialPortDataReceived, we need to use a delegate.
		/*    delegate void SetTextCallback(string text);
			private void SetText(string text)
			{
				//invokeRequired required compares the thread ID of the calling thread to the thread of the creating thread.
				// if these threads are different, it returns true
				if (this.rTxtBox_Output.InvokeRequired)
				{
					SetTextCallback d = new SetTextCallback(SetText);              
					this.Invoke(d, new object[] { text });
				}
				else
				{
					this.rTxtBox_Output.AppendText(text); 
				}
			}
			private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
			{
				var serialPort = (SerialPort)sender;
				var data = serialPort.ReadExisting();
				SetText(data);
			}*/
		#endregion

		private void but_startJoystick_Click(object sender, EventArgs e)
		{
			joystickForm = new Joystick(agv);
			joystickForm.Show();
			CheckForTimerAction();
			if(agv.activeModules.pidTuning)
				pidForm.PID_AddJoystick(joystickForm);
		}

		private void but_startPidTuning_Click(object sender, EventArgs e)
		{
			pidForm = new PID_Tuning(agv, (agv.activeModules.joystick ? joystickForm : null));	// If joystick is active, send form to pid viewer.
			pidForm.Show();
			CheckForTimerAction();
		}
		private void CheckForTimerAction()
		{
			if(agv.activeModules.joystick || agv.activeModules.pidTuning )
			{
				if( !mainTimer.Enabled )
					mainTimer.Start();
			}
			else
				mainTimer.Stop();
		}
		private void MainTimerCallback(Object myObject, EventArgs myEventArgs) 
		{
		//	if(agv.activeModules.pidTuning == true)
		//		pidForm.PIDViewer_TimerCallback();
			if(agv.activeModules.joystick == true)
				joystickForm.Joystick_TimerCallback();
			CheckForTimerAction();	// Check whether to shut down timer

		}
		private void but_refreshPorts_Click(object sender, EventArgs e)
		{
			PortsUpdateSelectBox();
		}

		private void but_clearConsole_Click(object sender, EventArgs e)
		{
			rTxtBox_Output.Clear();
		}

		private void but_startRtosDiag_Click(object sender, EventArgs e)
		{

		}
	}
}
