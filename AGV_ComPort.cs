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
		PC_MOVE,
		CM
	}
	public struct GUI_MODULES
	{
		public bool joystick;
		public bool pidTuning;
	}
	public class AGV_MsgDataPair
	{
		public string paramStr;
		public double value;
	}
	public class AGV_Msg
	{
		public MSG_ORIGIN_T origin;
		public string id;
		public List<AGV_MsgDataPair> data;
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
				case "CM":
					retVal = MSG_ORIGIN_T.CM;
					break;
			}
			return retVal;
		}
		public AGV_Msg()
		{
			data = new List<AGV_MsgDataPair>();
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
		public AGV_State state;		// Stores AGV current state values
		public GUI_MODULES activeModules;	// States which modules are active from the GUI
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
		/// <summary>
		/// Messages come as:
		/// " MOD_NAME + '>' + MSG_ID + ':' + PARAM1 + '=' + VALUE1 + ';' + PARAM2 + ...
		/// </summary>
		/// <param name="s"></param>
		public void PortProcessDataString(string s)
		{
			AGV_Msg msg = new AGV_Msg();
			int originEnd = s.IndexOf('>');
			if(originEnd == -1)	// Nothing found. Return
				return;
			msg.origin = msg.GetOriginFromString(s.Substring(0, originEnd));

			int idEnd = s.IndexOf(";");
			if(idEnd == -1)	// No params for this message. ID is until the EOF
				idEnd = s.Length;
			msg.id = s.Substring(originEnd+1, idEnd-originEnd-1);

			// Check if theres is a value and extract
			if(idEnd != s.Length)
			{
				string subS = s.Substring(idEnd+1);	// Get 
				AGV_MsgDataPair pair = new AGV_MsgDataPair();
				int divIndex = subS.IndexOf(";");
				int equalIndex = subS.IndexOf("=");

				do
				{
					if(equalIndex == -1)	// ERROR
						break;
						
					if(divIndex == -1)	// Then this is the last param
						divIndex = subS.Length;

					// Get data from string
					pair.paramStr = subS.Substring(0,equalIndex);
					if(double.TryParse(subS.Substring(equalIndex+1,divIndex-1-equalIndex), System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out pair.value) == false)
						pair.value = -999;
					msg.data.Add(pair);
						
					if(divIndex < subS.Length)	// Then prepare for next param
					{
						subS = subS.Substring(divIndex+1);
						divIndex = subS.IndexOf(";");
						equalIndex = subS.IndexOf("=");
						pair = new AGV_MsgDataPair();
					}
				} while(divIndex < subS.Length);
			}

			msgList.Add(msg);			
		}
	}
}
