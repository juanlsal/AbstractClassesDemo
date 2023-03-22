using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year = "2009";
        public string Make = "Toyota";
        public string Model = "Corolla";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The car that just entered the parking deck is a {Year} {Make} {Model}.");
        }
    }
}
