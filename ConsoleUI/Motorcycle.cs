using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public bool CanWheelie { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Wheelie capability: {CanWheelie}\nSide cart installed: {HasSideCart}");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"The motercycle that just entered the parking deck is a {Year} {Make} {Model}.");
        }

    }
}
