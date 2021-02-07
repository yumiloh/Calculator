using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public double Add()
        {
            return Number1 + Number2;
        }

        public double Subtract()
        {
            return Number1 - Number2;
        }

        public double Multiply()
        {
            return Number1 * Number2;
        }
        
        public double Divide()
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException();
            }
            return Number1 / Number2;
        }
    }
}
