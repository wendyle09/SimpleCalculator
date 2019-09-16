using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddTwoNumbersUsingNonSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("add", intNum1, intNum2);
            Assert.AreEqual(3, dblResult);
        }

        [TestMethod]
        public void AddTwoNumbersUsingSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("+", intNum1, intNum2);
            Assert.AreEqual(3, dblResult);
        }

        [TestMethod]
        public void SubtractTwoNumbersUsingNonSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("subtract", intNum1, intNum2);
            Assert.AreEqual(-1, dblResult);
        }

        [TestMethod]
        public void SubtractTwoNumbersUsingSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("-", intNum1, intNum2);
            Assert.AreEqual(-1, dblResult);
        }

        [TestMethod]
        public void MultiplyTwoNumbersUsingNonSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("multiply", intNum1, intNum2);
            Assert.AreEqual(2, dblResult);
        }

        [TestMethod]
        public void MultiplyTwoNumbersUsingSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("*", intNum1, intNum2);
            Assert.AreEqual(2, dblResult);
        }

        [TestMethod]
        public void DivideTwoNumbersUsingNonSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("divide", intNum1, intNum2);
            Assert.AreEqual(0.5, dblResult);
        }

        [TestMethod]
        public void DivideTwoNumbersUsingSymbolOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("/", intNum1, intNum2);
            Assert.AreEqual(0.5, dblResult);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowExpectedMessageForInvalidOperator()
        {
            int intNum1 = 1;
            int intNum2 = 2;
            double dblResult = _calculatorEngine.Calculate("plus", intNum1, intNum2);
        }
    }
}
