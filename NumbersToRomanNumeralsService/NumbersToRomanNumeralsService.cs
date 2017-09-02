using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToRomanNumeralsService
{
    public partial class NumbersToRomanNumeralsService : ServiceBase
    {
        public NumbersToRomanNumeralsService()
        {
            InitializeComponent();
        }

        // Assume args is the sentence/(s) that will be filtered
        protected override void OnStart(string[] args)
        {
            ServiceConfiguration.Read();
            Logger.Log("Started NumbersToRomanNumeralsService");
            Logger.Log("Loaded application configuration");
            Logger.Log("LogFileLocation = " + ServiceConfiguration.LogFileLocation);
            var conventer = new NumbersToRomanNumeralsConverter();
            foreach (var item in args)
            {
                Logger.Log("Converted numbers are: " + conventer.Convert(item));
            }
        }

        protected override void OnStop()
        {
            Logger.Log("Stopped NumbersToRomanNumeralsService");
        }
    }
}
