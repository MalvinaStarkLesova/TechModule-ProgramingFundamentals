﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    if (i + j == magical)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magical}");
                        return;
                    }
                    counter++;
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magical}");
        }
    }
}
