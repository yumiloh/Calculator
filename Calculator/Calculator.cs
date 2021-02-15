using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public delegate double CalculatorDelegate(double number1, double number2);

        public CalculatorDelegate calculatorDelegate = null;

        public CalculatorDelegate GetDelegateRef(int option)
        {
            if (option == 1)
            {
                calculatorDelegate = Add;
            }
            else if (option == 2)
            {
                calculatorDelegate = Subtract;
            }
            else if (option == 3)
            {
                calculatorDelegate = Multiply;
            }
            else if (option == 4)
            {
                calculatorDelegate = Divide;
            }
            else
            {
                Console.WriteLine("Error Input");
            }
            //string result = calculatorDelegate.ToString();
            return calculatorDelegate;
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        
        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException();
            }
            return number1 / number2;
        }
    }
}
