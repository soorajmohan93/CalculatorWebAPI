using System;
using CalculatorApplicationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    //Class to test multiplication methods
    [TestClass]
    public class MultiplicationTest
    {
        private readonly Calculator _calculator;

        public MultiplicationTest()
        {
            _calculator = new Calculator();
        }

        //Test Method to multiply two positive integers (Test1)
        [TestMethod]
        public void Test_Multiply_Two_Positive_Numbers()
        {
            Assert.AreEqual(20.0, _calculator.Multiply(10.0, 2.0));
        }

        //Test Method to multiply two negative integers (Test2)
        [TestMethod]
        public void Test_Multiply_Two_Negative_Numbers()
        {
            Assert.AreEqual(50.0, _calculator.Multiply(-10.0, -5.0));
        }

        //Test Method to multiply one positive and one negative integers (Test3)
        [TestMethod]
        public void Test_Multiply_One_Positive_One_Negative_Numbers()
        {
            Assert.AreEqual(-8.0, _calculator.Multiply(2.0, -4.0));
        }

        //Test Method to multiply one negative and one positive integers (Test4)
        [TestMethod]
        public void Test_Multiply_One_Negative_One_Positive_Numbers()
        {
            Assert.AreEqual(-16.0, _calculator.Multiply(-2.0, 8.0));
        }

        //Test Method to multiply two positive decimal numbers (Test5)
        [TestMethod]
        public void Test_Multiply_Two_Decimal_Numbers()
        {
            Assert.AreEqual(8.25, _calculator.Multiply(2.5, 3.3));
        }

        //Data Test Method to multiply two positive integer values (Test6)
        [TestMethod]
        [DataRow(10.0, 2.0)]
        [DataRow(2.0, 3.0)]
        public void Test_Multiply_Two_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        //Data Test Method to multiply two positive decimal values (Test7)
        [TestMethod]
        [DataRow(10.43, 2.2)]
        [DataRow(2.4, 3.5)]
        public void Test_Multiply_Two_Decimal_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        //Data Test Method to multiply two negative decimal values (Test8)
        [TestMethod]
        [DataRow(-10.6, -8.2)]
        [DataRow(-3.2, -7.524)]
        public void Test_Multiply_Two_Decimal_Negative_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        //Data Test Method to multiply one negative decimal and one positive integer values (Test9)
        [TestMethod]
        [DataRow(-14.624, 8)]
        [DataRow(-1.2, 6)]
        public void Test_Multiply_One_Decimal_Negative_One_Positive_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        //Data Test Method to multiply one positive integer and one positive decimal values (Test10)
        [TestMethod]
        [DataRow(12, 8.453)]
        [DataRow(5, 6.934)]
        public void Test_Multiply_One_Positive_One_Decimal_Positive_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }
    }
}
