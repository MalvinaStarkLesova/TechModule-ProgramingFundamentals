﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal kilometer = miles * (decimal) 1.60934;
            Console.WriteLine("{0:F2}", kilometer);
        }
    }
}
