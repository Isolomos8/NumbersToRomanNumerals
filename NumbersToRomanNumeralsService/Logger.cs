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
        private const string WhiteSpace = " ";
        public static void Log(string message)
        {
            File.AppendAllText(ServiceConfiguration.LogFileLocation, DateTime.Now.ToString(ServiceConfiguration.TimestampFormat) + Colon + message + Environment.NewLine);
        }

        public static void LogNewLine()
        {
            File.AppendAllText(ServiceConfiguration.LogFileLocation, Environment.NewLine);
        }

        public static void LogOnSameLine(string message)
        {
            File.AppendAllText(ServiceConfiguration.LogFileLocation, message + WhiteSpace);
        }
    }
}
