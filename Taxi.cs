using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }
        public string Keterangan { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Driver Name: {0}", DriverName);
            if(OnDuty == true)
            {
                Keterangan = "Yes";
            }
            else
            {
                Keterangan = "No";
            }
            Console.WriteLine("OnDuty: {0}", Keterangan);
            Console.WriteLine("Num Passenger: {0}\n", NumPassenger);
            Console.WriteLine("-----------------------------------");

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
            Console.WriteLine("***********************************");
        }
    }
}
