using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int ticketPriceChildren = 0;
            int ticketPriceAdults = 0;
            int ticketPriceSeniors = 0;

            switch (dayType)
            {
                case "weekday":
                    ticketPriceChildren = 12;
                    ticketPriceAdults = 18;
                    ticketPriceSeniors = 12;
                    break;
                case "weekend":
                    ticketPriceChildren = 15;
                    ticketPriceAdults = 20;
                    ticketPriceSeniors = 15;
                    break;
                case "holiday":
                    ticketPriceChildren = 5;
                    ticketPriceAdults = 12;
                    ticketPriceSeniors = 10;
                    break;
            }

            if (age >= 0 && age <= 18)
            {
                Console.WriteLine($"{ticketPriceChildren}$");
            }
            else if (age > 18 && age <= 64)
            {
                Console.WriteLine($"{ticketPriceAdults}$");
            }
            else if (age > 64 && age <= 122)
            {
                Console.WriteLine($"{ticketPriceSeniors}$");
            }

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
        }

    }
}
