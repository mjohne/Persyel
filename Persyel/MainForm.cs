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
				case Button button: SetStatusbarText(text: button.Tag.ToString()); break;
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
	}
}
