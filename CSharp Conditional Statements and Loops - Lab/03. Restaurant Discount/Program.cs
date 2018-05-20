using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            int smallHall = 2500;
            int terrace = 5000;
            int greatHall = 7500;
            int hall = 0;
            string hallName = "";
            double total = 0;
            double perPerson = 0;

            if (package == "normal")
            {
                if (people <= 50)
                {
                    hall = smallHall;
                    hallName = "Small Hall";
                    total = (hall + 500) - 0.05 * (hall + 500);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");

                }
                else if (people <= 100)
                {
                    hall = terrace;
                    hallName = "Terrace";
                    total = (hall + 500) - 0.05 * (hall + 500);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else if (people <= 120)
                {
                    hall = greatHall;
                    hallName = "Great Hall";
                    total = (hall + 500) - 0.05 * (hall + 500);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
            else if (package == "gold")
            {
                if (people <= 50)
                {
                    hall = smallHall;
                    hallName = "Small Hall";
                    total = (hall + 750) - 0.10 * (hall + 750);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else if (people <= 100)
                {
                    hall = terrace;
                    hallName = "Terrace";
                    total = (hall + 750) - 0.10 * (hall + 750);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else if (people <= 120)
                {
                    hall = greatHall;
                    hallName = "Great Hall";
                    total = (hall + 750) - 0.10 * (hall + 750);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
            else if (package == "platinum")
            {
                if (people <= 50)
                {
                    hall = smallHall;
                    hallName = "Small Hall";
                    total = (hall + 1000) - 0.15 * (hall + 1000);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else if (people <= 100)
                {
                    hall = terrace;
                    hallName = "Terrace";
                    total = (hall + 1000) - 0.15 * (hall + 1000);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else if (people <= 120)
                {
                    hall = greatHall;
                    hallName = "Great Hall";
                    total = (hall + 1000) - 0.15 * (hall + 1000);
                    perPerson = total / people;
                    Console.WriteLine($"We can offer you the {hallName}");
                    Console.WriteLine($"The price per person is {perPerson:f2}$");
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
        }
    }
}
