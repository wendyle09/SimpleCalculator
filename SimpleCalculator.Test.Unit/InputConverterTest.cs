using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string strInput = "5";
            double dblNum = _inputConverter.ConvertToNumeric(strInput);
            Assert.AreEqual(5, dblNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailToConvertInvalidStringInputIntoDouble()
        {
            string strInput = "five";
            double dblNum = _inputConverter.ConvertToNumeric(strInput);
        }
    }
}
