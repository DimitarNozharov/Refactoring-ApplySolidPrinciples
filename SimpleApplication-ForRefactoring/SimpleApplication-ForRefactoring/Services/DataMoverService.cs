using SimpleApplication_ForRefactoring.Interfaces;
using System.IO;
using System.Net;
using System.Text;
namespace SimpleApplication_ForRefactoring
{
    public class DataMoverService : IDataGetter, IDataSender, IDataSetter
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
    }
}
