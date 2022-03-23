using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            Taxi taxi1 = new Taxi();


            taxi.DriverName = "Fajar";
            taxi.OnDuty = true;
            taxi.NumPassenger = 18;

            taxi1.DriverName = "Aditya";
            taxi1.OnDuty = false;
            taxi1.NumPassenger = 15;


            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            taxi1.TaxiInfo();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassenger();


            Console.ReadKey();
        }
    }
}
