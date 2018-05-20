using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    doubleRoom = 65;
                    suite = 75;
                    break;
                case "June":
                case "September":
                    studio = 60;
                    doubleRoom = 72;
                    suite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studio = 68;
                    doubleRoom = 77;
                    suite = 89;
                    break;
            }

            if ((month == "May" || month == "October") && nights > 7)
            {
                studio *= 0.95;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                doubleRoom *= 0.90; 
            }
            else if ((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                suite *= 0.85;
            }

            double finalStudio = studio * nights;
            double finalDouble = doubleRoom * nights;
            double finalSuite = suite * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                finalStudio -= studio; 
            }

            Console.WriteLine($"Studio: {finalStudio:f2} lv.");
            Console.WriteLine($"Double: {finalDouble:f2} lv.");
            Console.WriteLine($"Suite: {finalSuite:f2} lv.");
        }
    }
}
