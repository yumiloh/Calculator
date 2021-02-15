using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator : ICalculator
    {
        private int options;
        public int Options
        { 
            get
            {
                return options;
            }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    options = value;
                }
            }
        }

        public double Calculations(double number1, double number2)
        {
            if (options == 1)
            {
                return Add(number1, number2);
            } 
            else if (options == 2)
            {
                return Subtract(number1, number2);
            }
            else if (options ==3)
            {
                return Multiply(number1, number2);
            }
            else 
            {
                return Divide(number1, number2);
            }  
        }

        private double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        private double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        private double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        private double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException();
            }
            return number1 / number2;
        }
    }
}
