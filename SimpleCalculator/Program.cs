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

                    // Read inputs
                    Console.Write("Enter first number: ");
                    double dblNum1 = inputConverter.ConvertToNumeric(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double dblNum2 = inputConverter.ConvertToNumeric(Console.ReadLine());
                    Console.Write("Enter operator: ");
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
                        Console.Write("Do you want to start over? (yes/no)");
                        strRestart = Console.ReadLine();
                    } while (!strRestart.Equals("yes", StringComparison.OrdinalIgnoreCase) && !strRestart.Equals("no", StringComparison.OrdinalIgnoreCase));
                    // Set boolean based on user's input
                    continueProgram = strRestart.Equals("yes", StringComparison.OrdinalIgnoreCase);
                }
            } while (continueProgram);
        }
    }
}
