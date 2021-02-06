namespace AGV_GUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public AGV_ComPort agv;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.rTxtBox_Output = new System.Windows.Forms.RichTextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.selBox_ComPorts = new System.Windows.Forms.ComboBox();
			this.but_OpenPort = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.but_refreshPorts = new System.Windows.Forms.Button();
			this.selBox_baudRate = new System.Windows.Forms.ComboBox();
			this.txtBox_sendData = new System.Windows.Forms.TextBox();
			this.but_Send = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtBox_LatestMsg_id = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBox_LatestMsg_origin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.but_startJoystick = new System.Windows.Forms.Button();
			this.but_startPidTuning = new System.Windows.Forms.Button();
			this.but_clearConsole = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_mainForm = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			this.but_startRtosDiag = new System.Windows.Forms.Button();
			this.but_resetTools = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rTxtBox_Output
			// 
			this.rTxtBox_Output.Location = new System.Drawing.Point(16, 89);
			this.rTxtBox_Output.Margin = new System.Windows.Forms.Padding(4);
			this.rTxtBox_Output.Name = "rTxtBox_Output";
			this.rTxtBox_Output.ReadOnly = true;
			this.rTxtBox_Output.Size = new System.Drawing.Size(635, 511);
			this.rTxtBox_Output.TabIndex = 0;
			this.rTxtBox_Output.Text = "";
			this.rTxtBox_Output.DoubleClick += new System.EventHandler(this.rTxtBox_Output_ClearText);
			// 
			// selBox_ComPorts
			// 
			this.selBox_ComPorts.FormattingEnabled = true;
			this.selBox_ComPorts.Location = new System.Drawing.Point(8, 23);
			this.selBox_ComPorts.Margin = new System.Windows.Forms.Padding(4);
			this.selBox_ComPorts.Name = "selBox_ComPorts";
			this.selBox_ComPorts.Size = new System.Drawing.Size(160, 24);
			this.selBox_ComPorts.TabIndex = 1;
			this.selBox_ComPorts.Click += new System.EventHandler(this.selBox_ComPorts_UpdateComPorts);
			// 
			// but_OpenPort
			// 
			this.but_OpenPort.Location = new System.Drawing.Point(309, 23);
			this.but_OpenPort.Margin = new System.Windows.Forms.Padding(4);
			this.but_OpenPort.Name = "but_OpenPort";
			this.but_OpenPort.Size = new System.Drawing.Size(100, 28);
			this.but_OpenPort.TabIndex = 2;
			this.but_OpenPort.Text = "Open";
			this.but_OpenPort.UseVisualStyleBackColor = true;
			this.but_OpenPort.Click += new System.EventHandler(this.but_OpenPort_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.but_refreshPorts);
			this.groupBox1.Controls.Add(this.selBox_baudRate);
			this.groupBox1.Controls.Add(this.selBox_ComPorts);
			this.groupBox1.Controls.Add(this.but_OpenPort);
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(525, 66);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Port control";
			// 
			// but_refreshPorts
			// 
			this.but_refreshPorts.Location = new System.Drawing.Point(417, 23);
			this.but_refreshPorts.Margin = new System.Windows.Forms.Padding(4);
			this.but_refreshPorts.Name = "but_refreshPorts";
			this.but_refreshPorts.Size = new System.Drawing.Size(100, 28);
			this.but_refreshPorts.TabIndex = 4;
			this.but_refreshPorts.Text = "Refresh";
			this.but_refreshPorts.UseVisualStyleBackColor = true;
			this.but_refreshPorts.Click += new System.EventHandler(this.but_refreshPorts_Click);
			// 
			// selBox_baudRate
			// 
			this.selBox_baudRate.FormattingEnabled = true;
			this.selBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
			this.selBox_baudRate.Location = new System.Drawing.Point(177, 23);
			this.selBox_baudRate.Margin = new System.Windows.Forms.Padding(4);
			this.selBox_baudRate.Name = "selBox_baudRate";
			this.selBox_baudRate.Size = new System.Drawing.Size(84, 24);
			this.selBox_baudRate.TabIndex = 3;
			this.selBox_baudRate.Text = "115200";
			// 
			// txtBox_sendData
			// 
			this.txtBox_sendData.Location = new System.Drawing.Point(659, 578);
			this.txtBox_sendData.Margin = new System.Windows.Forms.Padding(4);
			this.txtBox_sendData.Name = "txtBox_sendData";
			this.txtBox_sendData.Size = new System.Drawing.Size(269, 22);
			this.txtBox_sendData.TabIndex = 5;
			this.txtBox_sendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_sendData_DetectEnter);
			// 
			// but_Send
			// 
			this.but_Send.Location = new System.Drawing.Point(937, 578);
			this.but_Send.Margin = new System.Windows.Forms.Padding(4);
			this.but_Send.Name = "but_Send";
			this.but_Send.Size = new System.Drawing.Size(100, 25);
			this.but_Send.TabIndex = 6;
			this.but_Send.Text = "Send";
			this.but_Send.UseVisualStyleBackColor = true;
			this.but_Send.Click += new System.EventHandler(this.but_Send_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtBox_LatestMsg_id);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtBox_LatestMsg_origin);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(835, 15);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(216, 95);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "AGV Lastest Message";
			// 
			// txtBox_LatestMsg_id
			// 
			this.txtBox_LatestMsg_id.Location = new System.Drawing.Point(75, 55);
			this.txtBox_LatestMsg_id.Margin = new System.Windows.Forms.Padding(4);
			this.txtBox_LatestMsg_id.Name = "txtBox_LatestMsg_id";
			this.txtBox_LatestMsg_id.ReadOnly = true;
			this.txtBox_LatestMsg_id.Size = new System.Drawing.Size(132, 22);
			this.txtBox_LatestMsg_id.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID:";
			// 
			// txtBox_LatestMsg_origin
			// 
			this.txtBox_LatestMsg_origin.Location = new System.Drawing.Point(76, 23);
			this.txtBox_LatestMsg_origin.Margin = new System.Windows.Forms.Padding(4);
			this.txtBox_LatestMsg_origin.Name = "txtBox_LatestMsg_origin";
			this.txtBox_LatestMsg_origin.ReadOnly = true;
			this.txtBox_LatestMsg_origin.Size = new System.Drawing.Size(132, 22);
			this.txtBox_LatestMsg_origin.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modulo:";
			// 
			// but_startJoystick
			// 
			this.but_startJoystick.Location = new System.Drawing.Point(845, 170);
			this.but_startJoystick.Margin = new System.Windows.Forms.Padding(4);
			this.but_startJoystick.Name = "but_startJoystick";
			this.but_startJoystick.Size = new System.Drawing.Size(196, 42);
			this.but_startJoystick.TabIndex = 8;
			this.but_startJoystick.Text = "AGV Controller";
			this.but_startJoystick.UseVisualStyleBackColor = true;
			this.but_startJoystick.Click += new System.EventHandler(this.but_startJoystick_Click);
			// 
			// but_startPidTuning
			// 
			this.but_startPidTuning.Location = new System.Drawing.Point(845, 230);
			this.but_startPidTuning.Margin = new System.Windows.Forms.Padding(4);
			this.but_startPidTuning.Name = "but_startPidTuning";
			this.but_startPidTuning.Size = new System.Drawing.Size(196, 42);
			this.but_startPidTuning.TabIndex = 9;
			this.but_startPidTuning.Text = "AGV PID Tuning";
			this.but_startPidTuning.UseVisualStyleBackColor = true;
			this.but_startPidTuning.Click += new System.EventHandler(this.but_startPidTuning_Click);
			// 
			// but_clearConsole
			// 
			this.but_clearConsole.Location = new System.Drawing.Point(659, 542);
			this.but_clearConsole.Margin = new System.Windows.Forms.Padding(4);
			this.but_clearConsole.Name = "but_clearConsole";
			this.but_clearConsole.Size = new System.Drawing.Size(100, 28);
			this.but_clearConsole.TabIndex = 10;
			this.but_clearConsole.Text = "Clear";
			this.but_clearConsole.UseVisualStyleBackColor = true;
			this.but_clearConsole.Click += new System.EventHandler(this.but_clearConsole_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_mainForm});
			this.statusStrip1.Location = new System.Drawing.Point(0, 611);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status_mainForm
			// 
			this.status_mainForm.Name = "status_mainForm";
			this.status_mainForm.Size = new System.Drawing.Size(29, 20);
			this.status_mainForm.Text = "     ";
			// 
			// mainTimer
			// 
			this.mainTimer.Interval = 200;
			// 
			// but_startRtosDiag
			// 
			this.but_startRtosDiag.Location = new System.Drawing.Point(841, 289);
			this.but_startRtosDiag.Margin = new System.Windows.Forms.Padding(4);
			this.but_startRtosDiag.Name = "but_startRtosDiag";
			this.but_startRtosDiag.Size = new System.Drawing.Size(196, 42);
			this.but_startRtosDiag.TabIndex = 12;
			this.but_startRtosDiag.Text = "AGV RTOS Diagnostics";
			this.but_startRtosDiag.UseVisualStyleBackColor = true;
			this.but_startRtosDiag.Click += new System.EventHandler(this.but_startRtosDiag_Click);
			// 
			// but_resetTools
			// 
			this.but_resetTools.Location = new System.Drawing.Point(847, 423);
			this.but_resetTools.Margin = new System.Windows.Forms.Padding(4);
			this.but_resetTools.Name = "but_resetTools";
			this.but_resetTools.Size = new System.Drawing.Size(196, 42);
			this.but_resetTools.TabIndex = 13;
			this.but_resetTools.Text = "Reset Tools";
			this.but_resetTools.UseVisualStyleBackColor = true;
			this.but_resetTools.Click += new System.EventHandler(this.but_resetTools_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 637);
			this.Controls.Add(this.but_resetTools);
			this.Controls.Add(this.but_startRtosDiag);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.but_clearConsole);
			this.Controls.Add(this.but_startPidTuning);
			this.Controls.Add(this.but_startJoystick);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.but_Send);
			this.Controls.Add(this.txtBox_sendData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.rTxtBox_Output);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "AGV-GUI v1.0";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rTxtBox_Output;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.ComboBox selBox_ComPorts;
		private System.Windows.Forms.Button but_OpenPort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox selBox_baudRate;
		private System.Windows.Forms.TextBox txtBox_sendData;
		private System.Windows.Forms.Button but_Send;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBox_LatestMsg_id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBox_LatestMsg_origin;
		private System.Windows.Forms.Button but_startJoystick;
		private System.Windows.Forms.Button but_startPidTuning;
		private System.Windows.Forms.Button but_refreshPorts;
		private System.Windows.Forms.Button but_clearConsole;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status_mainForm;
		private System.Windows.Forms.Timer mainTimer;
		private System.Windows.Forms.Button but_startRtosDiag;
		private System.Windows.Forms.Button but_resetTools;
	}
}

