using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, double volume, string fuelType, DateTime year, string type, int price) : base(brand, model, volume, fuelType, year, price)
        {
            Type = type;
        }

        public string Type { get; set; }
    }
}
