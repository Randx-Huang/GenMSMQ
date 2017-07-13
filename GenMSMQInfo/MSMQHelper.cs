using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;

namespace GenMSMQInfo
{
    public class FileInfo
    {
        public string Path
        {
            set { path = value; }
            get { return path; }
        }

        public MSMQHelper.FileTypes Type
        {
            set { type = value; }
            get { return type; }
        }

        private string path;
        private MSMQHelper.FileTypes type;

        public FileInfo(string pFilePath, MSMQHelper.FileTypes pFileType)
        {
            this.path = pFilePath;
            this.type = pFileType;
        }
    }

    public class MSMQHelper
    {
        public enum FileTypes { CSV = 0, TXT = 1 };

        public static event EventHandler DealStatusMessage;

        public static List<string> GetLocalMSMQInfo()
        {
            MessageQueue[] vMessageQueueArray = MessageQueue.GetPrivateQueuesByMachine(Environment.MachineName);

            List<String> vMSMQlabelList;
            if (vMessageQueueArray != null && vMessageQueueArray.AsEnumerable().Count() > 0)
            {
                vMSMQlabelList = new List<string>();
                for (int vIndex = 0; vIndex < vMessageQueueArray.Count(); vIndex++)
                {
                    vMSMQlabelList.Add(vMessageQueueArray[vIndex].Label);
                }
                return vMSMQlabelList;
            }
            return null;
        }

        public static bool CreateMSMQ(string pPath)
        {
            bool vResult = false;
            if (!MessageQueue.Exists(pPath))
            {
                MessageQueue vNewMessageQueue = MessageQueue.Create(pPath, false);
                vNewMessageQueue.Label = pPath.Replace(@".\","");
                vNewMessageQueue.SetPermissions("Everyone", MessageQueueAccessRights.FullControl);
                vResult = true;
            }
            else
            {
                UpdStatusMessage("MSMQ已存在");
            }
            return vResult;
        }

        public static bool DeleteMSMQ(string pPath)
        {
            bool vResult = false;
            if (MessageQueue.Exists(pPath))
            {
                MessageQueue.Delete(pPath);
            }
            else
            {
                UpdStatusMessage("MSMQ不存在");
            }
            return vResult;
        }

        internal static void UpdStatusMessage(string pMessage)
        {
            if (DealStatusMessage != null)
            {
                DealStatusMessage(pMessage, null);
            }
        }
    }
}
