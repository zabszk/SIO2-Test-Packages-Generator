﻿namespace SIO2_Test_packages_generator
{
	partial class LicenseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 60);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(590, 513);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
			// 
			// LicenseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 583);
			this.Controls.Add(this.metroLabel1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "LicenseForm";
			this.Resizable = false;
			this.Text = "SIO2 Test Packages Generator - License";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LicenseForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}