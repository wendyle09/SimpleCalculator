using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CalculatorEngine
    {
        public double Calculate(string strOperation, double dblNum1, double dblNum2)
        {
            double result;

            switch (strOperation.ToLower())
            {
                case "add":
                case "+":
                    result = dblNum1 + dblNum2;
                    break;
                case "subtract":
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
