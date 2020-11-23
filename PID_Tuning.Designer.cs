﻿namespace AGV_GUI
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
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtbox_rightMotor_wR = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtbox_rightMotor_sR = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rMtr_updateKpid = new System.Windows.Forms.Button();
			this.rMtr_sendKpid = new System.Windows.Forms.Button();
			this.txtBox_rMtr_Kd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBox_rMtr_Ki = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBox_rMtr_Kp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.but_rMot_exportCSV = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtbox_leftMotor_wR = new System.Windows.Forms.TextBox();
			this.txtbox_leftMotor_sR = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.chkBox_filterInput = new System.Windows.Forms.CheckBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.but_trackPID_Update = new System.Windows.Forms.Button();
			this.but_trackPID_Send = new System.Windows.Forms.Button();
			this.txtbox_trackPID_Kd = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtbox_trackPID_Ki = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtbox_trackPID_Kp = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.plotter_trackError = new ScottPlot.FormsPlot();
			this.chkbox_startTrackGraph = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// plotter_rMotor
			// 
			this.plotter_rMotor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotter_rMotor.Location = new System.Drawing.Point(8, 23);
			this.plotter_rMotor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.plotter_rMotor.Name = "plotter_rMotor";
			this.plotter_rMotor.Size = new System.Drawing.Size(1344, 391);
			this.plotter_rMotor.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtbox_rightMotor_wR);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.txtbox_rightMotor_sR);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.plotter_rMotor);
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(1519, 431);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Motor Derecho";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(1376, 310);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 20);
			this.label11.TabIndex = 14;
			this.label11.Text = "W=";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(1376, 278);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 20);
			this.label10.TabIndex = 13;
			this.label10.Text = "SP=";
			// 
			// txtbox_rightMotor_wR
			// 
			this.txtbox_rightMotor_wR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbox_rightMotor_wR.Enabled = false;
			this.txtbox_rightMotor_wR.Location = new System.Drawing.Point(1421, 305);
			this.txtbox_rightMotor_wR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_rightMotor_wR.Name = "txtbox_rightMotor_wR";
			this.txtbox_rightMotor_wR.Size = new System.Drawing.Size(75, 22);
			this.txtbox_rightMotor_wR.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::AGV_GUI.Properties.Resources.right1;
			this.pictureBox1.InitialImage = global::AGV_GUI.Properties.Resources.right;
			this.pictureBox1.Location = new System.Drawing.Point(1380, 359);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(105, 55);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// txtbox_rightMotor_sR
			// 
			this.txtbox_rightMotor_sR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbox_rightMotor_sR.Enabled = false;
			this.txtbox_rightMotor_sR.Location = new System.Drawing.Point(1421, 273);
			this.txtbox_rightMotor_sR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_rightMotor_sR.Name = "txtbox_rightMotor_sR";
			this.txtbox_rightMotor_sR.Size = new System.Drawing.Size(75, 22);
			this.txtbox_rightMotor_sR.TabIndex = 11;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.rMtr_updateKpid);
			this.groupBox2.Controls.Add(this.rMtr_sendKpid);
			this.groupBox2.Controls.Add(this.txtBox_rMtr_Kd);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtBox_rMtr_Ki);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtBox_rMtr_Kp);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(1360, 23);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(151, 225);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PID";
			// 
			// rMtr_updateKpid
			// 
			this.rMtr_updateKpid.Location = new System.Drawing.Point(12, 182);
			this.rMtr_updateKpid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rMtr_updateKpid.Name = "rMtr_updateKpid";
			this.rMtr_updateKpid.Size = new System.Drawing.Size(125, 37);
			this.rMtr_updateKpid.TabIndex = 7;
			this.rMtr_updateKpid.Text = "Actualizar";
			this.rMtr_updateKpid.UseVisualStyleBackColor = true;
			this.rMtr_updateKpid.Click += new System.EventHandler(this.rMtr_updateKpid_Click);
			// 
			// rMtr_sendKpid
			// 
			this.rMtr_sendKpid.Location = new System.Drawing.Point(12, 138);
			this.rMtr_sendKpid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rMtr_sendKpid.Name = "rMtr_sendKpid";
			this.rMtr_sendKpid.Size = new System.Drawing.Size(125, 37);
			this.rMtr_sendKpid.TabIndex = 6;
			this.rMtr_sendKpid.Text = "Enviar";
			this.rMtr_sendKpid.UseVisualStyleBackColor = true;
			this.rMtr_sendKpid.Click += new System.EventHandler(this.rMotor_sendKpid_Click);
			// 
			// txtBox_rMtr_Kd
			// 
			this.txtBox_rMtr_Kd.Location = new System.Drawing.Point(61, 106);
			this.txtBox_rMtr_Kd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_rMtr_Kd.Name = "txtBox_rMtr_Kd";
			this.txtBox_rMtr_Kd.Size = new System.Drawing.Size(75, 22);
			this.txtBox_rMtr_Kd.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kd =";
			// 
			// txtBox_rMtr_Ki
			// 
			this.txtBox_rMtr_Ki.Location = new System.Drawing.Point(61, 74);
			this.txtBox_rMtr_Ki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_rMtr_Ki.Name = "txtBox_rMtr_Ki";
			this.txtBox_rMtr_Ki.Size = new System.Drawing.Size(75, 22);
			this.txtBox_rMtr_Ki.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 75);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ki =";
			// 
			// txtBox_rMtr_Kp
			// 
			this.txtBox_rMtr_Kp.Location = new System.Drawing.Point(61, 42);
			this.txtBox_rMtr_Kp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_rMtr_Kp.Name = "txtBox_rMtr_Kp";
			this.txtBox_rMtr_Kp.Size = new System.Drawing.Size(75, 22);
			this.txtBox_rMtr_Kp.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kp =";
			// 
			// but_rMot_exportCSV
			// 
			this.but_rMot_exportCSV.Location = new System.Drawing.Point(157, 23);
			this.but_rMot_exportCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.but_rMot_exportCSV.Name = "but_rMot_exportCSV";
			this.but_rMot_exportCSV.Size = new System.Drawing.Size(125, 37);
			this.but_rMot_exportCSV.TabIndex = 8;
			this.but_rMot_exportCSV.Text = "Exportar CSV";
			this.but_rMot_exportCSV.UseVisualStyleBackColor = true;
			this.but_rMot_exportCSV.Click += new System.EventHandler(this.but_rMot_exportCSV_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.txtbox_leftMotor_wR);
			this.groupBox3.Controls.Add(this.txtbox_leftMotor_sR);
			this.groupBox3.Controls.Add(this.pictureBox2);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.plotter_lMotor);
			this.groupBox3.Location = new System.Drawing.Point(16, 463);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(1519, 431);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Motor Izquierdo";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(1376, 315);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "W=";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(1376, 283);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(41, 20);
			this.label13.TabIndex = 17;
			this.label13.Text = "SP=";
			// 
			// txtbox_leftMotor_wR
			// 
			this.txtbox_leftMotor_wR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbox_leftMotor_wR.Enabled = false;
			this.txtbox_leftMotor_wR.Location = new System.Drawing.Point(1421, 310);
			this.txtbox_leftMotor_wR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_leftMotor_wR.Name = "txtbox_leftMotor_wR";
			this.txtbox_leftMotor_wR.Size = new System.Drawing.Size(75, 22);
			this.txtbox_leftMotor_wR.TabIndex = 16;
			// 
			// txtbox_leftMotor_sR
			// 
			this.txtbox_leftMotor_sR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbox_leftMotor_sR.Enabled = false;
			this.txtbox_leftMotor_sR.Location = new System.Drawing.Point(1421, 278);
			this.txtbox_leftMotor_sR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_leftMotor_sR.Name = "txtbox_leftMotor_sR";
			this.txtbox_leftMotor_sR.Size = new System.Drawing.Size(75, 22);
			this.txtbox_leftMotor_sR.TabIndex = 15;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::AGV_GUI.Properties.Resources.left1;
			this.pictureBox2.InitialImage = global::AGV_GUI.Properties.Resources.right;
			this.pictureBox2.Location = new System.Drawing.Point(1392, 359);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(105, 55);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.lMtr_updateKpid);
			this.groupBox4.Controls.Add(this.lMtr_sendKpid);
			this.groupBox4.Controls.Add(this.txtBox_lMtr_Kd);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.txtBox_lMtr_Ki);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.txtBox_lMtr_Kp);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Location = new System.Drawing.Point(1360, 23);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox4.Size = new System.Drawing.Size(151, 226);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "PID";
			// 
			// lMtr_updateKpid
			// 
			this.lMtr_updateKpid.Location = new System.Drawing.Point(12, 180);
			this.lMtr_updateKpid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lMtr_updateKpid.Name = "lMtr_updateKpid";
			this.lMtr_updateKpid.Size = new System.Drawing.Size(125, 37);
			this.lMtr_updateKpid.TabIndex = 7;
			this.lMtr_updateKpid.Text = "Actualizar";
			this.lMtr_updateKpid.UseVisualStyleBackColor = true;
			this.lMtr_updateKpid.Click += new System.EventHandler(this.lMtr_updateKpid_Click);
			// 
			// lMtr_sendKpid
			// 
			this.lMtr_sendKpid.Location = new System.Drawing.Point(12, 135);
			this.lMtr_sendKpid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lMtr_sendKpid.Name = "lMtr_sendKpid";
			this.lMtr_sendKpid.Size = new System.Drawing.Size(125, 37);
			this.lMtr_sendKpid.TabIndex = 6;
			this.lMtr_sendKpid.Text = "Enviar";
			this.lMtr_sendKpid.UseVisualStyleBackColor = true;
			this.lMtr_sendKpid.Click += new System.EventHandler(this.lMtr_sendKpid_Click);
			// 
			// txtBox_lMtr_Kd
			// 
			this.txtBox_lMtr_Kd.Location = new System.Drawing.Point(61, 103);
			this.txtBox_lMtr_Kd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_lMtr_Kd.Name = "txtBox_lMtr_Kd";
			this.txtBox_lMtr_Kd.Size = new System.Drawing.Size(75, 22);
			this.txtBox_lMtr_Kd.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 103);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Kd =";
			// 
			// txtBox_lMtr_Ki
			// 
			this.txtBox_lMtr_Ki.Location = new System.Drawing.Point(61, 71);
			this.txtBox_lMtr_Ki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_lMtr_Ki.Name = "txtBox_lMtr_Ki";
			this.txtBox_lMtr_Ki.Size = new System.Drawing.Size(75, 22);
			this.txtBox_lMtr_Ki.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 73);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ki =";
			// 
			// txtBox_lMtr_Kp
			// 
			this.txtBox_lMtr_Kp.Location = new System.Drawing.Point(61, 39);
			this.txtBox_lMtr_Kp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBox_lMtr_Kp.Name = "txtBox_lMtr_Kp";
			this.txtBox_lMtr_Kp.Size = new System.Drawing.Size(75, 22);
			this.txtBox_lMtr_Kp.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 39);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Kp =";
			// 
			// plotter_lMotor
			// 
			this.plotter_lMotor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotter_lMotor.Location = new System.Drawing.Point(8, 23);
			this.plotter_lMotor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.plotter_lMotor.Name = "plotter_lMotor";
			this.plotter_lMotor.Size = new System.Drawing.Size(1344, 391);
			this.plotter_lMotor.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_speedMsg});
			this.statusStrip1.Location = new System.Drawing.Point(0, 897);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1907, 26);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "Estado:";
			// 
			// status_speedMsg
			// 
			this.status_speedMsg.Name = "status_speedMsg";
			this.status_speedMsg.Size = new System.Drawing.Size(37, 20);
			this.status_speedMsg.Text = "       ";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.chkBox_filterInput);
			this.groupBox5.Controls.Add(this.but_rMot_exportCSV);
			this.groupBox5.Location = new System.Drawing.Point(7, 4);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox5.Size = new System.Drawing.Size(348, 69);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Misc";
			// 
			// chkBox_filterInput
			// 
			this.chkBox_filterInput.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkBox_filterInput.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkBox_filterInput.Location = new System.Drawing.Point(9, 25);
			this.chkBox_filterInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkBox_filterInput.Name = "chkBox_filterInput";
			this.chkBox_filterInput.Size = new System.Drawing.Size(140, 33);
			this.chkBox_filterInput.TabIndex = 0;
			this.chkBox_filterInput.Text = "Filtro Encoder";
			this.chkBox_filterInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkBox_filterInput.UseVisualStyleBackColor = true;
			this.chkBox_filterInput.CheckedChanged += new System.EventHandler(this.chkBox_filterInput_CheckedChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.button1);
			this.groupBox6.Controls.Add(this.but_trackPID_Update);
			this.groupBox6.Controls.Add(this.but_trackPID_Send);
			this.groupBox6.Controls.Add(this.txtbox_trackPID_Kd);
			this.groupBox6.Controls.Add(this.label7);
			this.groupBox6.Controls.Add(this.txtbox_trackPID_Ki);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Controls.Add(this.txtbox_trackPID_Kp);
			this.groupBox6.Controls.Add(this.label9);
			this.groupBox6.Location = new System.Drawing.Point(7, 7);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox6.Size = new System.Drawing.Size(341, 104);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "PID Pista";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 284);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 37);
			this.button1.TabIndex = 8;
			this.button1.Text = "Exportar CSV";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// but_trackPID_Update
			// 
			this.but_trackPID_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.but_trackPID_Update.Location = new System.Drawing.Point(179, 60);
			this.but_trackPID_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.but_trackPID_Update.Name = "but_trackPID_Update";
			this.but_trackPID_Update.Size = new System.Drawing.Size(115, 33);
			this.but_trackPID_Update.TabIndex = 7;
			this.but_trackPID_Update.Text = "Actualizar";
			this.but_trackPID_Update.UseVisualStyleBackColor = true;
			this.but_trackPID_Update.Click += new System.EventHandler(this.but_trackPID_Update_Click);
			// 
			// but_trackPID_Send
			// 
			this.but_trackPID_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.but_trackPID_Send.Location = new System.Drawing.Point(179, 20);
			this.but_trackPID_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.but_trackPID_Send.Name = "but_trackPID_Send";
			this.but_trackPID_Send.Size = new System.Drawing.Size(115, 33);
			this.but_trackPID_Send.TabIndex = 6;
			this.but_trackPID_Send.Text = "Enviar";
			this.but_trackPID_Send.UseVisualStyleBackColor = true;
			this.but_trackPID_Send.Click += new System.EventHandler(this.but_trackPID_Send_Click);
			// 
			// txtbox_trackPID_Kd
			// 
			this.txtbox_trackPID_Kd.Location = new System.Drawing.Point(75, 71);
			this.txtbox_trackPID_Kd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_trackPID_Kd.Name = "txtbox_trackPID_Kd";
			this.txtbox_trackPID_Kd.Size = new System.Drawing.Size(64, 22);
			this.txtbox_trackPID_Kd.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(21, 71);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "Kd =";
			// 
			// txtbox_trackPID_Ki
			// 
			this.txtbox_trackPID_Ki.Location = new System.Drawing.Point(75, 45);
			this.txtbox_trackPID_Ki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_trackPID_Ki.Name = "txtbox_trackPID_Ki";
			this.txtbox_trackPID_Ki.Size = new System.Drawing.Size(64, 22);
			this.txtbox_trackPID_Ki.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(21, 46);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Ki =";
			// 
			// txtbox_trackPID_Kp
			// 
			this.txtbox_trackPID_Kp.Location = new System.Drawing.Point(75, 20);
			this.txtbox_trackPID_Kp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbox_trackPID_Kp.Name = "txtbox_trackPID_Kp";
			this.txtbox_trackPID_Kp.Size = new System.Drawing.Size(64, 22);
			this.txtbox_trackPID_Kp.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(21, 20);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Kp =";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(1542, 15);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(365, 879);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.plotter_trackError);
			this.tabPage1.Controls.Add(this.groupBox6);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(357, 850);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Camino";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.chkbox_startTrackGraph);
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(357, 850);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Misc";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// plotter_trackError
			// 
			this.plotter_trackError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotter_trackError.Location = new System.Drawing.Point(9, 120);
			this.plotter_trackError.Margin = new System.Windows.Forms.Padding(5);
			this.plotter_trackError.Name = "plotter_trackError";
			this.plotter_trackError.Size = new System.Drawing.Size(338, 722);
			this.plotter_trackError.TabIndex = 3;
			// 
			// chkbox_startTrackGraph
			// 
			this.chkbox_startTrackGraph.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkbox_startTrackGraph.Checked = true;
			this.chkbox_startTrackGraph.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbox_startTrackGraph.Location = new System.Drawing.Point(16, 81);
			this.chkbox_startTrackGraph.Margin = new System.Windows.Forms.Padding(4);
			this.chkbox_startTrackGraph.Name = "chkbox_startTrackGraph";
			this.chkbox_startTrackGraph.Size = new System.Drawing.Size(329, 30);
			this.chkbox_startTrackGraph.TabIndex = 5;
			this.chkbox_startTrackGraph.Text = "Encender visor camino";
			this.chkbox_startTrackGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkbox_startTrackGraph.UseVisualStyleBackColor = true;
			// 
			// PID_Tuning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1907, 923);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "PID_Tuning";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PID_Viewer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PID_Config_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PID_Tuning_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PID_Tuning_KeyReleased);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
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
		private System.Windows.Forms.Button but_rMot_exportCSV;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox chkBox_filterInput;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button but_trackPID_Update;
		private System.Windows.Forms.Button but_trackPID_Send;
		private System.Windows.Forms.TextBox txtbox_trackPID_Kd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtbox_trackPID_Ki;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtbox_trackPID_Kp;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtbox_rightMotor_wR;
		private System.Windows.Forms.TextBox txtbox_rightMotor_sR;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtbox_leftMotor_wR;
		private System.Windows.Forms.TextBox txtbox_leftMotor_sR;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.CheckBox chkbox_startTrackGraph;
		private ScottPlot.FormsPlot plotter_trackError;
	}
}