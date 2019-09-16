using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string strOperation, double dblNum1, double dblNum2)
        {
            double result;

            // Perform calculation based on input operator
            switch (strOperation.ToLower())
            {
                case "add":
                case "+":
                    result = dblNum1 + dblNum2;
                    break;
                case "minus":
                case "-":
                    result = dblNum1 - dblNum2;
                    break;
                case "multiply":
                case "*":
                    result = dblNum1 * dblNum2;
                    break;
                case "divide":
                case "/":
                    result = dblNum1 / dblNum2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }

            return result;
        }
    }
}
