using System;
using System.IO;
using System.Text;
namespace SimpleApplication_ForRefactoring.Services.Loggers
{
    public class FileLoggerService : BaseLoggerService
    {
        private string _filePath { get; set; }

        public void SetLogger(string filePath, string message)
        {
            this._filePath = filePath;
            this.Log(message);
        }

        protected override void Log(string message)
        {
            var sb = new StringBuilder();
            sb.Append(message);

            File.AppendAllText(_filePath + "log.txt", sb.ToString());
            sb.Clear(); throw new NotImplementedException();
        }
    }
}