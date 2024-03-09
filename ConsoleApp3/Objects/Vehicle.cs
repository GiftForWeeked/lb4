using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    public abstract class Vehicle
    {
        public Vehicle(string brand, string model, double volume, string fuelType, DateTime year)
        {
            Brand = brand;
            Model = model;
            Volume = volume;
            FuelType = fuelType;
            Year = year;
        }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public double Volume { get; private set; }
        public string FuelType { get; private set; }
        public DateTime Year { get; private set; }
    }
}

