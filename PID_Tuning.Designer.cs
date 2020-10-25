namespace AGV_GUI
{
	partial class PID_Tuning
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
			this.plotter_rMotor = new ScottPlot.FormsPlot();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rMtr_updateKpid = new System.Windows.Forms.Button();
			this.rMtr_sendKpid = new System.Windows.Forms.Button();
			this.txtBox_rMtr_Kd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBox_rMtr_Ki = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBox_rMtr_Kp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lMtr_updateKpid = new System.Windows.Forms.Button();
			this.lMtr_sendKpid = new System.Windows.Forms.Button();
			this.txtBox_lMtr_Kd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBox_lMtr_Ki = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBox_lMtr_Kp = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.plotter_lMotor = new ScottPlot.FormsPlot();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_speedMsg = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// plotter_rMotor
			// 
			this.plotter_rMotor.Location = new System.Drawing.Point(6, 19);
			this.plotter_rMotor.Name = "plotter_rMotor";
			this.plotter_rMotor.Size = new System.Drawing.Size(862, 318);
			this.plotter_rMotor.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.plotter_rMotor);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1012, 350);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Motor Derecho";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rMtr_updateKpid);
			this.groupBox2.Controls.Add(this.rMtr_sendKpid);
			this.groupBox2.Controls.Add(this.txtBox_rMtr_Kd);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtBox_rMtr_Ki);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtBox_rMtr_Kp);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(874, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(132, 192);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PID";
			// 
			// rMtr_updateKpid
			// 
			this.rMtr_updateKpid.Location = new System.Drawing.Point(19, 148);
			this.rMtr_updateKpid.Name = "rMtr_updateKpid";
			this.rMtr_updateKpid.Size = new System.Drawing.Size(94, 30);
			this.rMtr_updateKpid.TabIndex = 7;
			this.rMtr_updateKpid.Text = "Actualizar";
			this.rMtr_updateKpid.UseVisualStyleBackColor = true;
			this.rMtr_updateKpid.Click += new System.EventHandler(this.rMtr_updateKpid_Click);
			// 
			// rMtr_sendKpid
			// 
			this.rMtr_sendKpid.Location = new System.Drawing.Point(19, 112);
			this.rMtr_sendKpid.Name = "rMtr_sendKpid";
			this.rMtr_sendKpid.Size = new System.Drawing.Size(94, 30);
			this.rMtr_sendKpid.TabIndex = 6;
			this.rMtr_sendKpid.Text = "Enviar";
			this.rMtr_sendKpid.UseVisualStyleBackColor = true;
			this.rMtr_sendKpid.Click += new System.EventHandler(this.rMotor_sendKpid_Click);
			// 
			// txtBox_rMtr_Kd
			// 
			this.txtBox_rMtr_Kd.Location = new System.Drawing.Point(56, 86);
			this.txtBox_rMtr_Kd.Name = "txtBox_rMtr_Kd";
			this.txtBox_rMtr_Kd.Size = new System.Drawing.Size(57, 20);
			this.txtBox_rMtr_Kd.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kd =";
			// 
			// txtBox_rMtr_Ki
			// 
			this.txtBox_rMtr_Ki.Location = new System.Drawing.Point(56, 60);
			this.txtBox_rMtr_Ki.Name = "txtBox_rMtr_Ki";
			this.txtBox_rMtr_Ki.Size = new System.Drawing.Size(57, 20);
			this.txtBox_rMtr_Ki.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ki =";
			// 
			// txtBox_rMtr_Kp
			// 
			this.txtBox_rMtr_Kp.Location = new System.Drawing.Point(56, 34);
			this.txtBox_rMtr_Kp.Name = "txtBox_rMtr_Kp";
			this.txtBox_rMtr_Kp.Size = new System.Drawing.Size(57, 20);
			this.txtBox_rMtr_Kp.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kp =";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pictureBox2);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.plotter_lMotor);
			this.groupBox3.Location = new System.Drawing.Point(12, 376);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1012, 350);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Motor Izquierdo";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lMtr_updateKpid);
			this.groupBox4.Controls.Add(this.lMtr_sendKpid);
			this.groupBox4.Controls.Add(this.txtBox_lMtr_Kd);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.txtBox_lMtr_Ki);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.txtBox_lMtr_Kp);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Location = new System.Drawing.Point(874, 19);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(132, 192);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "PID";
			// 
			// lMtr_updateKpid
			// 
			this.lMtr_updateKpid.Location = new System.Drawing.Point(19, 148);
			this.lMtr_updateKpid.Name = "lMtr_updateKpid";
			this.lMtr_updateKpid.Size = new System.Drawing.Size(94, 30);
			this.lMtr_updateKpid.TabIndex = 7;
			this.lMtr_updateKpid.Text = "Actualizar";
			this.lMtr_updateKpid.UseVisualStyleBackColor = true;
			this.lMtr_updateKpid.Click += new System.EventHandler(this.lMtr_updateKpid_Click);
			// 
			// lMtr_sendKpid
			// 
			this.lMtr_sendKpid.Location = new System.Drawing.Point(19, 112);
			this.lMtr_sendKpid.Name = "lMtr_sendKpid";
			this.lMtr_sendKpid.Size = new System.Drawing.Size(94, 30);
			this.lMtr_sendKpid.TabIndex = 6;
			this.lMtr_sendKpid.Text = "Enviar";
			this.lMtr_sendKpid.UseVisualStyleBackColor = true;
			this.lMtr_sendKpid.Click += new System.EventHandler(this.lMtr_sendKpid_Click);
			// 
			// txtBox_lMtr_Kd
			// 
			this.txtBox_lMtr_Kd.Location = new System.Drawing.Point(56, 86);
			this.txtBox_lMtr_Kd.Name = "txtBox_lMtr_Kd";
			this.txtBox_lMtr_Kd.Size = new System.Drawing.Size(57, 20);
			this.txtBox_lMtr_Kd.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Kd =";
			// 
			// txtBox_lMtr_Ki
			// 
			this.txtBox_lMtr_Ki.Location = new System.Drawing.Point(56, 60);
			this.txtBox_lMtr_Ki.Name = "txtBox_lMtr_Ki";
			this.txtBox_lMtr_Ki.Size = new System.Drawing.Size(57, 20);
			this.txtBox_lMtr_Ki.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ki =";
			// 
			// txtBox_lMtr_Kp
			// 
			this.txtBox_lMtr_Kp.Location = new System.Drawing.Point(56, 34);
			this.txtBox_lMtr_Kp.Name = "txtBox_lMtr_Kp";
			this.txtBox_lMtr_Kp.Size = new System.Drawing.Size(57, 20);
			this.txtBox_lMtr_Kp.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Kp =";
			// 
			// plotter_lMotor
			// 
			this.plotter_lMotor.Location = new System.Drawing.Point(6, 19);
			this.plotter_lMotor.Name = "plotter_lMotor";
			this.plotter_lMotor.Size = new System.Drawing.Size(862, 318);
			this.plotter_lMotor.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_speedMsg});
			this.statusStrip1.Location = new System.Drawing.Point(0, 728);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "Estado:";
			// 
			// status_speedMsg
			// 
			this.status_speedMsg.Name = "status_speedMsg";
			this.status_speedMsg.Size = new System.Drawing.Size(28, 17);
			this.status_speedMsg.Text = "       ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::AGV_GUI.Properties.Resources.left1;
			this.pictureBox2.InitialImage = global::AGV_GUI.Properties.Resources.right;
			this.pictureBox2.Location = new System.Drawing.Point(874, 292);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(79, 45);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AGV_GUI.Properties.Resources.right1;
			this.pictureBox1.InitialImage = global::AGV_GUI.Properties.Resources.right;
			this.pictureBox1.Location = new System.Drawing.Point(874, 292);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(79, 45);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// PID_Tuning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 750);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "PID_Tuning";
			this.Text = "PID_Viewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PID_Config_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ScottPlot.FormsPlot plotter_rMotor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button rMtr_sendKpid;
		private System.Windows.Forms.TextBox txtBox_rMtr_Kd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBox_rMtr_Ki;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBox_rMtr_Kp;
		private System.Windows.Forms.Button rMtr_updateKpid;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button lMtr_updateKpid;
		private System.Windows.Forms.Button lMtr_sendKpid;
		private System.Windows.Forms.TextBox txtBox_lMtr_Kd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBox_lMtr_Ki;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBox_lMtr_Kp;
		private System.Windows.Forms.Label label6;
		private ScottPlot.FormsPlot plotter_lMotor;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status_speedMsg;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}