using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface ICalculator
    {
        public int Options { get; set; }
        public double Calculations(double number1, double number2);
    }
}
