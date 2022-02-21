﻿using System;
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

        //Test Methods
        [TestMethod]
        public void Test_Multiply_Two_Positive_Numbers()
        {
            Assert.AreEqual(20.0, _calculator.Multiply(10.0, 2.0));
        }

        [TestMethod]
        public void Test_Multiply_Two_Negative_Numbers()
        {
            Assert.AreEqual(50.0, _calculator.Multiply(-10.0, -5.0));
        }

        [TestMethod]
        public void Test_Multiply_One_Positive_One_Negative_Numbers()
        {
            Assert.AreEqual(-8.0, _calculator.Multiply(2.0, -4.0));
        }

        [TestMethod]
        public void Test_Multiply_One_Negative_One_Positive_Numbers()
        {
            Assert.AreEqual(-16.0, _calculator.Multiply(-2.0, 8.0));
        }

        [TestMethod]
        public void Test_Multiply_Two_Decimal_Numbers()
        {
            Assert.AreEqual(8.25, _calculator.Multiply(2.5, 3.3));
        }

        //Data Test Methods
        [TestMethod]
        [DataRow(10.0, 2.0)]
        [DataRow(2.0, 3.0)]
        public void Test_Multiply_Two_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        [TestMethod]
        [DataRow(10.43, 2.2)]
        [DataRow(2.4, 3.5)]
        public void Test_Multiply_Two_Decimal_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        [TestMethod]
        [DataRow(-10.6, -8.2)]
        [DataRow(-3.2, -7.524)]
        public void Test_Multiply_Two_Decimal_Negative_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        [TestMethod]
        [DataRow(-14.624, 8)]
        [DataRow(-1.2, 6)]
        public void Test_Multiply_One_Decimal_Negative_One_Positive_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }

        [TestMethod]
        [DataRow(12, 8.453)]
        [DataRow(5, 6.934)]
        public void Test_Multiply_One_Positive_One_Decimal_Positive_Values(double first, double second)
        {
            Assert.AreEqual(first * second, _calculator.Multiply(first, second));
        }
    }
}
