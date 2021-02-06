namespace AGV_GUI
{
	partial class Joystick
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.trackBar_linealSpeed = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.trackBar_angularSpeed = new System.Windows.Forms.TrackBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_actualAngularSpeed = new System.Windows.Forms.TextBox();
			this.txt_actualLinearSpeed = new System.Windows.Forms.TextBox();
			this.txt_linearMin = new System.Windows.Forms.Label();
			this.txt_linearMax = new System.Windows.Forms.Label();
			this.txt_angularMax = new System.Windows.Forms.Label();
			this.txt_angularMin = new System.Windows.Forms.Label();
			this.but_stop = new System.Windows.Forms.Button();
			this.chkbox_binarySpeed = new System.Windows.Forms.CheckBox();
			this.txt_DigLinealSpeed = new System.Windows.Forms.TextBox();
			this.btn_autoGiro = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_linealSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_angularSpeed)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackBar_linealSpeed
			// 
			this.trackBar_linealSpeed.Location = new System.Drawing.Point(143, 16);
			this.trackBar_linealSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.trackBar_linealSpeed.Maximum = 100;
			this.trackBar_linealSpeed.Name = "trackBar_linealSpeed";
			this.trackBar_linealSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar_linealSpeed.Size = new System.Drawing.Size(56, 197);
			this.trackBar_linealSpeed.TabIndex = 6;
			this.trackBar_linealSpeed.TickFrequency = 2;
			this.trackBar_linealSpeed.Scroll += new System.EventHandler(this.trackBar_linealSpeed_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(37, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 34);
			this.label1.TabIndex = 7;
			this.label1.Text = "Velocidad lineal (m/s)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(84, 305);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Velocidad angular (rad/s)";
			// 
			// trackBar_angularSpeed
			// 
			this.trackBar_angularSpeed.LargeChange = 10;
			this.trackBar_angularSpeed.Location = new System.Drawing.Point(8, 228);
			this.trackBar_angularSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.trackBar_angularSpeed.Maximum = 100;
			this.trackBar_angularSpeed.Minimum = -100;
			this.trackBar_angularSpeed.Name = "trackBar_angularSpeed";
			this.trackBar_angularSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.trackBar_angularSpeed.Size = new System.Drawing.Size(353, 56);
			this.trackBar_angularSpeed.SmallChange = 5;
			this.trackBar_angularSpeed.TabIndex = 8;
			this.trackBar_angularSpeed.TickFrequency = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_actualAngularSpeed);
			this.panel1.Controls.Add(this.txt_actualLinearSpeed);
			this.panel1.Controls.Add(this.txt_linearMin);
			this.panel1.Controls.Add(this.txt_linearMax);
			this.panel1.Controls.Add(this.trackBar_linealSpeed);
			this.panel1.Controls.Add(this.txt_angularMax);
			this.panel1.Controls.Add(this.txt_angularMin);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar_angularSpeed);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(16, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 367);
			this.panel1.TabIndex = 10;
			// 
			// txt_actualAngularSpeed
			// 
			this.txt_actualAngularSpeed.Enabled = false;
			this.txt_actualAngularSpeed.Location = new System.Drawing.Point(105, 332);
			this.txt_actualAngularSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.txt_actualAngularSpeed.Name = "txt_actualAngularSpeed";
			this.txt_actualAngularSpeed.Size = new System.Drawing.Size(132, 22);
			this.txt_actualAngularSpeed.TabIndex = 17;
			// 
			// txt_actualLinearSpeed
			// 
			this.txt_actualLinearSpeed.Enabled = false;
			this.txt_actualLinearSpeed.Location = new System.Drawing.Point(211, 96);
			this.txt_actualLinearSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.txt_actualLinearSpeed.Name = "txt_actualLinearSpeed";
			this.txt_actualLinearSpeed.Size = new System.Drawing.Size(132, 22);
			this.txt_actualLinearSpeed.TabIndex = 15;
			// 
			// txt_linearMin
			// 
			this.txt_linearMin.AutoSize = true;
			this.txt_linearMin.Location = new System.Drawing.Point(185, 197);
			this.txt_linearMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txt_linearMin.Name = "txt_linearMin";
			this.txt_linearMin.Size = new System.Drawing.Size(16, 17);
			this.txt_linearMin.TabIndex = 13;
			this.txt_linearMin.Text = "0";
			// 
			// txt_linearMax
			// 
			this.txt_linearMax.AutoSize = true;
			this.txt_linearMax.Location = new System.Drawing.Point(185, 16);
			this.txt_linearMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txt_linearMax.Name = "txt_linearMax";
			this.txt_linearMax.Size = new System.Drawing.Size(16, 17);
			this.txt_linearMax.TabIndex = 12;
			this.txt_linearMax.Text = "1";
			// 
			// txt_angularMax
			// 
			this.txt_angularMax.AutoSize = true;
			this.txt_angularMax.Location = new System.Drawing.Point(17, 267);
			this.txt_angularMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txt_angularMax.Name = "txt_angularMax";
			this.txt_angularMax.Size = new System.Drawing.Size(16, 17);
			this.txt_angularMax.TabIndex = 14;
			this.txt_angularMax.Text = "2";
			// 
			// txt_angularMin
			// 
			this.txt_angularMin.AutoSize = true;
			this.txt_angularMin.Location = new System.Drawing.Point(323, 267);
			this.txt_angularMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txt_angularMin.Name = "txt_angularMin";
			this.txt_angularMin.Size = new System.Drawing.Size(21, 17);
			this.txt_angularMin.TabIndex = 11;
			this.txt_angularMin.Text = "-2";
			// 
			// but_stop
			// 
			this.but_stop.BackColor = System.Drawing.Color.Firebrick;
			this.but_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.but_stop.ForeColor = System.Drawing.Color.Black;
			this.but_stop.Location = new System.Drawing.Point(412, 143);
			this.but_stop.Margin = new System.Windows.Forms.Padding(4);
			this.but_stop.Name = "but_stop";
			this.but_stop.Size = new System.Drawing.Size(141, 110);
			this.but_stop.TabIndex = 16;
			this.but_stop.Text = "STOP (SPC)";
			this.but_stop.UseVisualStyleBackColor = false;
			this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
			// 
			// chkbox_binarySpeed
			// 
			this.chkbox_binarySpeed.AutoCheck = false;
			this.chkbox_binarySpeed.AutoSize = true;
			this.chkbox_binarySpeed.Location = new System.Drawing.Point(389, 18);
			this.chkbox_binarySpeed.Margin = new System.Windows.Forms.Padding(4);
			this.chkbox_binarySpeed.Name = "chkbox_binarySpeed";
			this.chkbox_binarySpeed.Size = new System.Drawing.Size(162, 21);
			this.chkbox_binarySpeed.TabIndex = 17;
			this.chkbox_binarySpeed.TabStop = false;
			this.chkbox_binarySpeed.Text = "Velocidad binaria (T)";
			this.chkbox_binarySpeed.UseVisualStyleBackColor = true;
			this.chkbox_binarySpeed.CheckedChanged += new System.EventHandler(this.chkbox_binarySpeed_CheckedChanged);
			// 
			// txt_DigLinealSpeed
			// 
			this.txt_DigLinealSpeed.Enabled = false;
			this.txt_DigLinealSpeed.Location = new System.Drawing.Point(402, 47);
			this.txt_DigLinealSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.txt_DigLinealSpeed.Name = "txt_DigLinealSpeed";
			this.txt_DigLinealSpeed.Size = new System.Drawing.Size(132, 22);
			this.txt_DigLinealSpeed.TabIndex = 18;
			// 
			// btn_autoGiro
			// 
			this.btn_autoGiro.Appearance = System.Windows.Forms.Appearance.Button;
			this.btn_autoGiro.Checked = true;
			this.btn_autoGiro.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btn_autoGiro.Location = new System.Drawing.Point(412, 282);
			this.btn_autoGiro.Name = "btn_autoGiro";
			this.btn_autoGiro.Size = new System.Drawing.Size(135, 52);
			this.btn_autoGiro.TabIndex = 19;
			this.btn_autoGiro.Text = "Auto giro";
			this.btn_autoGiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_autoGiro.UseVisualStyleBackColor = true;
			this.btn_autoGiro.Visible = false;
			this.btn_autoGiro.CheckedChanged += new System.EventHandler(this.btn_autoGiro_CheckedChanged);
			// 
			// Joystick
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 411);
			this.Controls.Add(this.btn_autoGiro);
			this.Controls.Add(this.txt_DigLinealSpeed);
			this.Controls.Add(this.chkbox_binarySpeed);
			this.Controls.Add(this.but_stop);
			this.Controls.Add(this.panel1);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Joystick";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Joystick";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Joystick_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Joystick_KeyPressed);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Joystick_KeyReleased);
			((System.ComponentModel.ISupportInitialize)(this.trackBar_linealSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_angularSpeed)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar trackBar_linealSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar trackBar_angularSpeed;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label txt_angularMin;
		private System.Windows.Forms.Label txt_linearMax;
		private System.Windows.Forms.Label txt_angularMax;
		private System.Windows.Forms.Label txt_linearMin;
		private System.Windows.Forms.Button but_stop;
		private System.Windows.Forms.TextBox txt_actualAngularSpeed;
		private System.Windows.Forms.TextBox txt_actualLinearSpeed;
		private System.Windows.Forms.CheckBox chkbox_binarySpeed;
		private System.Windows.Forms.TextBox txt_DigLinealSpeed;
		private System.Windows.Forms.CheckBox btn_autoGiro;
	}
}