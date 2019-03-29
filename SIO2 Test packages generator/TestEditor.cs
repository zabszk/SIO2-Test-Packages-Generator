using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using SIO2_Test_packages_generator.Data;

namespace SIO2_Test_packages_generator
{
	public partial class TestEditor : MetroFramework.Forms.MetroForm, IOutput
	{
		internal Test Target;

		public TestEditor()
		{
			InitializeComponent();
			Target = new Test(true);
		}

		public TestEditor(Test target)
		{
			InitializeComponent();
			Target = target;
		}

		private void TestEditor_Load(object sender, EventArgs e)
		{
			generateOutputButton.Enabled = !string.IsNullOrWhiteSpace(MainForm.Package.BinaryFile) ||
			                               !string.IsNullOrWhiteSpace(MainForm.Package.ExecCommand);

			idTextBox.Text = Target.TestName;
			pointsTextBox.Text = Target.Points.ToString();
			
			if (Target.Input != null)
				inputTextBox.Lines = Target.Input;

			if (Target.Output != null)
				outputTextBox.Lines = Target.Output;

			idTextBox.TextChanged += UpdateTextBox;
			inputTextBox.TextChanged += UpdateTextBox;
			outputTextBox.TextChanged += UpdateTextBox;
		}

		private void pointsTextBox_TextChanged(object sender, EventArgs e)
		{
			if (pointsTextBox.Text == string.Empty)
				Target.Points = 0;
			else if (uint.TryParse(pointsTextBox.Text, out var points))
				Target.Points = points;
			else
				pointsTextBox.Text = Target.Points.ToString();
		}

		private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void generateOutputButton_Click(object sender, EventArgs e)
		{
			generateOutputButton.Enabled = false;
			outputTextBox.Enabled = false;
			outputTextBox.Text = "Generation in progress...";

			MainForm.Package.GenerateOutput(inputTextBox.Lines, this);
		}

		public void OutputGenerated(IEnumerable<string> output)
		{
			outputTextBox.Text =
				output.Aggregate("", (current, line) => current + (line.Trim('\n', '\r') + Environment.NewLine));

			generateOutputButton.Enabled = true;
			outputTextBox.Enabled = true;
		}

		public void OutputGenerationFailed(string error)
		{
			outputTextBox.Text = "**OUTPUT GENERATION FAILED**" + Environment.NewLine + Environment.NewLine + error;

			generateOutputButton.Enabled = true;
			outputTextBox.Enabled = true;
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MetroMessageBox.Show(this, "Do you really want to delete this test?", "Confirm test deletion",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

			if (MainForm.Package.Tests.Contains(Target))
				MainForm.Package.Tests.Remove(Target);

			Close();
		}

		private void okButton_Click(object sender, EventArgs e) => Close();

		private void TestEditor_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) =>
			Target?.EditorClosed();

		internal void UpdateTextBox(object sender, EventArgs e)
		{
			var tb = (MetroTextBox)sender;

			switch (((MetroTextBox) sender).Name)
			{
				case "idTextBox":
					Target.TestName = tb.Text;
					break;

				case "inputTextBox":
					Target.Input = tb.Lines;
					break;

				case "outputTextBox":
					Target.Input = tb.Lines;
					break;
			}
		}
	}
}
