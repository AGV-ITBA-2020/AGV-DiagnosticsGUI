namespace AGV_GUI
{
	partial class RtosDiag
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
			this.but_getRuntimeStats = new System.Windows.Forms.Button();
			this.but_getTaskStats = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// but_getRuntimeStats
			// 
			this.but_getRuntimeStats.Location = new System.Drawing.Point(12, 24);
			this.but_getRuntimeStats.Name = "but_getRuntimeStats";
			this.but_getRuntimeStats.Size = new System.Drawing.Size(262, 45);
			this.but_getRuntimeStats.TabIndex = 0;
			this.but_getRuntimeStats.Text = "Runtime Stats";
			this.but_getRuntimeStats.UseVisualStyleBackColor = true;
			this.but_getRuntimeStats.Click += new System.EventHandler(this.but_getRuntimeStats_Click);
			// 
			// but_getTaskStats
			// 
			this.but_getTaskStats.Location = new System.Drawing.Point(12, 90);
			this.but_getTaskStats.Name = "but_getTaskStats";
			this.but_getTaskStats.Size = new System.Drawing.Size(262, 45);
			this.but_getTaskStats.TabIndex = 1;
			this.but_getTaskStats.Text = "Task Stats";
			this.but_getTaskStats.UseVisualStyleBackColor = true;
			this.but_getTaskStats.Click += new System.EventHandler(this.but_getTaskStats_Click);
			// 
			// RtosDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 491);
			this.Controls.Add(this.but_getTaskStats);
			this.Controls.Add(this.but_getRuntimeStats);
			this.Location = new System.Drawing.Point(1200, 0);
			this.Name = "RtosDiag";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "RtosDiag";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RtosDiag_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button but_getRuntimeStats;
		private System.Windows.Forms.Button but_getTaskStats;
	}
}