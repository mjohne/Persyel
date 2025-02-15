using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Persyel
{
	/// <summary>
	/// Main Form
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class MainForm : Form
	{
		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm() => InitializeComponent();

		#endregion

		#region	Helpers

		/// <summary>
		/// Get Debugger Display
		/// </summary>
		/// <returns>Return the debugger display</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			toolStripStatusLabelInformation.Text = text;
		}

		#endregion

		#region Load event handlers

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusbarText(text: string.Empty);
		}

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox textBox: SetStatusbarText(text: textBox.AccessibleDescription); break;
				case Button button: SetStatusbarText(text: button.AccessibleDescription); break;
				case RadioButton radioButton: SetStatusbarText(text: radioButton.AccessibleDescription); break;
				case CheckBox checkBox: SetStatusbarText(text: checkBox.AccessibleDescription); break;
				case DateTimePicker dateTimePicker: SetStatusbarText(text: dateTimePicker.AccessibleDescription); break;
				case Label label: SetStatusbarText(text: label.AccessibleDescription); break;
				case PictureBox pictureBox: SetStatusbarText(text: pictureBox.AccessibleDescription); break;
				case CheckedListBox checkedListBox: SetStatusbarText(text: checkedListBox.AccessibleDescription); break;
				case ComboBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case GroupBox group: SetStatusbarText(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbarText(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar monthCalendar: SetStatusbarText(text: monthCalendar.AccessibleDescription); break;
				case PropertyGrid propertyGrid: SetStatusbarText(text: propertyGrid.AccessibleDescription); break;
				case RichTextBox richTextBox: SetStatusbarText(text: richTextBox.AccessibleDescription); break;
				case ScrollBar scrollBar: SetStatusbarText(text: scrollBar.AccessibleDescription); break;
				case TrackBar trackBar: SetStatusbarText(text: trackBar.AccessibleDescription); break;
				case WebBrowser webBrowser: SetStatusbarText(text: webBrowser.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbarText(text: domainUpDown.AccessibleDescription); break;
				case ToolStripButton toolStripButton: SetStatusbarText(text: toolStripButton.AccessibleDescription); break;
				case ToolStripMenuItem toolStripMenuItem: SetStatusbarText(text: toolStripMenuItem.AccessibleDescription); break;
				case ToolStripLabel toolStripLabel: SetStatusbarText(text: toolStripLabel.AccessibleDescription); break;
				case ToolStripComboBox toolStripComboBox: SetStatusbarText(text: toolStripComboBox.AccessibleDescription); break;
				case ToolStripDropDown toolStripDropDown: SetStatusbarText(text: toolStripDropDown.AccessibleDescription); break;
				case ToolStripDropDownButton toolStripDropDownButton: SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription); break;
				case ToolStripDropDownItem toolStripDropDownItem: SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription); break;
				case ToolStripProgressBar progressBar: SetStatusbarText(text: progressBar.AccessibleDescription); break;
				case ToolStripSeparator toolStripSeparator: SetStatusbarText(text: toolStripSeparator.AccessibleDescription); break;
				case ToolStripTextBox toolStripTextBox: SetStatusbarText(text: toolStripTextBox.AccessibleDescription); break;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion

		private void ButtonElement001_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement002_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement003_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement004_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement005_Click(object sender, EventArgs e)
		{
		}

		private void Button006_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement007_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement008_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement009_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement010_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement011_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement012_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement013_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement014_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement015_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement016_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement017_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement018_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement019_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement020_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement021_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement022_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement023_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement024_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement025_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement026_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement027_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement028_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement029_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement030_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement031_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement032_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement033_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement034_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement035_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement036_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement037_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement038_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement039_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement040_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement041_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement042_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement043_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement044_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement045_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement046_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement047_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement048_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement049_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement050_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement051_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement052_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement053_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement054_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement055_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement056_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement057_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement058_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement059_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement060_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement061_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement062_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement063_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement064_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement065_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement066_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement067_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement068_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement069_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement070_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement071_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement072_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement073_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement074_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement075_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement076_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement077_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement078_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement079_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement080_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement081_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement082_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement083_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement084_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement085_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement086_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement087_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement088_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement089_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement090_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement091_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement092_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement093_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement094_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement095_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement096_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement097_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement098_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement099_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement100_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement101_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement102_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement103_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement104_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement105_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement106_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement107_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement108_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement109_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement110_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement111_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement112_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement113_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement114_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement115_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement116_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement117_Click(object sender, EventArgs e)
		{
		}

		private void ButtonElement118_Click(object sender, EventArgs e)
		{
		}
	}
}
