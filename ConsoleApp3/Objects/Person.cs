using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
            Vehicles = new List<Vehicle>();
        }
        public string Name { get; private set; }
        public List<Vehicle> Vehicles { get; private set; }
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }
    }
}
