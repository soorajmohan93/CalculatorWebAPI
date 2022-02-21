using System;
using CalculatorApplicationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    // Class to Test Division Methods
    [TestClass]
    public class DivisionTest
    {
        private readonly Calculator _calculator;

        public DivisionTest()
        {
            _calculator = new Calculator();
        }

        //Test Method to divide two positive integers (Test1)
        [TestMethod]
        public void Test_Divide_Two_Positive_Numbers()
        {
            Assert.AreEqual(5.0, _calculator.Divide(10.0, 2.0));
        }

        //Test Method to divide two negative integers (Test2)
        [TestMethod]
        public void Test_Divide_Two_Negative_Numbers()
        {
            Assert.AreEqual(2.0, _calculator.Divide(-10.0, -5.0));
        }

        //Test Method to divide one positive with one negative integers (Test3)
        [TestMethod]
        public void Test_Divide_One_Positive_One_Negative_Numbers()
        {
            Assert.AreEqual(-0.5, _calculator.Divide(2.0, -4.0));
        }

        //Test Method to divide one negative with one positive integers (Test4)
        [TestMethod]
        public void Test_Divide_One_Negative_One_Positive_Numbers()
        {
            Assert.AreEqual(-0.25, _calculator.Divide(-2.0, 8.0));
        }

        //Test Method to divide two positive decimal numbers (Test5)
        [TestMethod]
        public void Test_Divide_Two_Decimal_Numbers()
        {
            Assert.AreEqual(0.75, _calculator.Divide(7.2, 9.6));
        }

        //Data Test Method to divide two positive integer values (Test6)
        [TestMethod]
        [DataRow(10.0, 2.0)]
        [DataRow(5.0, 3.0)]
        public void Test_Divide_Two_Values(double first, double second)
        {
            Assert.AreEqual((double)((decimal)first / (decimal)second), _calculator.Divide(first, second));
        }

        //Data Test Method to divide two positive decimal values (Test7)
        [TestMethod]
        [DataRow(10.43, 2.2)]
        [DataRow(2.4, 3.5)]
        public void Test_Divide_Two_Decimal_Values(double first, double second)
        {
            Assert.AreEqual((double)((decimal)first / (decimal)second), _calculator.Divide(first, second));
        }

        //Data Test Method to divide two negative decimal values (Test8)
        [TestMethod]
        [DataRow(-10.6, -8.2)]
        [DataRow(-3.2, -7.524)]
        public void Test_Divide_Two_Decimal_Negative_Values(double first, double second)
        {
            Assert.AreEqual((double)((decimal)first / (decimal)second), _calculator.Divide(first, second));
        }

        //Data Test Method to divide one negative decimal with one positive integer values (Test9)
        [TestMethod]
        [DataRow(-14.624, 8)]
        [DataRow(-1.2, 6)]
        public void Test_Divide_One_Decimal_Negative_One_Positive_Values(double first, double second)
        {
            Assert.AreEqual((double)((decimal)first / (decimal)second), _calculator.Divide(first, second));
        }

        //Data Test Method to divide one positive integer with one positive decimal values (Test10)
        [TestMethod]
        [DataRow(12, 8.453)]
        [DataRow(5, 6.934)]
        public void Test_Divide_One_Positive_One_Decimal_Positive_Values(double first, double second)
        {
            Assert.AreEqual((double)((decimal)first / (decimal)second), _calculator.Divide(first, second));
        }

        //Test Method for divide by zero exception
        [TestMethod]
        public void Test_Divide_By_Zero()
        {
            try
            {
                Assert.AreEqual(null, _calculator.Divide(10.0, 0.0));
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreNotEqual(null, ex);
            }
        }

        //Data Test Method for divide by zero exception
        [TestMethod]
        [DataRow(3.2, 0)]
        [DataRow(5, 0)]
        [DataRow(10.08, 0)]
        [DataRow(0,0)]
        public void Data_Test_Divide_By_Zero(double first, double second)
        {
            try
            {
                Assert.AreEqual(null, _calculator.Divide(first, second));
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreNotEqual(null, ex);
            }
        }
    }
}
