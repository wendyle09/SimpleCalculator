using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            string strRestart;

            do
            {
                try
                {
                    InputConverter inputConverter = new InputConverter();
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    // Prompt for and receive equation
                    Console.Write(Constants.PromptForFirstNumber);
                    double dblNum1 = inputConverter.ConvertToNumeric(Console.ReadLine());
                    Console.Write(Constants.PromptForSecondNumber);
                    double dblNum2 = inputConverter.ConvertToNumeric(Console.ReadLine());
                    Console.Write(Constants.PromptForOperator);
                    string operation = Console.ReadLine();

                    // Call Calculate function
                    double result = calculatorEngine.Calculate(operation, dblNum1, dblNum2);

                    // Write result
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Ask if user wants to restart program
                    do
                    {
                        Console.Write(Constants.PromptForRestartingProgram);
                        strRestart = Console.ReadLine();
                    } while (!strRestart.Equals(Constants.InputToRestartProgram, StringComparison.OrdinalIgnoreCase) && !strRestart.Equals(Constants.InputToStopProgram, StringComparison.OrdinalIgnoreCase));
                    // Set boolean based on user's input
                    continueProgram = strRestart.Equals(Constants.InputToRestartProgram, StringComparison.OrdinalIgnoreCase);
                }
            } while (continueProgram);
        }
    }
}
