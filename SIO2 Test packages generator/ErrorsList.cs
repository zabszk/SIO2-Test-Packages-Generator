using System;
using System.Linq;

namespace SIO2_Test_packages_generator
{
	public partial class ErrorsList : MetroFramework.Forms.MetroForm
	{
		public ErrorsList(string[] errors)
		{
			InitializeComponent();
			errorsTextBox.Text = errors.Aggregate("", (current, line) => current + (line.Trim('\n', '\r') + Environment.NewLine));
		}
	}
}
