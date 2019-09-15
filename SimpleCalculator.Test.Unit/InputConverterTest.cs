﻿using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string strInput = "5";
            double dblNum = _inputConverter.ConvertToNumeric(strInput);
            Assert.AreEqual(5, dblNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string strInput = "five";
            double dblNum = _inputConverter.ConvertToNumeric(strInput);
        }
    }
}