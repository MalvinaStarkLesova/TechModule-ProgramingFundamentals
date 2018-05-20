using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int sum = 0;
            while (product != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {product}.");
                product = Console.ReadLine();
                sum++;
            }
                Console.WriteLine($"Preparing cake with {sum} ingredients.");
        }
    }
}
