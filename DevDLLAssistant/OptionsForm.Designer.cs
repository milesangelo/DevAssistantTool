
namespace DevAssistant.UI
{
	partial class OptionsForm
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
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.lbl_fileSystemWatchPath = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btn_selectFileSystemWatchPath = new System.Windows.Forms.Button();
			this.tb_selectedFileSystemWatchPath = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(308, 423);
			this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(52, 20);
			this.btn_Cancel.TabIndex = 0;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_Save.Location = new System.Drawing.Point(364, 423);
			this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(56, 20);
			this.btn_Save.TabIndex = 1;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// lbl_fileSystemWatchPath
			// 
			this.lbl_fileSystemWatchPath.AutoSize = true;
			this.lbl_fileSystemWatchPath.Location = new System.Drawing.Point(19, 53);
			this.lbl_fileSystemWatchPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_fileSystemWatchPath.Name = "lbl_fileSystemWatchPath";
			this.lbl_fileSystemWatchPath.Size = new System.Drawing.Size(106, 13);
			this.lbl_fileSystemWatchPath.TabIndex = 2;
			this.lbl_fileSystemWatchPath.Text = "Repo Root Location:";
			// 
			// btn_selectFileSystemWatchPath
			// 
			this.btn_selectFileSystemWatchPath.Location = new System.Drawing.Point(390, 48);
			this.btn_selectFileSystemWatchPath.Name = "btn_selectFileSystemWatchPath";
			this.btn_selectFileSystemWatchPath.Size = new System.Drawing.Size(24, 23);
			this.btn_selectFileSystemWatchPath.TabIndex = 3;
			this.btn_selectFileSystemWatchPath.Text = "...";
			this.btn_selectFileSystemWatchPath.UseVisualStyleBackColor = true;
			this.btn_selectFileSystemWatchPath.Click += new System.EventHandler(this.btn_selectFileSystemWatchPath_Click);
			// 
			// tb_selectedFileSystemWatchPath
			// 
			this.tb_selectedFileSystemWatchPath.Location = new System.Drawing.Point(130, 50);
			this.tb_selectedFileSystemWatchPath.Name = "tb_selectedFileSystemWatchPath";
			this.tb_selectedFileSystemWatchPath.ReadOnly = true;
			this.tb_selectedFileSystemWatchPath.Size = new System.Drawing.Size(254, 20);
			this.tb_selectedFileSystemWatchPath.TabIndex = 4;
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 449);
			this.Controls.Add(this.tb_selectedFileSystemWatchPath);
			this.Controls.Add(this.btn_selectFileSystemWatchPath);
			this.Controls.Add(this.lbl_fileSystemWatchPath);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Cancel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "OptionsForm";
			this.Text = "Options";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Label lbl_fileSystemWatchPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btn_selectFileSystemWatchPath;
		private System.Windows.Forms.TextBox tb_selectedFileSystemWatchPath;
	}
}