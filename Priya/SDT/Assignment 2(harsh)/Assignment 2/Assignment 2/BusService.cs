using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2
{
    class BusService:Vehicle
    {
        public BusService(string manufacturer, string model, string type, string yearOfManufacturing) : base(manufacturer, model, type, yearOfManufacturing)
        {
        }
        private void CleanInterior()
        {
            Console.WriteLine("Interior cleaning is under process...");
            Thread.Sleep(2000);
            Console.WriteLine("Bus interior has been cleaned up.");

        }
        public override void ServiceVehicle()
        {
            base.ServiceVehicle();
            this.CleanInterior();
            Console.WriteLine();
        }
    }
}
