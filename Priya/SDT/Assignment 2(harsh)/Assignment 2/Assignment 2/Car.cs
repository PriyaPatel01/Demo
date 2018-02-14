using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Car:Vehicle
    {
        public Car(string manufacturer, string model, string type, string yearOfManufacturing) : base(manufacturer, model, type, yearOfManufacturing)
        {
        }
        private void TuneUpBody()
        {
            Console.WriteLine("Body tuneup is in process...");
            Thread.Sleep(2000);
            Console.WriteLine("Body has been tuned up.");

        }

        public override void ServiceVehicle()
        {
            base.ServiceVehicle();
            this.TuneUpBody();
            Console.WriteLine();
        }
    }
}
