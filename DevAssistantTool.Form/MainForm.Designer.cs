
namespace DevAssistant.UI
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lb_selectedFiles = new System.Windows.Forms.ListBox();
			this.btn_markAsAvailable = new System.Windows.Forms.Button();
			this.btn_markAsSelected = new System.Windows.Forms.Button();
			this.btn_copySelectedFiles = new System.Windows.Forms.Button();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.lbl_availableFiles = new System.Windows.Forms.Label();
			this.lbl_selectedFiles = new System.Windows.Forms.Label();
			this.dgv_availableDLLs = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.fileSystemWatcher = new System.IO.FileSystemWatcher();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gb_managesServices = new System.Windows.Forms.GroupBox();
			this.cb_selectSync = new System.Windows.Forms.CheckBox();
			this.btn_restartServices = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_availableDLLs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.gb_managesServices.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_selectedFiles
			// 
			this.lb_selectedFiles.FormattingEnabled = true;
			this.lb_selectedFiles.Location = new System.Drawing.Point(442, 84);
			this.lb_selectedFiles.MultiColumn = true;
			this.lb_selectedFiles.Name = "lb_selectedFiles";
			this.lb_selectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lb_selectedFiles.Size = new System.Drawing.Size(323, 355);
			this.lb_selectedFiles.TabIndex = 1;
			// 
			// btn_markAsAvailable
			// 
			this.btn_markAsAvailable.Location = new System.Drawing.Point(362, 113);
			this.btn_markAsAvailable.Name = "btn_markAsAvailable";
			this.btn_markAsAvailable.Size = new System.Drawing.Size(75, 23);
			this.btn_markAsAvailable.TabIndex = 2;
			this.btn_markAsAvailable.Text = "<<";
			this.btn_markAsAvailable.UseVisualStyleBackColor = true;
			this.btn_markAsAvailable.Click += new System.EventHandler(this.btn_markAsAvailable_Click);
			// 
			// btn_markAsSelected
			// 
			this.btn_markAsSelected.Location = new System.Drawing.Point(362, 84);
			this.btn_markAsSelected.Name = "btn_markAsSelected";
			this.btn_markAsSelected.Size = new System.Drawing.Size(75, 23);
			this.btn_markAsSelected.TabIndex = 3;
			this.btn_markAsSelected.Text = ">>";
			this.btn_markAsSelected.UseVisualStyleBackColor = true;
			// 
			// btn_copySelectedFiles
			// 
			this.btn_copySelectedFiles.Location = new System.Drawing.Point(689, 444);
			this.btn_copySelectedFiles.Name = "btn_copySelectedFiles";
			this.btn_copySelectedFiles.Size = new System.Drawing.Size(75, 23);
			this.btn_copySelectedFiles.TabIndex = 4;
			this.btn_copySelectedFiles.Text = "Copy";
			this.btn_copySelectedFiles.UseVisualStyleBackColor = true;
			// 
			// btn_refresh
			// 
			this.btn_refresh.Location = new System.Drawing.Point(362, 208);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(75, 23);
			this.btn_refresh.TabIndex = 5;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = true;
			this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
			// 
			// lbl_availableFiles
			// 
			this.lbl_availableFiles.AutoSize = true;
			this.lbl_availableFiles.Location = new System.Drawing.Point(9, 68);
			this.lbl_availableFiles.Name = "lbl_availableFiles";
			this.lbl_availableFiles.Size = new System.Drawing.Size(146, 13);
			this.lbl_availableFiles.TabIndex = 6;
			this.lbl_availableFiles.Text = "Recently Built Available DLLs";
			// 
			// lbl_selectedFiles
			// 
			this.lbl_selectedFiles.AutoSize = true;
			this.lbl_selectedFiles.Location = new System.Drawing.Point(440, 68);
			this.lbl_selectedFiles.Name = "lbl_selectedFiles";
			this.lbl_selectedFiles.Size = new System.Drawing.Size(136, 13);
			this.lbl_selectedFiles.TabIndex = 7;
			this.lbl_selectedFiles.Text = "DLLs to Automatically Copy";
			// 
			// dgv_availableDLLs
			// 
			this.dgv_availableDLLs.AllowUserToAddRows = false;
			this.dgv_availableDLLs.AllowUserToDeleteRows = false;
			this.dgv_availableDLLs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_availableDLLs.Location = new System.Drawing.Point(12, 84);
			this.dgv_availableDLLs.Name = "dgv_availableDLLs";
			this.dgv_availableDLLs.ReadOnly = true;
			this.dgv_availableDLLs.RowHeadersWidth = 82;
			this.dgv_availableDLLs.Size = new System.Drawing.Size(344, 355);
			this.dgv_availableDLLs.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(362, 317);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// fileSystemWatcher
			// 
			this.fileSystemWatcher.EnableRaisingEvents = true;
			this.fileSystemWatcher.SynchronizingObject = this;
			this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
			this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
			this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
			this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.configurationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 22);
			this.toolStripMenuItem1.Text = "Assistant";
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
			this.configurationToolStripMenuItem.Text = "Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// gb_managesServices
			// 
			this.gb_managesServices.Controls.Add(this.cb_selectSync);
			this.gb_managesServices.Controls.Add(this.btn_restartServices);
			this.gb_managesServices.Location = new System.Drawing.Point(801, 47);
			this.gb_managesServices.Name = "gb_managesServices";
			this.gb_managesServices.Size = new System.Drawing.Size(301, 383);
			this.gb_managesServices.TabIndex = 12;
			this.gb_managesServices.TabStop = false;
			this.gb_managesServices.Text = "Manage Services";
			// 
			// cb_selectSync
			// 
			this.cb_selectSync.AutoSize = true;
			this.cb_selectSync.Location = new System.Drawing.Point(152, 37);
			this.cb_selectSync.Name = "cb_selectSync";
			this.cb_selectSync.Size = new System.Drawing.Size(50, 17);
			this.cb_selectSync.TabIndex = 11;
			this.cb_selectSync.Tag = "sync";
			this.cb_selectSync.Text = "Sync";
			this.cb_selectSync.UseVisualStyleBackColor = true;
			// 
			// btn_restartServices
			// 
			this.btn_restartServices.Location = new System.Drawing.Point(16, 37);
			this.btn_restartServices.Name = "btn_restartServices";
			this.btn_restartServices.Size = new System.Drawing.Size(75, 23);
			this.btn_restartServices.TabIndex = 10;
			this.btn_restartServices.Text = "Restart";
			this.btn_restartServices.UseVisualStyleBackColor = true;
			this.btn_restartServices.Click += new System.EventHandler(this.RestartServicesButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 479);
			this.Controls.Add(this.gb_managesServices);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dgv_availableDLLs);
			this.Controls.Add(this.lbl_selectedFiles);
			this.Controls.Add(this.lbl_availableFiles);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.btn_copySelectedFiles);
			this.Controls.Add(this.btn_markAsSelected);
			this.Controls.Add(this.btn_markAsAvailable);
			this.Controls.Add(this.lb_selectedFiles);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MC - Dev DLL Assistant";
			this.Load += new System.EventHandler(this.mainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_availableDLLs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gb_managesServices.ResumeLayout(false);
			this.gb_managesServices.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_selectedFiles;
        private System.Windows.Forms.Button btn_markAsAvailable;
        private System.Windows.Forms.Button btn_markAsSelected;
        private System.Windows.Forms.Button btn_copySelectedFiles;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_availableFiles;
        private System.Windows.Forms.Label lbl_selectedFiles;
        private System.Windows.Forms.DataGridView dgv_availableDLLs;
		private System.Windows.Forms.Button button2;
		private System.IO.FileSystemWatcher fileSystemWatcher;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.GroupBox gb_managesServices;
		private System.Windows.Forms.Button btn_restartServices;
		private System.Windows.Forms.CheckBox cb_selectSync;
	}
}

