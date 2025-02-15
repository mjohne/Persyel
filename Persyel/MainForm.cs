using System.Diagnostics;
using System.Windows.Forms;

namespace Persyel
{
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}
	}
}
