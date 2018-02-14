using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            Console.WriteLine("Welcome to Vehicle repair store! \n");
            char userChoice;
            do
            {
                Console.WriteLine("Choices:");
                Console.WriteLine("1. Add vehicle.");
                Console.WriteLine("2. Start service.");
                Console.WriteLine("3. View all vehicles.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter your choice:");
                userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                switch (userChoice)
                {
                    case '1':
                        //Console.Clear();
                        InputManufacturer:
                        Console.Write("Manufacturer:");
                        string manufacturer = Console.ReadLine();
                        //if (!ValidateString(manufacturer)) goto InputManufacturer;

                        InputModel:
                        Console.Write("Model:");
                        string model = Console.ReadLine();
                        //if (!ValidateString(model)) goto InputModel;

                        InputYear:
                        Console.Write("Year of manufacturing:");
                        string year = Console.ReadLine();
                        //if (!ValidateString(year)) goto InputYear;

                        InputChoices:
                        Console.WriteLine("Choices:");
                        Console.WriteLine("1. Car.");
                        Console.WriteLine("2. School Bus.");
                        Console.WriteLine("3. Pick up Truck.");
                        Console.WriteLine("4. Tractor.");
                        Console.WriteLine("0. Back.");

                        Console.Write("Vehicle Type:");
                        char vehicleType = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        switch (vehicleType)
                        {
                            case '1':
                                vehicles.Add(new Car(manufacturer, model, "Car", year));
                                break;

                            case '2':
                                vehicles.Add(new BusService(manufacturer, model, "Bus Service", year));
                                break;

                            case '3':
                                vehicles.Add(new Truck(manufacturer, model, "Truck", year));
                                break;

                            case '4':
                                vehicles.Add(new Tractor(manufacturer, model, "Tractor", year));
                                break;
                            case '0':
                                break;
                            default:
                                //InvalidInput();
                                goto InputChoices;
                        }
                        break;

                    case '2':
                        foreach (Vehicle v in vehicles)
                        {
                            v.Services();
                            
                        }
                        vehicles.Clear();
                        break;

                    case '3':
                        if (vehicles.Count == 0)
                        {
                            Console.WriteLine("No vehicles in the queue.");
                            break;
                        }

                        //Console.Clear();
                        foreach (Vehicle v in vehicles)
                        {
                            Console.WriteLine("\nVehicle Number:" + (vehicles.IndexOf(v) + 1));
                            v.DisplayVehicle();
                        }
                        break;

                }
            } while (userChoice != '0');
            Console.WriteLine("Thank you for using the repair shop application");
            Console.ReadKey();
        }
    }
}
