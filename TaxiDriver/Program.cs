using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiDriver TaxiDriver = new TaxiDriver();

            TaxiDriver.DriverName = "Jono";
            TaxiDriver.OnDuty = true;
            TaxiDriver.NumPassenger = 10;

            TaxiDriver.TaxiInfo();
            TaxiDriver.PickUpPassenger();
            TaxiDriver.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
