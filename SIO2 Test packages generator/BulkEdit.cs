using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using SIO2_Test_packages_generator.Data;

namespace SIO2_Test_packages_generator
{
    public partial class BulkEdit : MetroFramework.Forms.MetroForm
    {
        private IEnumerable<Test> _tests;

        public BulkEdit(IEnumerable<Test> tests)
        {
            InitializeComponent();
            _tests = tests;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            uint points = 0, time = 0, memory = 0;

            if (pointsCheckBox.Checked)
            {
                if (!uint.TryParse(pointsTextBox.Text, out points))
                {
                    MetroMessageBox.Show(this, "Points must be an unsigned integer!", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (timeCheckBox.Checked)
            {
                if (!uint.TryParse(timeTextBox.Text, out time))
                {
                    MetroMessageBox.Show(this, "Time limit must be an unsigned integer!", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (memoryCheckBox.Checked)
            {
                if (!uint.TryParse(memoryTextBox.Text, out memory))
                {
                    MetroMessageBox.Show(this, "Memory limit must be an unsigned integer!", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            foreach (var test in _tests)
            {
                if (pointsCheckBox.Checked) test.Points = points;
                if (timeCheckBox.Checked) test.TimeLimit = time;
                if (memoryCheckBox.Checked) test.MemoryLimit = memory;
            }

            MainForm.Instance.RefreshGridView();
            Close();
        }

        private void PointsCheckBox_CheckedChanged(object sender, EventArgs e) =>
            pointsTextBox.Enabled = pointsCheckBox.Checked;

        private void TimeCheckBox_CheckedChanged(object sender, EventArgs e) =>
            timeTextBox.Enabled = timeCheckBox.Checked;

        private void MemoryCheckBox_CheckedChanged(object sender, EventArgs e) =>
            memoryTextBox.Enabled = memoryCheckBox.Checked;

        private void BulkEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;
            e.Handled = true;
            Close();
        }
    }
}
