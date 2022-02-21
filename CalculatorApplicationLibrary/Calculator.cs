using System;

/*This will be Calculator Library code containing methods for Addition,
  Subtraction, Multiplication and Division*/
namespace CalculatorApplicationLibrary
{
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

            //User to enter two values
            Console.WriteLine("Enter First Value");
            userEntry = Console.ReadLine();
            a = Convert.ToDouble(userEntry);

            Console.WriteLine("Enter Second Value");
            userEntry = Console.ReadLine();
            b = Convert.ToDouble(userEntry);

            var calculate = new Calculator();

            //Calling all four methods
            Console.WriteLine("Results");
            Console.WriteLine("-------");
            Console.WriteLine("Addition: " + a + " + " + b + " = " + calculate.Add(a, b));
            Console.WriteLine("Subtraction: " + a + " - " + b + " = " + calculate.Subtract(a, b));
            Console.WriteLine("Multiplication: " + a + " x " + b + " = " + calculate.Multiply(a, b));
            var divisionResult = calculate.Divide(a, b);
            if (divisionResult != null)
            {
                Console.WriteLine("Division: " + a + " / " + b + " = " + divisionResult);
            }

            
        }
    }
}
