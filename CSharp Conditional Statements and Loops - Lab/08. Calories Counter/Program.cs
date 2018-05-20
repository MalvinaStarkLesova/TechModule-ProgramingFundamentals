using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine().ToLower();
                switch (product)
                {
                    case "cheese": calories = 500; sum += calories; break;
                    case "tomato sauce": calories = 150; sum += calories; break;
                    case "salami": calories = 600; sum += calories; break;
                    case "pepper": calories = 50; sum += calories; break;
                    default: continue;
                }
            } 
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
