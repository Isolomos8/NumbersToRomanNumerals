using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToRomanNumeralsService
{
    public static class Logger
    {
        private const string Colon = " : ";
        public static void Log(string message)
        {
            File.AppendAllText(ServiceConfiguration.LogFileLocation, DateTime.Now.ToString(ServiceConfiguration.TimestampFormat) + Colon + message + Environment.NewLine);
        }
    }
}
