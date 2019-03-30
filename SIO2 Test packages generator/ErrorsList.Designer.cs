namespace SIO2_Test_packages_generator
{
	partial class ErrorsList
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
			this.errorsTextBox = new MetroFramework.Controls.MetroTextBox();
			this.SuspendLayout();
			// 
			// errorsTextBox
			// 
			// 
			// 
			// 
			this.errorsTextBox.CustomButton.Image = null;
			this.errorsTextBox.CustomButton.Location = new System.Drawing.Point(431, 2);
			this.errorsTextBox.CustomButton.Name = "";
			this.errorsTextBox.CustomButton.Size = new System.Drawing.Size(445, 445);
			this.errorsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.errorsTextBox.CustomButton.TabIndex = 1;
			this.errorsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.errorsTextBox.CustomButton.UseSelectable = true;
			this.errorsTextBox.CustomButton.Visible = false;
			this.errorsTextBox.Lines = new string[0];
			this.errorsTextBox.Location = new System.Drawing.Point(23, 63);
			this.errorsTextBox.MaxLength = 32767;
			this.errorsTextBox.Multiline = true;
			this.errorsTextBox.Name = "errorsTextBox";
			this.errorsTextBox.PasswordChar = '\0';
			this.errorsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.errorsTextBox.SelectedText = "";
			this.errorsTextBox.SelectionLength = 0;
			this.errorsTextBox.SelectionStart = 0;
			this.errorsTextBox.ShortcutsEnabled = true;
			this.errorsTextBox.Size = new System.Drawing.Size(879, 450);
			this.errorsTextBox.TabIndex = 0;
			this.errorsTextBox.UseSelectable = true;
			this.errorsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.errorsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// ErrorsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 536);
			this.Controls.Add(this.errorsTextBox);
			this.MaximizeBox = false;
			this.Name = "ErrorsList";
			this.Resizable = false;
			this.Text = "Errors List";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox errorsTextBox;
	}
}