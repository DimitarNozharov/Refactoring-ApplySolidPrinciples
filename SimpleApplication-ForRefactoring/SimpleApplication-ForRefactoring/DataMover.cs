using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApplication_ForRefactoring
{
    public class DataMover
    {
        private byte[] _data;

        public byte[] GetData(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                return ms.ToArray();
            }
        }


        public void SetData(Encoding encoding, string data)
        {
            _data = encoding.GetBytes(data);
        }

        public void SendData(string ipAddress)
        {
            using (WebClient wc = new WebClient())
            {
                wc.UploadData(ipAddress, _data);
            }
        }

        public void LogData(LogTypes loggingType, string filePath, string message)
        {
            if(loggingType == LogTypes.File)
            {
                var sb = new StringBuilder();
                sb.Append(message);

                File.AppendAllText(filePath + "log.txt", sb.ToString());
                sb.Clear();
            }
            else
            {
                throw new NotImplementedException();
            }
           
        }
    }
}
