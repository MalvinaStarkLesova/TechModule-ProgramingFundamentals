using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int healthNow = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energyNow = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: {0}{1}{2}{0}", "|", new string('|', healthNow), new string('.', healthMax - healthNow));
            Console.WriteLine("Energy: {0}{1}{2}{0}", "|", new string('|', energyNow), new string('.', energyMax - energyNow));

        }
    }
}
