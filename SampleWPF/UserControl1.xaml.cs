using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleWPF
{
	/// <summary>
	/// Logica di interazione per UserControl1.xaml
	/// </summary>
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
