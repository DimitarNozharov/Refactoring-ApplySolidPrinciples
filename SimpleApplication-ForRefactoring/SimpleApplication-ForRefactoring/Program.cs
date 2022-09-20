using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApplication_ForRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataMover = new DataMover();

            dataMover._data = Encoding.UTF8.GetBytes("test");
            dataMover.SendData("192.168.0.1");

            dataMover.GetData("../../TextFile.txt");

            dataMover.LogData(LogTypes.Console, string.Empty, "test");
            Console.ReadKey();
        }
    }
}
