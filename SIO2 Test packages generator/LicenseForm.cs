using System.Windows.Forms;

namespace SIO2_Test_packages_generator
{
	public partial class LicenseForm : MetroFramework.Forms.MetroForm
	{
		public LicenseForm()
		{
			InitializeComponent();
		}

		private void LicenseForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
	}
}
