using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, double volume, string fuelType, DateTime year, int numberOfDoors,int price) : base(brand, model, volume, fuelType, year, price)
        {
            NumberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get; set; }
    }
}
