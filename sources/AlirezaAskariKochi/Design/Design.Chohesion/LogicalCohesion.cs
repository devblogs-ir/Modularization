using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Chohesion
{
    public class LogicalCohesion
    {
        public class Logger
        {
            public void Log(string message, string logType)
            {
                if (logType == "Error")
                {
                    Console.WriteLine($"Log an error : {message}");
                }
                else if (logType == "Info")
                {
                    Console.WriteLine($"Log information : {message}");
                }
            }
        }

    }
}
