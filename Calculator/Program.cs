using System;
using System.Runtime.Serialization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator Calculator = new Calculator();
            try
            {
                Console.Write($"Choose an operation: \n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide \n Your choice: ");
                Calculator.Options = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter first number:");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number");
                double number2 = Convert.ToDouble(Console.ReadLine());

                var result = Calculator.Calculations(number1, number2);
                Console.WriteLine($"The result is {result}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception)
            {
                Console.WriteLine("Some error has occured.");
            }
        }
    }
}
