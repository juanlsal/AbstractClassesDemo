using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public bool HasAirBag { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Airbag installed: {HasAirBag}\nHas trunk: {HasTrunk}");
        }

    }
}




