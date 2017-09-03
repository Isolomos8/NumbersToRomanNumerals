using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToRomanNumeralsService
{
    public class NumbersToRomanNumeralsConverter
    {
        public string Convert(string number)
        {
            // Create 2D array, breaking the roman numerals in their respective units
            var romanNumerals = new string[][]
            {
            new string[]{"", "I ", "II ", "III ", "IV ", "V ", "VI ", "VII ", "VIII ", "IX "}, // ones
            new string[]{"", "X ", "XX ", "XXX ", "XL ", "L ", "LX ", "LXX ", "LXXX ", "XC "}, // tens
            new string[]{"", "C ", "CC ", "CCC ", "CD ", "D ", "DC ", "DCC ", "DCCC ", "CM "}, // hundreds
            new string[]{"", "M ", "MM ", "MMM "} // thousands
            };

            // Reverse the array, and start from the biggest digit
            var intArr = number.ToString().Reverse().ToArray();
            var length = intArr.Length;
            var romanNumeral = "";
            // Start from the end
            var i = length;

            while (i-- > 0)
            {
                romanNumeral += romanNumerals[i][Int32.Parse(intArr[i].ToString())];
            }

            return romanNumeral;
        }
    }
}
