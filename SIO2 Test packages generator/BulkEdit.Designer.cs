namespace SIO2_Test_packages_generator
{
    partial class BulkEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.timeCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.memoryCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.pointsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.timeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.memoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // pointsCheckBox
            // 
            this.pointsCheckBox.AutoSize = true;
            this.pointsCheckBox.Location = new System.Drawing.Point(23, 74);
            this.pointsCheckBox.Name = "pointsCheckBox";
            this.pointsCheckBox.Size = new System.Drawing.Size(78, 15);
            this.pointsCheckBox.TabIndex = 0;
            this.pointsCheckBox.Text = "Set points:";
            this.pointsCheckBox.UseSelectable = true;
            this.pointsCheckBox.CheckedChanged += new System.EventHandler(this.PointsCheckBox_CheckedChanged);
            // 
            // timeCheckBox
            // 
            this.timeCheckBox.AutoSize = true;
            this.timeCheckBox.Location = new System.Drawing.Point(23, 103);
            this.timeCheckBox.Name = "timeCheckBox";
            this.timeCheckBox.Size = new System.Drawing.Size(96, 15);
            this.timeCheckBox.TabIndex = 1;
            this.timeCheckBox.Text = "Set time limit:";
            this.timeCheckBox.UseSelectable = true;
            this.timeCheckBox.CheckedChanged += new System.EventHandler(this.TimeCheckBox_CheckedChanged);
            // 
            // memoryCheckBox
            // 
            this.memoryCheckBox.AutoSize = true;
            this.memoryCheckBox.Location = new System.Drawing.Point(23, 132);
            this.memoryCheckBox.Name = "memoryCheckBox";
            this.memoryCheckBox.Size = new System.Drawing.Size(117, 15);
            this.memoryCheckBox.TabIndex = 2;
            this.memoryCheckBox.Text = "Set memory limit:";
            this.memoryCheckBox.UseSelectable = true;
            this.memoryCheckBox.CheckedChanged += new System.EventHandler(this.MemoryCheckBox_CheckedChanged);
            // 
            // pointsTextBox
            // 
            // 
            // 
            // 
            this.pointsTextBox.CustomButton.Image = null;
            this.pointsTextBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.pointsTextBox.CustomButton.Name = "";
            this.pointsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pointsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pointsTextBox.CustomButton.TabIndex = 1;
            this.pointsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pointsTextBox.CustomButton.UseSelectable = true;
            this.pointsTextBox.CustomButton.Visible = false;
            this.pointsTextBox.Enabled = false;
            this.pointsTextBox.Lines = new string[0];
            this.pointsTextBox.Location = new System.Drawing.Point(146, 66);
            this.pointsTextBox.MaxLength = 32767;
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.PasswordChar = '\0';
            this.pointsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pointsTextBox.SelectedText = "";
            this.pointsTextBox.SelectionLength = 0;
            this.pointsTextBox.SelectionStart = 0;
            this.pointsTextBox.ShortcutsEnabled = true;
            this.pointsTextBox.Size = new System.Drawing.Size(144, 23);
            this.pointsTextBox.TabIndex = 3;
            this.pointsTextBox.UseSelectable = true;
            this.pointsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pointsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timeTextBox
            // 
            // 
            // 
            // 
            this.timeTextBox.CustomButton.Image = null;
            this.timeTextBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.timeTextBox.CustomButton.Name = "";
            this.timeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.timeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeTextBox.CustomButton.TabIndex = 1;
            this.timeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeTextBox.CustomButton.UseSelectable = true;
            this.timeTextBox.CustomButton.Visible = false;
            this.timeTextBox.Enabled = false;
            this.timeTextBox.Lines = new string[0];
            this.timeTextBox.Location = new System.Drawing.Point(146, 95);
            this.timeTextBox.MaxLength = 32767;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.PasswordChar = '\0';
            this.timeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeTextBox.SelectedText = "";
            this.timeTextBox.SelectionLength = 0;
            this.timeTextBox.SelectionStart = 0;
            this.timeTextBox.ShortcutsEnabled = true;
            this.timeTextBox.Size = new System.Drawing.Size(144, 23);
            this.timeTextBox.TabIndex = 4;
            this.timeTextBox.UseSelectable = true;
            this.timeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // memoryTextBox
            // 
            // 
            // 
            // 
            this.memoryTextBox.CustomButton.Image = null;
            this.memoryTextBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.memoryTextBox.CustomButton.Name = "";
            this.memoryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.memoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.memoryTextBox.CustomButton.TabIndex = 1;
            this.memoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.memoryTextBox.CustomButton.UseSelectable = true;
            this.memoryTextBox.CustomButton.Visible = false;
            this.memoryTextBox.Enabled = false;
            this.memoryTextBox.Lines = new string[0];
            this.memoryTextBox.Location = new System.Drawing.Point(146, 124);
            this.memoryTextBox.MaxLength = 32767;
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.PasswordChar = '\0';
            this.memoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoryTextBox.SelectedText = "";
            this.memoryTextBox.SelectionLength = 0;
            this.memoryTextBox.SelectionStart = 0;
            this.memoryTextBox.ShortcutsEnabled = true;
            this.memoryTextBox.Size = new System.Drawing.Size(144, 23);
            this.memoryTextBox.TabIndex = 5;
            this.memoryTextBox.UseSelectable = true;
            this.memoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.memoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(146, 163);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BulkEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 205);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.memoryTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(this.memoryCheckBox);
            this.Controls.Add(this.timeCheckBox);
            this.Controls.Add(this.pointsCheckBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BulkEdit";
            this.Resizable = false;
            this.Text = "Bulk Tests Editing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BulkEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox pointsCheckBox;
        private MetroFramework.Controls.MetroCheckBox timeCheckBox;
        private MetroFramework.Controls.MetroCheckBox memoryCheckBox;
        private MetroFramework.Controls.MetroTextBox pointsTextBox;
        private MetroFramework.Controls.MetroTextBox timeTextBox;
        private MetroFramework.Controls.MetroTextBox memoryTextBox;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}