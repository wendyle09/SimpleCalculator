using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("add", intNum1, intNum2);
            Assert.AreEqual(3, dblResult);
        }

            [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("+", intNum1, intNum2);
            Assert.AreEqual(3, dblResult);
        }
    }
}
