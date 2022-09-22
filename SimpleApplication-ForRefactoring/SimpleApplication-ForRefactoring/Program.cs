using SimpleApplication_ForRefactoring.Services.Loggers;
using System;
using System.Text;
namespace SimpleApplication_ForRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataMoverService = new DataMoverService();

            var consoleLoggerService = new ConsoleLoggerService();

            dataMoverService.SetData(Encoding.UTF8, "test");
            dataMoverService.SendData("192.168.0.1");
            dataMoverService.GetData("../../TextFile.txt");

            consoleLoggerService.SetLogger("test");

            Console.ReadKey();
        }
    }
}
