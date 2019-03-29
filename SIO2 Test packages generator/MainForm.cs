using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using SIO2_Test_packages_generator.Data;

namespace SIO2_Test_packages_generator
{
	public partial class MainForm : MetroFramework.Forms.MetroForm
	{
		internal static Package Package;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			tabControl.SelectedIndex = 0;

			Package = new Package();
			testsGrid.DataSource = Package.TestsSource;
		}

		internal void ConfigBrowse(object sender, EventArgs e)
		{
			if (browseFileDialog.ShowDialog() != DialogResult.OK) return;

			switch (((Button) sender).Name)
			{
				case "docsBrowse":
					docsTextBox.Text = browseFileDialog.FileName;
					break;

				case "srcBrowse":
					srcTextBox.Text = browseFileDialog.FileName;
					break;

				case "checkerBrowse":
					checkerTextBox.Text = browseFileDialog.FileName;
					break;

				case "generatorBrowse":
					generatorTextBox.Text = browseFileDialog.FileName;
					break;

				case "binBrowse":
					binTextBox.Text = browseFileDialog.FileName;
					break;
			}
		}

		internal void RefreshBinaryLocks(object sender, EventArgs e)
		{
			if (binaryManual.Checked)
				binTextBox.Enabled = binBrowse.Enabled = launchCommandTextBox.Enabled = false;
			else if (binarySpecified.Checked)
			{
				binTextBox.Enabled = binBrowse.Enabled = true;
				launchCommandTextBox.Enabled = false;
			}
			else
			{
				binTextBox.Enabled = binBrowse.Enabled = false;
				launchCommandTextBox.Enabled = true;
			}
		}

		private void checkerCheckBox_CheckedChanged(object sender, EventArgs e) =>
			checkerTextBox.Enabled = checkerBrowse.Enabled = checkerCheckBox.Checked;

		private void generatorCheckBox_CheckedChanged(object sender, EventArgs e) =>
			generatorTextBox.Enabled = generatorBrowse.Enabled = generatorCheckBox.Checked;

		private void metroLink1_Click(object sender, EventArgs e) => new LicenseForm().ShowDialog();

		private void addTestButton_Click(object sender, EventArgs e)
		{

		}
	}
}
