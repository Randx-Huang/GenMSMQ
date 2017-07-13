using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GenMSMQInfo
{
    public partial class ImportFileForm : Form
    {
        private static EventHandler UpdStatusMessage;
        private static List<string> gOriMSMQValueList;
        private delegate void RefreshListBoxDelegate(List<string> pListValue, Control pControl);

        public ImportFileForm(string pFilePath, MSMQHelper.FileTypes pFileType)
        {
            InitializeComponent();
            gOriMSMQValueList = MSMQHelper.GetLocalMSMQInfo();
            if (gOriMSMQValueList != null)
            {
                lBoxLocalMSMQ.DataSource = gOriMSMQValueList.Select(item => (string)item.Clone()).ToList<string>();
            }
            this.lbStatus.Text = "匯入畫面啟動成功";
            Thread vThread = new Thread(new ParameterizedThreadStart(this.ReadFile));
            vThread.IsBackground = true;
            vThread.Start(new FileInfo(pFilePath, pFileType));
        }

        #region 讀檔
        /// 讀檔
        /// <summary>
        /// 讀檔
        /// </summary>
        /// <param name="obj">FileInfo物件</param>
        private void ReadFile(object obj)
        {
            FileInfo vfile = (FileInfo)obj;

            switch (vfile.Type)
            {
                case MSMQHelper.FileTypes.CSV:
                    ReadCSVFile(vfile.Path);
                    break;
                case MSMQHelper.FileTypes.TXT:
                    ReadTXTFile(vfile.Path);
                    break;
                default:
                    break;
            }
        }

        /// 讀取TXT檔案並更新ListBoxFileMSMQ
        /// <summary>
        /// 讀取TXT檔案並更新ListBoxFileMSMQ
        /// </summary>
        /// <param name="pFilePath"></param>
        private void ReadTXTFile(string pFilePath)
        {
            List<string> NewMSMQList = new List<string>();
            using (StreamReader vReader = new StreamReader(pFilePath, true))
            {
                string vRecord;
                while ((vRecord = vReader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(vRecord))
                    {
                        NewMSMQList.Add(vRecord);
                    }
                }
            }
            ReLoadListBoxValue(NewMSMQList, lBoxImportFileMSMQ);
        }

        /// 讀取CSV並更新ListBoxFileMSMQ
        /// <summary>
        /// 讀取CSV並更新ListBoxFileMSMQ
        /// </summary>
        /// <param name="pFilePath"></param>
        private void ReadCSVFile(string pFilePath)
        {
            List<string> NewMSMQList = new List<string>();
            using (StreamReader vReader = new StreamReader(pFilePath, true))
            {
                string vRecord;
                while ((vRecord = vReader.ReadLine()) != null)
                {
                    string[] vDatas = vRecord.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (!string.IsNullOrEmpty(vDatas[0]))
                    {
                        NewMSMQList.Add(vDatas[0]);
                    }
                }
            }
            ReLoadListBoxValue(NewMSMQList, lBoxImportFileMSMQ);
        }
        #endregion

        #region 複製檔案
        /// 選取一個item並複製到另外一個listBox
        /// <summary>
        /// 選取一個item並複製到另外一個listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingleOne_Click(object sender, EventArgs e)
        {
            InsertItemToListBox("S");
        }

        /// 選擇全部的MSMQ到Local的ListBox內
        /// <summary>
        /// 選擇全部的MSMQ到Local的ListBox內
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            InsertItemToListBox("A");
        }

        /// 新增所選MSMQ到LocalListBox todo 如果可以希望重構的好一點
        /// <summary>
        /// 新增所選MSMQ到LocalListBox todo 如果可以希望重構的好一點
        /// </summary>
        /// <param name="pInsertType"></param>
        private void InsertItemToListBox(string pInsertType)
        {
            List<string> vNewMSMQValueList = (List<string>)lBoxLocalMSMQ.DataSource;
            this.lbStatus.Text = "";
            if (vNewMSMQValueList != null && vNewMSMQValueList.Count() > 0)
            {
                switch (pInsertType)
                {
                    case "A":
                        foreach (string vNewMSMQValue in lBoxImportFileMSMQ.Items)
                        {
                            if (!vNewMSMQValueList.Contains(vNewMSMQValue))
                            {
                                vNewMSMQValueList.Add(vNewMSMQValue);
                            }
                        }
                        break;
                    case "S":
                        string vSelectedItem = (string)lBoxImportFileMSMQ.SelectedItem;
                        if (!string.IsNullOrEmpty(vSelectedItem))
                        {
                            if (!vNewMSMQValueList.Contains(vSelectedItem))
                            {
                                vNewMSMQValueList.Add(vSelectedItem);

                            }
                            else
                            {
                                this.lbStatus.Text = "目前Local端已有此佇列";
                            }
                        }
                        break;
                }
            }
            else
            {
                string[] vTmpValue = null;
                switch (pInsertType)
                {
                    case "A":
                        vTmpValue = new string[lBoxImportFileMSMQ.Items.Count];
                        lBoxImportFileMSMQ.Items.CopyTo(vTmpValue, 0);
                        vNewMSMQValueList = vTmpValue.ToList<string>();
                        break;
                    case "S":
                        vTmpValue = new string[] { lBoxImportFileMSMQ.SelectedItem.ToString() };
                        vNewMSMQValueList = vTmpValue.ToList<string>();
                        break;
                    default:
                        break;
                }
            }
            ReLoadListBoxValue(vNewMSMQValueList, this.lBoxLocalMSMQ);
        }
        /// 刪除單一listBox item
        /// <summary>
        /// 刪除單一listBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelOne_Click(object sender, EventArgs e)
        {
            List<string> vLocalMSMQList = (List<string>)lBoxLocalMSMQ.DataSource;
            string vSelectedItem = (string)lBoxLocalMSMQ.SelectedItem;
            if (vLocalMSMQList.Contains(vSelectedItem))
            {
                vLocalMSMQList.Remove(vSelectedItem);
                ReLoadListBoxValue(vLocalMSMQList, this.lBoxLocalMSMQ);
            }
        }

        /// 刪除全部listBox item
        /// <summary>
        /// 刪除全部listBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            ReLoadListBoxValue(null, this.lBoxLocalMSMQ);
        }

        #endregion

        /// 關閉這個winFrom
        /// <summary>
        /// 關閉這個winFrom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region 更新ListBox
        /// 更新ListBox中的item值
        /// <summary>
        /// 更新ListBox中的item值
        /// </summary>
        /// <param name="pMSMQValueList">欲更新的list</param>
        /// <param name="pControl">欲更新的control</param>
        internal void ReLoadListBoxValue(List<string> pMSMQValueList, Control pControl)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new RefreshListBoxDelegate(this.LoadListBoxValue), pMSMQValueList, pControl);
            }
            else
            {
                this.LoadListBoxValue(pMSMQValueList, pControl);
            }
        }

        internal void LoadListBoxValue(List<string> pMSMQValueList, Control pControl)
        {
            ListBox vListBox = (ListBox)pControl;
            if (pMSMQValueList != null && pMSMQValueList.Count > 0)
            {
                vListBox.DataSource = null;
                vListBox.DataSource = pMSMQValueList;
            }
            else
            {
                vListBox.DataSource = null;
            }
        }
        #endregion

        /// 根據lBoxLocalMSMQ的值來建立MSMQ
        /// <summary>
        /// 根據lBoxLocalMSMQ的值來建立MSMQ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (lBoxLocalMSMQ == null && lBoxLocalMSMQ.Items.Count == 0)
            {
                this.lbStatus.Text = "預建立之MSMQ為空值,請至少建立一筆";
                return;
            }
            //先將原本local端的MSMQ刪除
            if (gOriMSMQValueList != null && gOriMSMQValueList.Count > 0)
            {
                foreach (string vPath in gOriMSMQValueList)
                {
                    MSMQHelper.DeleteMSMQ(string.Format(@".\{0}", vPath));
                }
            }
            //根據目前lBoxLocalListBox的MSMQ建立

            foreach (string vPath in lBoxLocalMSMQ.Items)
            {
                try
                {
                    MSMQHelper.CreateMSMQ(string.Format(@".\{0}", vPath));
                }
                catch (ArgumentException exAr)
                {
                    this.lbStatus.Text = string.Format("{0}的值為null或空", vPath);
                }
                catch (Exception ex)
                {
                    this.lbStatus.Text = ex.Message;
                }
            }
            this.lbStatus.Text = "已建立完畢";
            this.Dispose();
        }
    }
}
