using System;
using System.Runtime.Serialization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calculator = new Calculator();
            Console.WriteLine($"Choose an operation: \n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            Calculator.Number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            Calculator.Number2 = Convert.ToDouble(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine($"Result: {Calculator.Add()}");
            }
            else if (option == 2)
            {
                Console.WriteLine($"Result: {Calculator.Subtract()}");
            }
            else if (option == 3)
            {
                Console.WriteLine($"Result: {Calculator.Multiply()}");
            }
            else if (option == 4)
            {
                Console.WriteLine($"Result: {Calculator.Divide()}");
            }
            else
            {
                Console.WriteLine("Error Input");
            }
        }
    }
}
