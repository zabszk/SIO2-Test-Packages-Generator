using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIO2_Test_packages_generator
{
	public partial class BulkAdding : MetroFramework.Forms.MetroForm
	{
		public BulkAdding()
		{
			InitializeComponent();
		}

		private void ModeChanged(object sender, EventArgs e)
		{
			folderModePanel.Enabled = folderModeRadio.Checked;
			fileModePanel.Enabled = fileModeRadio.Checked;
		}
	}
}
