namespace SIO2_Test_packages_generator
{
	partial class BulkAddingConfirmationForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.confirmationGrid = new MetroFramework.Controls.MetroGrid();
			this.confirmButton = new MetroFramework.Controls.MetroButton();
			this.abortButton = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.confirmationGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// confirmationGrid
			// 
			this.confirmationGrid.AllowUserToAddRows = false;
			this.confirmationGrid.AllowUserToDeleteRows = false;
			this.confirmationGrid.AllowUserToResizeRows = false;
			this.confirmationGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.confirmationGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.confirmationGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.confirmationGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.confirmationGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.confirmationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.confirmationGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.confirmationGrid.EnableHeadersVisualStyles = false;
			this.confirmationGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.confirmationGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.confirmationGrid.Location = new System.Drawing.Point(23, 63);
			this.confirmationGrid.Name = "confirmationGrid";
			this.confirmationGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.confirmationGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.confirmationGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.confirmationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.confirmationGrid.Size = new System.Drawing.Size(1099, 498);
			this.confirmationGrid.TabIndex = 0;
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(23, 567);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(75, 23);
			this.confirmButton.TabIndex = 1;
			this.confirmButton.Text = "Confirm";
			this.confirmButton.UseSelectable = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// abortButton
			// 
			this.abortButton.Location = new System.Drawing.Point(104, 567);
			this.abortButton.Name = "abortButton";
			this.abortButton.Size = new System.Drawing.Size(75, 23);
			this.abortButton.TabIndex = 2;
			this.abortButton.Text = "Abort";
			this.abortButton.UseSelectable = true;
			this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
			// 
			// BulkAddingConfirmationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1145, 605);
			this.Controls.Add(this.abortButton);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.confirmationGrid);
			this.MaximizeBox = false;
			this.Name = "BulkAddingConfirmationForm";
			this.Resizable = false;
			this.Text = "Bulk Adding Summary";
			this.Load += new System.EventHandler(this.BulkAddingConfirmationForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.confirmationGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid confirmationGrid;
		private MetroFramework.Controls.MetroButton confirmButton;
		private MetroFramework.Controls.MetroButton abortButton;
	}
}