namespace GenMSMQInfo
{
    partial class ImportFileForm
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
            this.lBoxLocalMSMQ = new System.Windows.Forms.ListBox();
            this.lbMSMQLocal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxImportFileMSMQ = new System.Windows.Forms.ListBox();
            this.btnSelectSingle = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelOne = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxLocalMSMQ
            // 
            this.lBoxLocalMSMQ.FormattingEnabled = true;
            this.lBoxLocalMSMQ.ItemHeight = 12;
            this.lBoxLocalMSMQ.Location = new System.Drawing.Point(177, 29);
            this.lBoxLocalMSMQ.Name = "lBoxLocalMSMQ";
            this.lBoxLocalMSMQ.Size = new System.Drawing.Size(120, 172);
            this.lBoxLocalMSMQ.TabIndex = 0;
            // 
            // lbMSMQLocal
            // 
            this.lbMSMQLocal.AutoSize = true;
            this.lbMSMQLocal.Location = new System.Drawing.Point(175, 14);
            this.lbMSMQLocal.Name = "lbMSMQLocal";
            this.lbMSMQLocal.Size = new System.Drawing.Size(113, 12);
            this.lbMSMQLocal.TabIndex = 2;
            this.lbMSMQLocal.Text = "目前Local端的MSMQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "檔案中的MSMQ";
            // 
            // lBoxImportFileMSMQ
            // 
            this.lBoxImportFileMSMQ.FormattingEnabled = true;
            this.lBoxImportFileMSMQ.ItemHeight = 12;
            this.lBoxImportFileMSMQ.Location = new System.Drawing.Point(16, 29);
            this.lBoxImportFileMSMQ.Name = "lBoxImportFileMSMQ";
            this.lBoxImportFileMSMQ.Size = new System.Drawing.Size(120, 172);
            this.lBoxImportFileMSMQ.TabIndex = 5;
            // 
            // btnSelectSingle
            // 
            this.btnSelectSingle.Location = new System.Drawing.Point(143, 44);
            this.btnSelectSingle.Name = "btnSelectSingle";
            this.btnSelectSingle.Size = new System.Drawing.Size(28, 23);
            this.btnSelectSingle.TabIndex = 7;
            this.btnSelectSingle.Text = ">";
            this.btnSelectSingle.UseVisualStyleBackColor = true;
            this.btnSelectSingle.Click += new System.EventHandler(this.btnSingleOne_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(142, 73);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(29, 23);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = ">>";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(312, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(65, 208);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "建立";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelOne
            // 
            this.btnCancelOne.Location = new System.Drawing.Point(143, 102);
            this.btnCancelOne.Name = "btnCancelOne";
            this.btnCancelOne.Size = new System.Drawing.Size(28, 23);
            this.btnCancelOne.TabIndex = 12;
            this.btnCancelOne.Text = "<";
            this.btnCancelOne.UseVisualStyleBackColor = true;
            this.btnCancelOne.Click += new System.EventHandler(this.btnCancelOne_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(143, 132);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(28, 23);
            this.btnCancelAll.TabIndex = 13;
            this.btnCancelAll.Text = "<<";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // ImportFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 265);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnCancelOne);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnSelectSingle);
            this.Controls.Add(this.lBoxImportFileMSMQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMSMQLocal);
            this.Controls.Add(this.lBoxLocalMSMQ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportFileForm";
            this.Text = "匯入MSMQ";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxLocalMSMQ;
        private System.Windows.Forms.Label lbMSMQLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxImportFileMSMQ;
        private System.Windows.Forms.Button btnSelectSingle;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelOne;
        private System.Windows.Forms.Button btnCancelAll;

    }
}