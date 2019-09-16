using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertToNumeric(string strInput)
        {
            double dblConverted;
            // Try to convert input to double and throw error if cannot convert
            if (!double.TryParse(strInput, out dblConverted)) throw new ArgumentException("Expected a numeric value.");
            return dblConverted;
        }
    }
}
