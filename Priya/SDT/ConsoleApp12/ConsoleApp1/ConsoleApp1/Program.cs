using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum MyChoices
    {
        Apples, Pears, Grapes
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We went to the market");
            var values = Enum.GetValues(typeof(MyChoices));
            decimal total = 0;
            foreach(MyChoices choice in values)
            {
                Console.WriteLine("We bought {0}", choice);
                decimal weight = GetValue("How many kilos? ");
                if (weight != 0)
                {
                    decimal price = GetValue("At which price? ");
                    decimal amount = price * weight;
                    Console.WriteLine("We bought {0} and spent {1} dollars", choice, amount.ToString("c"));
                    total += amount;
                }
            }
            Console.WriteLine("WE spent in total: {0}", total.ToString("c"));
        }

        static decimal GetValue(string prompt)
        {
            string valueString = string.Empty;
            decimal value = 0;
            do
            {
                Console.Write(prompt);
                valueString = Console.ReadLine();
            } while (!decimal.TryParse(valueString, out value));
            return value;
        }
    }
}
