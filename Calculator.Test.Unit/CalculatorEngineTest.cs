using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation() // Naming convention: name of feature being tested
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result); // 1st arg is expected result, 2nd arg is actual result
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation() // Naming convention: name of feature being tested
        {
            int number1 = 3;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(7, result); // 1st arg is expected result, 2nd arg is actual result
        }
    }
}
