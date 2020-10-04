using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Globalization;
using System.ComponentModel;

namespace AGV_GUI
{
	public enum MSG_ORIGIN_T
	{
		NONE,
		CC,
		COMS,
		PC,
		PC_MOVE
	}
	public class AGV_Msg
	{
		public MSG_ORIGIN_T origin;
		public string id;
		public double value;
		public MSG_ORIGIN_T GetOriginFromString(string s)
		{
			MSG_ORIGIN_T retVal = MSG_ORIGIN_T.NONE;
			switch(s)
			{
				case "CC":
					retVal = MSG_ORIGIN_T.CC;
					break;
				case "COMS":
					retVal = MSG_ORIGIN_T.COMS;
					break;
				case "PC":
					retVal = MSG_ORIGIN_T.PC;
					break;
				case "PC_MOVE":
					retVal = MSG_ORIGIN_T.PC_MOVE;
					break;
			}
			return retVal;
		}
	}
	public class AGV_State
	{
		public double vLastKnown;	// Last known AGV linear speed
		public double wLastKnwon;	// Last known AGV angular speed
	}
	public class AGV_ComPort
	{
		public SerialPort port;
		public List<AGV_Msg> msgList;
		public AGV_State state;
		public AGV_ComPort(SerialPort s)
		{
			port = s;
			msgList = new List<AGV_Msg>();
		}
		public void PortSendData(string s)
		{
			if(port.IsOpen)
				port.Write(s + "\r\n");
		}
		public void PortProcessDataString(string s)
		{
			AGV_Msg msg = new AGV_Msg();
			int originEnd = s.IndexOf('>');
			if(originEnd == -1)	// Nothing found. Return
				return;
			msg.origin = msg.GetOriginFromString(s.Substring(0, originEnd));

			int idEnd = s.IndexOf("=");
			if(idEnd == -1)	// No value for this message. ID is until the EOF
				idEnd = s.Length;
			msg.id = s.Substring(originEnd+1, idEnd-originEnd-1);

			// Check if theres is a value and extract
			if(idEnd != s.Length)
			{
				if(double.TryParse(s.Substring(idEnd+1), System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out msg.value) == false)
					msg.value = -999;
			}

			msgList.Add(msg);
		}
	}
}
