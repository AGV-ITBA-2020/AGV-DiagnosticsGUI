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
			this.components = new System.ComponentModel.Container();
			this.trackBar_linealSpeed = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.trackBar_angularSpeed = new System.Windows.Forms.TrackBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.but_stop = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_linealSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_angularSpeed)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackBar_linealSpeed
			// 
			this.trackBar_linealSpeed.Location = new System.Drawing.Point(142, 10);
			this.trackBar_linealSpeed.Maximum = 100;
			this.trackBar_linealSpeed.Name = "trackBar_linealSpeed";
			this.trackBar_linealSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar_linealSpeed.Size = new System.Drawing.Size(45, 160);
			this.trackBar_linealSpeed.TabIndex = 6;
			this.trackBar_linealSpeed.TickFrequency = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(63, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 28);
			this.label1.TabIndex = 7;
			this.label1.Text = "Velocidad lineal (m/s)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(93, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Velocidad angular (rad/s)";
			// 
			// trackBar_angularSpeed
			// 
			this.trackBar_angularSpeed.LargeChange = 10;
			this.trackBar_angularSpeed.Location = new System.Drawing.Point(41, 182);
			this.trackBar_angularSpeed.Minimum = -10;
			this.trackBar_angularSpeed.Name = "trackBar_angularSpeed";
			this.trackBar_angularSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.trackBar_angularSpeed.Size = new System.Drawing.Size(265, 45);
			this.trackBar_angularSpeed.SmallChange = 5;
			this.trackBar_angularSpeed.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.trackBar_linealSpeed);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar_angularSpeed);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(340, 298);
			this.panel1.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(174, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(174, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(293, 214);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "-2";
			// 
			// but_stop
			// 
			this.but_stop.BackColor = System.Drawing.Color.Firebrick;
			this.but_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.but_stop.ForeColor = System.Drawing.Color.Black;
			this.but_stop.Location = new System.Drawing.Point(378, 115);
			this.but_stop.Name = "but_stop";
			this.but_stop.Size = new System.Drawing.Size(194, 67);
			this.but_stop.TabIndex = 16;
			this.but_stop.Text = "STOP (SPC)";
			this.but_stop.UseVisualStyleBackColor = false;
			this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
			// 
			// Joystick
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 341);
			this.Controls.Add(this.but_stop);
			this.Controls.Add(this.panel1);
			this.KeyPreview = true;
			this.Name = "Joystick";
			this.Text = "Joystick";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Joystick_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Joystick_KeyPressed);
			((System.ComponentModel.ISupportInitialize)(this.trackBar_linealSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_angularSpeed)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TrackBar trackBar_linealSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar trackBar_angularSpeed;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button but_stop;
	}
}