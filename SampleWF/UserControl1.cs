using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWF
{
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			InitializeComponent();
		}

		[TypeConverter(typeof(TargetFrameSelector))]
		public string TheFrame { get; set; }

	}



	public class TargetFrameSelector : StringConverter
	{
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> values = new List<string>();

			if (context == null)
			{
				values.Add("Context is null");
			}
			else
			{
				values.Add("Context: " + context.ToString());

				if (context.Instance == null)
					values.Add("Instance is null");
				else
					values.Add("Instance: " + context.Instance.ToString());
			}

			return new StandardValuesCollection(values);
		}

	}

}
