using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GenMSMQInfo
{
    public partial class GetLocalMSMQForm : Form
    {
        /// 更新WinForm轉檔狀態
        /// <summary>
        /// 更新WinForm轉檔狀態
        /// </summary>
        /// <param name="pUptMsg">要更新的訊息</param>
        /// <param name="pCtlObj">Control Object</param>
        private delegate void UptWinFromInfoMsgDelegate(string pUptMsg, Control pCtlObj);
        private static string gFilePath = ConfigurationManager.AppSettings["FilePath"].ToString();
        private readonly static string gEmptyErrorMsg = "目前佇列尚未有值，無法匯出";

        public GetLocalMSMQForm()
        {
            InitializeComponent();
            MSMQHelper.DealStatusMessage += MSMQHelper_DealStatusMessage;
            LoadMSMQInformation();
            UpdateStatusMessage("程式啟動成功", null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMSMQInformation();
            UpdateStatusMessage("重新Reload成功", null);
        }

        private void LoadMSMQInformation()
        {
            lBoxMSMQ.DataSource = MSMQHelper.GetLocalMSMQInfo();
        }

        /// 更新Win Form的status 狀態
        /// <summary>
        /// 更新Win Form的status 狀態
        /// </summary>
        /// <param name="pUptMsg">Update的訊息</param>
        /// <param name="pCtlObj">Update的Control</param>
        public void UpdateStatusMessage(string pUptMsg, Control pCtlObj)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UptWinFromInfoMsgDelegate(this.UpdateMessage), pUptMsg, pCtlObj);
            }
            else
            {
                this.UpdateMessage(pUptMsg, pCtlObj);
            }
        }

        /// Delegate呼叫的Update Method
        /// <summary>
        /// Delegate呼叫的Update Method
        /// </summary>
        /// <param name="pUptMsg">Update的訊息</param>
        /// <param name="pCtlObj">Update的Control</param>
        private void UpdateMessage(string pUptMsg, Control pCtlObj)
        {
            if (string.IsNullOrEmpty(pUptMsg))
            {
                this.lbStatusText.Text = "更新訊息是空值請確認你想要顯示的訊息";
            }

            this.lbStatusText.Text = pUptMsg;
        }

        /// 處理WinForm狀態訊息
        /// <summary>
        /// 處理WinForm狀態訊息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSMQHelper_DealStatusMessage(object sender, EventArgs e)
        {
            UpdateStatusMessage((string)sender, null);
        }

        /// 取得目前程式版本
        /// <summary>
        /// 取得目前程式版本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAbout_Click(object sender, EventArgs e)
        {
            Version vVersion = Assembly.GetEntryAssembly().GetName().Version;
            MessageBox.Show(vVersion.ToString());
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuExportCSV_Click(object sender, EventArgs e)
        {
            string vFileName = "msmq.csv";
            string vFileFullPath = string.Format("{0}{1}", gFilePath, vFileName);
            List<string> vMSMQList = MSMQHelper.GetLocalMSMQInfo();

            if (vMSMQList == null || vMSMQList.Count == 0)
            {
                UpdateStatusMessage(gEmptyErrorMsg, null);
                return;
            }

            IWorkbook wb = new HSSFWorkbook();
            ISheet ws = wb.CreateSheet("MSMQ");
            //excel title
            ws.CreateRow(0);
            ws.GetRow(0).CreateCell(0).SetCellValue("MSMQ Name");
            //excel data
            for (int vIndex = 0; vIndex < vMSMQList.Count(); vIndex++)
            {
                ws.CreateRow(vIndex + 1);
                ws.GetRow(vIndex + 1).CreateCell(0).SetCellValue(vMSMQList[vIndex]);//只有一筆資料列
            }

            if (!Directory.Exists(gFilePath))
            {
                Directory.CreateDirectory(gFilePath);
            }

            if (File.Exists(vFileFullPath))
            {
                File.Delete(vFileFullPath);
            }

            using (FileStream file = new FileStream(vFileFullPath, FileMode.CreateNew))
            {
                wb.Write(file);
            }
            UpdateStatusMessage("MSMQ CSV檔已匯出", null);
        }

        private void MenuExportTXT_Click(object sender, EventArgs e)
        {
            string vFileName = "msmq.txt";
            string vFileFullPath = string.Format("{0}{1}", gFilePath, vFileName);
            List<string> vMSMQList = MSMQHelper.GetLocalMSMQInfo();

            if (vMSMQList == null || vMSMQList.Count == 0)
            {
                UpdateStatusMessage(gEmptyErrorMsg, null);
                return;
            }

            if (!Directory.Exists(gFilePath))
            {
                Directory.CreateDirectory(gFilePath);
            }
            if (File.Exists(vFileFullPath))
            {
                File.Delete(vFileFullPath);
            }
            using (StreamWriter sw = new StreamWriter(vFileFullPath, false, Encoding.UTF8))
            {
                for (int vIndex = 0; vIndex < vMSMQList.Count(); vIndex++)
                {
                    sw.WriteLine(vMSMQList[vIndex]);
                }
            }
            UpdateStatusMessage("MSMQ TXT檔已匯出", null);
        }

        private void MenuImportCSV_Click(object sender, System.EventArgs e)
        {
            ImportFile(MSMQHelper.FileTypes.CSV);
        }

        private void MenuImportTXT_Click(object sender, EventArgs e)
        {
            ImportFile(MSMQHelper.FileTypes.TXT);
        }

        internal void ImportFile(MSMQHelper.FileTypes ptype)
        {
            DialogResult vResult = FileDialog.ShowDialog();
            if (vResult == DialogResult.OK)
            {
                ImportFileForm vImportFileForm = new ImportFileForm(FileDialog.FileName, ptype);
                vImportFileForm.FormClosed += new FormClosedEventHandler(vImportFileForm_FormClosed);
                vImportFileForm.TopLevel = true;
                vImportFileForm.ShowDialog();
            }
        }

        private void vImportFileForm_FormClosed(object sender, EventArgs e)
        {
            LoadMSMQInformation();
        }
    }
}
