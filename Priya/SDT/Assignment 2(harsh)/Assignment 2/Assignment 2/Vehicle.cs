using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Vehicle
    {
        private string manufacturer;
        private string model;
        private string type;
        private string yearOfManufacturing;

        public Vehicle(string manufacturer, string model, string type, string yearOfManufacturing)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.type = type;
            this.yearOfManufacturing = yearOfManufacturing;

        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string YearOfManufacturing
        {
            get { return yearOfManufacturing; }
            set { yearOfManufacturing = value; }
        }
        private void OilChange()
        {
            Console.WriteLine("Engine oil changing is in process...");
            Console.WriteLine("Engine oil has been changed.");

        }
        private void TuneUpEngine()
        {
            Console.WriteLine("Engine tuneup is in process...");
            Console.WriteLine("Engine has been tuned up.");

        }

        private void CleanUpTransmission()
        {
            Console.WriteLine("Transmission cleanup is in process...");
            Console.WriteLine("Transmission has been cleaned up.");

        }

        public void Display()
        {
            Console.WriteLine("Manufacturer:" + this.Manufacturer);
            Console.WriteLine("Model:" + this.Model);
            Console.WriteLine("Year of manufacturing:" + this.YearOfManufacturing);
            Console.WriteLine("Type:" + this.Type);
            Console.WriteLine();

        }
        public virtual void Services()
        {
            Console.WriteLine("\nService has been started:");
            this.Display();
            this.OilChange();
            this.TuneUpEngine();
            this.CleanUpTransmission();
        }
    }
}
