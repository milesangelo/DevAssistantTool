using DevAssistant.Logic.Services;
using System;
using System.Data;
using System.ServiceProcess;
using System.Windows.Forms;

namespace DevAssistant.UI
{
    public partial class MainForm : Form
    {
        //DLLFinder dllFinder;
        DataTable table;

        
        public MainForm()
        {
            InitializeComponent();

           // dllFinder = new DLLFinder();

            table = new DataTable();
            table.Columns.Add("DLL", typeof(string));
            table.Columns.Add("Path", typeof(string));
            table.Columns.Add("Last Modified", typeof(string));
            this.dgv_availableDLLs.DataSource = table;


            //_devAssistService = new DevAssistantService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This will refresh the list of available DLL's 
        /// that the user can select to copy into their respective location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
            //var availableDlls = dllFinder.GetRecentlyModified();
            //var dlls = new List<DLLInfo>();
            //dlls.Add(new DLLInfo()
            //{
            //    Name = "test1",
            //    LastModified = "10/10/2021",
            //    Path = "C: mc 1.1.1"
            //});

            var dataTable = dgv_availableDLLs.DataSource as DataTable;
            dataTable.Clear();
            
            
            //var dataTable = dataSource.DataSource as DataTable;
            
            dataTable.Rows.Add("test1", "10/10/2021", "C: mc 1.1.1");
           
            //availableDlls.ForEach(dll => lb_availableFiles.Items.Add(dll));
            //lb_availableFiles.EndUpdate();
        }

        /// <summary>
        /// TODO, I believe this button and click event can be removed.  The functionality should have been implemented in the Logic project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
            ServiceController serviceController;
            TimeSpan timeout = TimeSpan.FromMilliseconds(7500);

            try
            {
                serviceController = new ServiceController("IISADMIN");

                if (serviceController.Status != ServiceControllerStatus.Running)
                {
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                
                serviceController = new ServiceController("W3SVC");
                if (serviceController.Status != ServiceControllerStatus.Running)
                {
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// TODO, looks like functionality to stop the IISADMIN service?  Pretty sure I can remove it.
        /// 
        /// Remove this if functionality lives inside Logic project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
            ServiceController serviceController = new ServiceController("IISADMIN");
            TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
            serviceController.Stop();
            serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            var status = serviceController.Status;
        }

        /// <summary>
        /// Open the Options form on click and save any data passed into it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
            if (optionsForm.DialogResult == DialogResult.OK)
            {
                fileSystemWatcher.Path = optionsForm.Configuration.FileSystemWatchPath;
                fileSystemWatcher.IncludeSubdirectories = true;   
            }

            optionsForm.Dispose();
		}

		private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
		{
            Console.WriteLine("Path: " + e.FullPath + " Type: " + e.ChangeType + " Name: " + e.Name);
		}

		private void fileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
		{

		}

		private void fileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
		{

		}

		private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
		{

		}

		private void btn_markAsAvailable_Click(object sender, EventArgs e)
		{
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btn_restartServices_Click(object sender, EventArgs e)
		{
            //DevAssistantService service = new DevAssistantService();
            //service.Restart();
        }
	}

	public class DLLInfo
    { 
        public string Name { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
    }
}
