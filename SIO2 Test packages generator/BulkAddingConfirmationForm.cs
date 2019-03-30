using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SIO2_Test_packages_generator.Data;

namespace SIO2_Test_packages_generator
{
	public partial class BulkAddingConfirmationForm : MetroFramework.Forms.MetroForm
	{
		private List<Test> _tests;
		private BindingList<TestConfirmation> _binding;
		private BindingSource _source;

		public BulkAddingConfirmationForm(List<Test> tests)
		{
			InitializeComponent();
			_tests = tests;
			_binding = new BindingList<TestConfirmation>();

			foreach (var test in _tests)
				_binding.Add(new TestConfirmation(test));

			_source = new BindingSource(_binding, null);
		}

		private void BulkAddingConfirmationForm_Load(object sender, EventArgs e) => confirmationGrid.DataSource = _source;

		private void confirmButton_Click(object sender, EventArgs e)
		{
			confirmButton.Enabled = false;

			_binding.Where(test => test.Process).ToList().ForEach(test => MainForm.Package.Tests.Add(test.Test));
			MainForm.Instance.RefreshGridView();

			Close();
		}

		private void abortButton_Click(object sender, EventArgs e) => Close();
	}
}
