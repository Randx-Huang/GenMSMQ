namespace GenMSMQInfo
{
    partial class GetLocalMSMQForm
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
            this.lBoxMSMQ = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImportTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxMSMQ
            // 
            this.lBoxMSMQ.FormattingEnabled = true;
            this.lBoxMSMQ.ItemHeight = 12;
            this.lBoxMSMQ.Location = new System.Drawing.Point(14, 43);
            this.lBoxMSMQ.Name = "lBoxMSMQ";
            this.lBoxMSMQ.Size = new System.Drawing.Size(228, 160);
            this.lBoxMSMQ.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(255, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatusText
            // 
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(255, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExport,
            this.MenuImport,
            this.MenuExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(44, 20);
            this.MenuFile.Text = "檔案";
            // 
            // MenuExport
            // 
            this.MenuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportCSV,
            this.MenuExportTXT});
            this.MenuExport.Name = "MenuExport";
            this.MenuExport.Size = new System.Drawing.Size(100, 22);
            this.MenuExport.Text = "匯出";
            // 
            // MenuExportCSV
            // 
            this.MenuExportCSV.Name = "MenuExportCSV";
            this.MenuExportCSV.Size = new System.Drawing.Size(99, 22);
            this.MenuExportCSV.Text = "CSV";
            this.MenuExportCSV.Click += new System.EventHandler(this.MenuExportCSV_Click);
            // 
            // MenuExportTXT
            // 
            this.MenuExportTXT.Name = "MenuExportTXT";
            this.MenuExportTXT.Size = new System.Drawing.Size(99, 22);
            this.MenuExportTXT.Text = "TXT";
            this.MenuExportTXT.Click += new System.EventHandler(this.MenuExportTXT_Click);
            // 
            // MenuImport
            // 
            this.MenuImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImportCSV,
            this.MenuImportTXT});
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(100, 22);
            this.MenuImport.Text = "匯入";
            // 
            // MenuImportCSV
            // 
            this.MenuImportCSV.Name = "MenuImportCSV";
            this.MenuImportCSV.Size = new System.Drawing.Size(99, 22);
            this.MenuImportCSV.Text = "CSV";
            this.MenuImportCSV.Click += new System.EventHandler(this.MenuImportCSV_Click);
            // 
            // MenuImportTXT
            // 
            this.MenuImportTXT.Name = "MenuImportTXT";
            this.MenuImportTXT.Size = new System.Drawing.Size(99, 22);
            this.MenuImportTXT.Text = "TXT";
            this.MenuImportTXT.Click += new System.EventHandler(this.MenuImportTXT_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(100, 22);
            this.MenuExit.Text = "結束";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "幫助";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(100, 22);
            this.MenuAbout.Text = "關於";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "目前在本機的MSMQ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "重新查詢LocalMSMQ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetLocalMSMQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lBoxMSMQ);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GetLocalMSMQForm";
            this.Text = "GetLocalMSMQForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ListBox lBoxMSMQ;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuExport;
        private System.Windows.Forms.ToolStripMenuItem MenuExportCSV;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTXT;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuImport;
        private System.Windows.Forms.ToolStripMenuItem MenuImportCSV;
        private System.Windows.Forms.ToolStripMenuItem MenuImportTXT;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

