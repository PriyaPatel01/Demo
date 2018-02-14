using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Truck:Vehicle
    {
        public Truck(string manufacturer, string model, string type, string yearOfManufacturing) : base(manufacturer, model, type, yearOfManufacturing)
        {
        }
        private void InstallCover()
        {
            Console.WriteLine("Cover installation under process...");
            Thread.Sleep(2000);
            Console.WriteLine("Cover has been installed.");

        }
        public override void ServiceVehicle()
        {
            base.ServiceVehicle();
            this.InstallCover();
            Console.WriteLine();
        }
    }
}
