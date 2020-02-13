using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCalculator.CalculatorTests
{
    [TestClass()]
    public class SharedCalculatorCalculatorTests
    {
        [TestMethod()]
        public void AddCalculatorTest()
        {
            SharedCalculator _calculatorTest = new SharedCalculator();
            double result = _calculatorTest.Add(1, 2);
            Assert.AreEqual(3,result);
        }

        [TestMethod()]
        public void SubtractCalculatorTest()
        {
            SharedCalculator _calculatorTest = new SharedCalculator();
            double result = _calculatorTest.Subtract(9, 8);
            Assert.AreEqual(1,result);
        }

        [TestMethod()]
        public void MultiplyCalculatorTest()
        {
            SharedCalculator _calculatorTest = new SharedCalculator();
            double result = _calculatorTest.Multiply(1, 2);
            Assert.AreEqual(2,result);
        }

        [TestMethod()]
        public void DivideCalculatorTest()
        {
            SharedCalculator _calculatorTest = new SharedCalculator();
            double result = _calculatorTest.Divide(4, 2);
            Assert.AreEqual(2,result);
        }
    }
}