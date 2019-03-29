using System.Collections.Generic;
using System.ComponentModel;

namespace SIO2_Test_packages_generator.Data
{
	public class Test
	{
		public Test(bool init)
		{
			Points = 20;
			SetExecutionStats(-1, -1);
			if (!init) return;
		}

		public Test(int time, int memory, bool init)
		{
			Points = 20;
			SetExecutionStats(time, memory);
			if (!init) return;
		}

		[DisplayName("Name")]
		public string TestName { get; internal set; }

		public uint Points { get; set; }

		public string Type
		{
			get
			{
				if (!string.IsNullOrEmpty(TestName) && TestName.StartsWith("0")) return "Init";

				switch (Flags)
				{
					case (ushort)TestFlags.Slow:
						return "Slow";

					case (ushort)TestFlags.Incorrect:
						return "Incorrect";

					default:
						return "Normal";
				}
			}
		}

		[DisplayName("Time [ms]")]
		public int Time { get; private set; }

		[DisplayName("Memory [KiB]")]
		public int Memory { get; private set; }

		[DisplayName("Time Limit")]
		public uint TimeLimit { get; set; }

		[DisplayName("Memory Limit")]
		public uint MemoryLimit { get; set; }

		[DisplayName("Suggested Time Limit")]
		public uint SuggestedTimeLimit => (uint) (Time > 0 ? Time * 2 + 100 : 10000);

		[DisplayName("Suggested Memory Limit")]
		public uint SuggestedMemoryLimit => (uint) (Memory > 0 ? Memory + 512 : 32768);

		public string[] Input, Output;
		public ushort Flags;
		internal TestEditor Editor;

		public void SetExecutionStats(int time, int memory)
		{
			Time = time;
			Memory = memory;
		}

		internal void OpenEditor()
		{
			if (Editor != null) Editor.FocusMe();
			else
			{
				Editor = new TestEditor(this);
				Editor.Show();
			}
		}

		internal void EditorClosed()
		{
			Editor = null;
			MainForm.Instance.RefreshGridView();
		} 
	}
}
