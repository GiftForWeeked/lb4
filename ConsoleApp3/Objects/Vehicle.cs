using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Volume { get; set; }
        public string FuelType { get; set; }
        public DateTime Year { get; set; }
    }
}

