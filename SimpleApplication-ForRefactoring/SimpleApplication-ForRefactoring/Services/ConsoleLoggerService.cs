using System;
namespace SimpleApplication_ForRefactoring.Services.Loggers
{
    public class ConsoleLoggerService : BaseLoggerService
    {
        public void SetLogger(string message)
        {
            this.Log(message);
        }

        protected override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
