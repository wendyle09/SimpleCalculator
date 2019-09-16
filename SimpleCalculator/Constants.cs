using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Constants
    {
        // Expected inputs
        public const string InputToRestartProgram = "YES";
        public const string InputToStopProgram = "NO";
        public const string InputForAdditionSymbol = "+";
        public const string InputForAdditionWord = "ADD";
        public const string InputForSubtractionSymbol = "-";
        public const string InputForSubtractionWord = "SUBTRACT";
        public const string InputForMultiplicationSymbol = "*";
        public const string InputForMultiplicationWord = "MULTIPLY";
        public const string InputForDivisionSymbol = "/";
        public const string InputForDivisionWord = "DIVIDE";

        // Prompts for input
        public const string PromptForRestartingProgram = "Do you want to start over? (yes/no)";
        public const string PromptForFirstNumber = "Enter first number: ";
        public const string PromptForSecondNumber = "Enter second number: ";
        public const string PromptForOperator = "Enter operator: ";

        // Outputs not expecting input
        public const string OutputForInvalidNumber = "Expected a numeric value.";
        public const string OutputForInvalidOperator = "Specified operator is not recognized. Operator must be one of the following: +, add, -, subtract, *, multiply, /, divide";

    }
}
