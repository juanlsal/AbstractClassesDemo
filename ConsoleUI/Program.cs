using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var vehicles = new List<Vehicle>();

            var mycar = new Car()
            {
                HasTrunk = true,
                HasAirBag = true
            };
            vehicles.Add(mycar);

            var jimsMotorcycle = new Motorcycle()
            {
                Make = "Bati",
                Year = "2019",
                Model = "801",
                HasSideCart = true,
                CanWheelie = false
            };
            vehicles.Add(jimsMotorcycle);

            var batMobile = new Car() 
            {
                Make = "Mustang",
                Year = "2023",
                Model = "Extreme",
                HasTrunk = false,
                HasAirBag = true
            };
            vehicles.Add(batMobile);

            var stuntBike = new Motorcycle()
            {
                Make = "Stuntster",
                Year = "1987",
                Model = "Menace",
                HasSideCart = false,
                CanWheelie = true
            };
            vehicles.Add(stuntBike);

            foreach (var items in vehicles)
            {
                items.DriveVirtual();
                items.DriveAbstract();
                count++;
                Console.WriteLine($"Vehicle count = {count}.");
                Console.WriteLine("\npress Enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Shift Over.");



        }
    }
}
