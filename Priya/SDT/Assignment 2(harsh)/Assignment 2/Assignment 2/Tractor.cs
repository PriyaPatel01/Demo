using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Tractor:Vehicle
    {
        public Tractor(string manufacturer, string model, string type, string yearOfManufacturing) : base(manufacturer, model, type, yearOfManufacturing)
        {
        }
        private void PTOMaintainance()
        {
            Console.WriteLine("PTO Maintainance is under process...");
            Thread.Sleep(2000);
            Console.WriteLine("PTO Maintainance has been done.");

        }
        public override void ServiceVehicle()
        {
            base.ServiceVehicle();
            this.PTOMaintainance();
            Console.WriteLine();
        }
    }
}
