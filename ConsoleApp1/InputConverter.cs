using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class InputConverter
    {
        public double ConvertToNumeric(string strInput)
        {
            double dblConverted;
            if (!double.TryParse(strInput, out dblConverted)) throw new ArgumentException("Expected a numeric value.");
            return dblConverted;
        }
    }
}
