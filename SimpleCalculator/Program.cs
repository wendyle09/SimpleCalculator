﻿using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                // Read inputs
                double dblNum1 = inputConverter.ConvertToNumeric(Console.ReadLine());
                double dblNum2 = inputConverter.ConvertToNumeric(Console.ReadLine());
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
        }
    }
}
