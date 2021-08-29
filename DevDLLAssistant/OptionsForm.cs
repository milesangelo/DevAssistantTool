using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevAssistant.Logic.Models;

namespace DevAssistant.UI
{
	public partial class OptionsForm : Form
	{
		private Configuration configuration = new Configuration();
		
		public Configuration Configuration => configuration;

		public OptionsForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shows folder selection window and updates file system watcher path in configuration
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_selectFileSystemWatchPath_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1 = new FolderBrowserDialog();
			folderBrowserDialog1.ShowDialog(this);
			if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
			{
				configuration.FileSystemWatchPath = string.Format("{0}", folderBrowserDialog1.SelectedPath.Trim());
			}
		}
	}
}
