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
			((System.ComponentModel.ISupportInitialize)(this.trackBar_linealSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_angularSpeed)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackBar_linealSpeed
			// 
			this.trackBar_linealSpeed.Location = new System.Drawing.Point(112, 13);
			this.trackBar_linealSpeed.Maximum = 100;
			this.trackBar_linealSpeed.Name = "trackBar_linealSpeed";
			this.trackBar_linealSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar_linealSpeed.Size = new System.Drawing.Size(45, 160);
			this.trackBar_linealSpeed.TabIndex = 6;
			this.trackBar_linealSpeed.TickFrequency = 2;
			this.trackBar_linealSpeed.Scroll += new System.EventHandler(this.trackBar_linealSpeed_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = "Velocidad lineal (m/s)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(63, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Velocidad angular (rad/s)";
			// 
			// trackBar_angularSpeed
			// 
			this.trackBar_angularSpeed.LargeChange = 10;
			this.trackBar_angularSpeed.Location = new System.Drawing.Point(11, 185);
			this.trackBar_angularSpeed.Maximum = 100;
			this.trackBar_angularSpeed.Minimum = -100;
			this.trackBar_angularSpeed.Name = "trackBar_angularSpeed";
			this.trackBar_angularSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.trackBar_angularSpeed.Size = new System.Drawing.Size(265, 45);
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
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(291, 298);
			this.panel1.TabIndex = 10;
			// 
			// txt_actualAngularSpeed
			// 
			this.txt_actualAngularSpeed.Enabled = false;
			this.txt_actualAngularSpeed.Location = new System.Drawing.Point(79, 270);
			this.txt_actualAngularSpeed.Name = "txt_actualAngularSpeed";
			this.txt_actualAngularSpeed.Size = new System.Drawing.Size(100, 20);
			this.txt_actualAngularSpeed.TabIndex = 17;
			// 
			// txt_actualLinearSpeed
			// 
			this.txt_actualLinearSpeed.Enabled = false;
			this.txt_actualLinearSpeed.Location = new System.Drawing.Point(163, 78);
			this.txt_actualLinearSpeed.Name = "txt_actualLinearSpeed";
			this.txt_actualLinearSpeed.Size = new System.Drawing.Size(100, 20);
			this.txt_actualLinearSpeed.TabIndex = 15;
			// 
			// txt_linearMin
			// 
			this.txt_linearMin.AutoSize = true;
			this.txt_linearMin.Location = new System.Drawing.Point(144, 160);
			this.txt_linearMin.Name = "txt_linearMin";
			this.txt_linearMin.Size = new System.Drawing.Size(13, 13);
			this.txt_linearMin.TabIndex = 13;
			this.txt_linearMin.Text = "0";
			// 
			// txt_linearMax
			// 
			this.txt_linearMax.AutoSize = true;
			this.txt_linearMax.Location = new System.Drawing.Point(144, 13);
			this.txt_linearMax.Name = "txt_linearMax";
			this.txt_linearMax.Size = new System.Drawing.Size(13, 13);
			this.txt_linearMax.TabIndex = 12;
			this.txt_linearMax.Text = "1";
			// 
			// txt_angularMax
			// 
			this.txt_angularMax.AutoSize = true;
			this.txt_angularMax.Location = new System.Drawing.Point(8, 217);
			this.txt_angularMax.Name = "txt_angularMax";
			this.txt_angularMax.Size = new System.Drawing.Size(13, 13);
			this.txt_angularMax.TabIndex = 14;
			this.txt_angularMax.Text = "2";
			// 
			// txt_angularMin
			// 
			this.txt_angularMin.AutoSize = true;
			this.txt_angularMin.Location = new System.Drawing.Point(260, 217);
			this.txt_angularMin.Name = "txt_angularMin";
			this.txt_angularMin.Size = new System.Drawing.Size(16, 13);
			this.txt_angularMin.TabIndex = 11;
			this.txt_angularMin.Text = "-2";
			// 
			// but_stop
			// 
			this.but_stop.BackColor = System.Drawing.Color.Firebrick;
			this.but_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.but_stop.ForeColor = System.Drawing.Color.Black;
			this.but_stop.Location = new System.Drawing.Point(309, 116);
			this.but_stop.Name = "but_stop";
			this.but_stop.Size = new System.Drawing.Size(106, 89);
			this.but_stop.TabIndex = 16;
			this.but_stop.Text = "STOP (SPC)";
			this.but_stop.UseVisualStyleBackColor = false;
			this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
			// 
			// chkbox_binarySpeed
			// 
			this.chkbox_binarySpeed.AutoSize = true;
			this.chkbox_binarySpeed.Location = new System.Drawing.Point(309, 37);
			this.chkbox_binarySpeed.Name = "chkbox_binarySpeed";
			this.chkbox_binarySpeed.Size = new System.Drawing.Size(107, 17);
			this.chkbox_binarySpeed.TabIndex = 17;
			this.chkbox_binarySpeed.TabStop = false;
			this.chkbox_binarySpeed.Text = "Velocidad binaria";
			this.chkbox_binarySpeed.UseVisualStyleBackColor = true;
			// 
			// Joystick
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 334);
			this.Controls.Add(this.chkbox_binarySpeed);
			this.Controls.Add(this.but_stop);
			this.Controls.Add(this.panel1);
			this.KeyPreview = true;
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
	}
}