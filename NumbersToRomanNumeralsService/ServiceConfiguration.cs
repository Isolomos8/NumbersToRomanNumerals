using System.Configuration;

namespace NumbersToRomanNumeralsService
{
    public static class ServiceConfiguration
    {
        public static string LogFileLocation { get; set; }
        public static string TimestampFormat { get { return "yyyy-MM-dd HH:mm:ss:fff"; } }
        public static void Read()
        {
            ServiceConfiguration.LogFileLocation = ConfigurationManager.AppSettings["LogFileLocation"];
        }
    }
}
