using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyFinal = (double) volume / 100 * (double) energy;
            double sugarFinal = (double) volume / 100 * (double) sugar;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyFinal}kcal, {sugarFinal}g sugars");
        }
    }
}
