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
            int numberOfReplacements = 0;
            foreach (var item in args)
            {
                int number;
                if (int.TryParse(item, out number))
                {
                    Logger.LogOnSameLine(conventer.Convert(number.ToString()));
                    numberOfReplacements++;
                }
                else
                    Logger.LogOnSameLine(item);
            }
            Logger.LogNewLine();
            Logger.LogOnSameLine("There were " + numberOfReplacements + " replacements found");

        }

        protected override void OnStop()
        {
            Logger.LogNewLine();
            Logger.Log("Stopped NumbersToRomanNumeralsService");
        }
    }
}
