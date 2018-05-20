using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();
            string drink = String.Empty;

            if (profession == "athlete")
            {
                drink = "Water";
                Console.WriteLine(drink);
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                drink = "Coffee";
                Console.WriteLine(drink);
            }
            else if (profession == "softuni student")
            {
                drink = "Beer";
                Console.WriteLine(drink);
            }
            else
            {
                drink = "Tea";
                Console.WriteLine(drink);
            }
        }
    }
}
