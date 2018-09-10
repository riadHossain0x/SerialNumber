using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SerialNumber
{
	public partial class frmmain
	{
		public frmmain()
		{
			InitializeComponent();
		}

		private string SerialNumber()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Microsoft.VisualBasic.Interaction.GetObject("WinMgmts:", null));
			string text = "";
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "InstancesOf", new object[] {"Win32_BaseBoard"}, null, null, null));
			try
			{
				IEnumerator enumerator = ((IEnumerable)objectValue2).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(", ", NewLateBinding.LateGet(objectValue3, null, "SerialNumber", new object[0], null, null, null))));
				}
			}
			catch (Exception ex)
			{

			}
			bool flag = text.Length > 0;
			if (flag)
			{
				text = text.Substring(2);
			}
			return text;
		}

		private void frmmain_Load(object sender, EventArgs e)
		{
			Label1.Text = SerialNumber();
		}

		private static frmmain _DefaultInstance;
		public static frmmain DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new frmmain();

				return _DefaultInstance;
			}
		}
	}

}