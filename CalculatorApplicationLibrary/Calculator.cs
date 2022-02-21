using System;

/*This will be Calculator Library code containing methods for Addition,
  Subtraction, Multiplication and Division*/
namespace CalculatorApplicationLibrary
{
    //Class containing method for all four operations
    public class Calculator
    {
        //Method to add two numbers
        public double Add(double first, double second)
        {
            return first + second;
        }

        //Method to subtract two numbers
        public double Subtract(double first, double second)
        {
            return first - second;
        }

        //Method to multiply two numbers
        public double Multiply(double first, double second)
        {
            return first * second;
        }

        //Method to divide two numbers
        public double? Divide(double first, double second)
        {
            decimal result = 0.0M;

            //try catch block to handle division by zero exceptions
            try
            {
                result = (decimal)first / (decimal)second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by 0 is not valid! Error: " + ex);
                //the below exception will be caught by the test method and WebAPI calls
                throw new DivideByZeroException();
            }
            return (double)result;
        }

        //Main Method used to execute above methods with user entered values 
        static void Main(string[] args)
        { 
            double a = 0.0;
            double b = 0.0;
            string userEntry;

            //User to enter first value in console
            Console.WriteLine("Enter First Value");
            userEntry = Console.ReadLine();
            a = Convert.ToDouble(userEntry);

            //User to enter first value in console
            Console.WriteLine("Enter Second Value");
            userEntry = Console.ReadLine();
            b = Convert.ToDouble(userEntry);

            var calculate = new Calculator();

            //Calling all four methods and displaying in console
            Console.WriteLine("Results");
            Console.WriteLine("-------");

            //Addition
            Console.WriteLine("Addition: " + a + " + " + b + " = " + calculate.Add(a, b));

            //Subtraction
            Console.WriteLine("Subtraction: " + a + " - " + b + " = " + calculate.Subtract(a, b));

            //Multiplication
            Console.WriteLine("Multiplication: " + a + " x " + b + " = " + calculate.Multiply(a, b));

            //Division result will be shown only if result value is not null
            var divisionResult = calculate.Divide(a, b);
            if (divisionResult != null)
            {
                Console.WriteLine("Division: " + a + " / " + b + " = " + divisionResult);
            }
        }
    }
}
