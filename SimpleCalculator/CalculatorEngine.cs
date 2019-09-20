using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class CalculatorEngine
    {
        public double Calculate(string strOperation, double dblNum1, double dblNum2)
        {
            double result;

            // Perform calculation based on input operator
            switch (strOperation.ToUpper())
            {
                case Constants.InputForAdditionSymbol:
                case Constants.InputForAdditionWord:
                    result = dblNum1 + dblNum2;
                    break;
                case Constants.InputForSubtractionSymbol:
                case Constants.InputForSubtractionWord:
                    result = dblNum1 - dblNum2;
                    break;
                case Constants.InputForMultiplicationSymbol:
                case Constants.InputForMultiplicationWord:
                    result = dblNum1 * dblNum2;
                    break;
                case Constants.InputForDivisionSymbol:
                case Constants.InputForDivisionWord:
                    result = dblNum1 / dblNum2;
                    break;
                default:
                    throw new InvalidOperationException(Constants.OutputForInvalidOperator);
            }

            return result;
        }
    }
}
