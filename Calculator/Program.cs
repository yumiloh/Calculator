using System;
using System.Runtime.Serialization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0, number2 = 0;
            Calculator Calculator = new Calculator();
            Console.WriteLine($"Choose an operation: \n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = Convert.ToDouble(Console.ReadLine());

            Calculator.calculatorDelegate = Calculator.GetDelegateRef(option);
            Console.WriteLine($"Result: {Calculator.calculatorDelegate(number1, number2)}");
        }
    }
}
