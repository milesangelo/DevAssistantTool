
namespace DevDLLAssistant
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.lb_availableFiles = new System.Windows.Forms.ListBox();
            this.lb_selectedFiles = new System.Windows.Forms.ListBox();
            this.btn_markAsAvailable = new System.Windows.Forms.Button();
            this.btn_markAsSelected = new System.Windows.Forms.Button();
            this.btn_copySelectedFiles = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_availableFiles = new System.Windows.Forms.Label();
            this.lbl_selectedFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_availableFiles
            // 
            this.lb_availableFiles.FormattingEnabled = true;
            this.lb_availableFiles.Location = new System.Drawing.Point(12, 31);
            this.lb_availableFiles.MultiColumn = true;
            this.lb_availableFiles.Name = "lb_availableFiles";
            this.lb_availableFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_availableFiles.Size = new System.Drawing.Size(302, 329);
            this.lb_availableFiles.TabIndex = 0;
            // 
            // lb_selectedFiles
            // 
            this.lb_selectedFiles.FormattingEnabled = true;
            this.lb_selectedFiles.Location = new System.Drawing.Point(401, 31);
            this.lb_selectedFiles.MultiColumn = true;
            this.lb_selectedFiles.Name = "lb_selectedFiles";
            this.lb_selectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_selectedFiles.Size = new System.Drawing.Size(273, 329);
            this.lb_selectedFiles.TabIndex = 1;
            // 
            // btn_markAsAvailable
            // 
            this.btn_markAsAvailable.Location = new System.Drawing.Point(320, 60);
            this.btn_markAsAvailable.Name = "btn_markAsAvailable";
            this.btn_markAsAvailable.Size = new System.Drawing.Size(75, 23);
            this.btn_markAsAvailable.TabIndex = 2;
            this.btn_markAsAvailable.Text = "<<";
            this.btn_markAsAvailable.UseVisualStyleBackColor = true;
            // 
            // btn_markAsSelected
            // 
            this.btn_markAsSelected.Location = new System.Drawing.Point(320, 31);
            this.btn_markAsSelected.Name = "btn_markAsSelected";
            this.btn_markAsSelected.Size = new System.Drawing.Size(75, 23);
            this.btn_markAsSelected.TabIndex = 3;
            this.btn_markAsSelected.Text = ">>";
            this.btn_markAsSelected.UseVisualStyleBackColor = true;
            // 
            // btn_copySelectedFiles
            // 
            this.btn_copySelectedFiles.Location = new System.Drawing.Point(599, 366);
            this.btn_copySelectedFiles.Name = "btn_copySelectedFiles";
            this.btn_copySelectedFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_copySelectedFiles.TabIndex = 4;
            this.btn_copySelectedFiles.Text = "Copy";
            this.btn_copySelectedFiles.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(320, 117);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // lbl_availableFiles
            // 
            this.lbl_availableFiles.AutoSize = true;
            this.lbl_availableFiles.Location = new System.Drawing.Point(9, 15);
            this.lbl_availableFiles.Name = "lbl_availableFiles";
            this.lbl_availableFiles.Size = new System.Drawing.Size(146, 13);
            this.lbl_availableFiles.TabIndex = 6;
            this.lbl_availableFiles.Text = "Recently Built Available DLLs";
            // 
            // lbl_selectedFiles
            // 
            this.lbl_selectedFiles.AutoSize = true;
            this.lbl_selectedFiles.Location = new System.Drawing.Point(398, 15);
            this.lbl_selectedFiles.Name = "lbl_selectedFiles";
            this.lbl_selectedFiles.Size = new System.Drawing.Size(136, 13);
            this.lbl_selectedFiles.TabIndex = 7;
            this.lbl_selectedFiles.Text = "DLLs to Automatically Copy";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 398);
            this.Controls.Add(this.lbl_selectedFiles);
            this.Controls.Add(this.lbl_availableFiles);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_copySelectedFiles);
            this.Controls.Add(this.btn_markAsSelected);
            this.Controls.Add(this.btn_markAsAvailable);
            this.Controls.Add(this.lb_selectedFiles);
            this.Controls.Add(this.lb_availableFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "MC - Dev DLL Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_availableFiles;
        private System.Windows.Forms.ListBox lb_selectedFiles;
        private System.Windows.Forms.Button btn_markAsAvailable;
        private System.Windows.Forms.Button btn_markAsSelected;
        private System.Windows.Forms.Button btn_copySelectedFiles;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_availableFiles;
        private System.Windows.Forms.Label lbl_selectedFiles;
    }
}

