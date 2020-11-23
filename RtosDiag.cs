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
	public partial class RtosDiag : Form
	{
		private AGV_ComPort agv;
		public RtosDiag(AGV_ComPort a)
		{
			InitializeComponent();
			agv = a;
			agv.activeModules.rtosDiag = true;
			agv.PortSendData("RTOS>START");
		}

		private void but_getRuntimeStats_Click(object sender, EventArgs e)
		{
			agv.PortSendData("RTOS>STRT");
		}

		private void but_getTaskStats_Click(object sender, EventArgs e)
		{
			agv.PortSendData("RTOS>STTSK");
		}

		private void RtosDiag_FormClosing(object sender, FormClosingEventArgs e)
		{
			agv.PortSendData("RTOS>STOP");
			agv.activeModules.rtosDiag = false;
		}
	}
}
