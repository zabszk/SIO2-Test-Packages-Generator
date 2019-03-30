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
			Target = new Test();
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

			switch (Target.Flags)
			{
				case (ushort)TestFlags.Slow:
					typeComboBox.Text = "Slow";
					break;

				case (ushort)TestFlags.Incorrect:
					typeComboBox.Text = "Incorrect";
					break;

				default:
					typeComboBox.Text = "Normal";
					break;
			}
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
			switch (typeComboBox.Text)
			{
				case "Slow":
					Target.Flags = (ushort)TestFlags.Slow;
					break;

				case "Incorrect":
					Target.Flags = (ushort)TestFlags.Incorrect;
					break;

				default:
					Target.Flags = 0;
					break;
			}
		}

		private void generateOutputButton_Click(object sender, EventArgs e)
		{
			generateOutputButton.Enabled = false;
			outputTextBox.Enabled = false;
			outputTextBox.Text = "Generation in progress...";

			MainForm.Package.GenerateOutput(inputTextBox.Lines, this);
		}

		public void OutputGenerated(IEnumerable<string> output, int time, int memory)
		{
			outputTextBox.Text =
				output.Aggregate("", (current, line) => current + (line.Trim('\n', '\r') + Environment.NewLine));

			Target.SetExecutionStats(time, memory);

			if (Target.TimeLimit == 0)
				Target.TimeLimit = Target.RecommendedTimeLimit;

			if (Target.MemoryLimit == 0)
				Target.MemoryLimit = Target.RecommendedMemoryLimit;

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
					Target.TestName = tb.Text.ToLower();
					idTextBox.Text = idTextBox.Text.ToLower();
					break;

				case "inputTextBox":
					Target.Input = tb.Lines;
					break;

				case "outputTextBox":
					Target.Output = tb.Lines;
					break;
			}
		}
	}
}
