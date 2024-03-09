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
        public int PriceFleet()
        {
            int totalValue = 0;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle is Car)
                {
                    var car = (Car)vehicle;
                    totalValue += car.Price;
                }
                else if (vehicle is Motorcycle)
                {
                    var bike = (Motorcycle)vehicle;
                    totalValue += bike.Price;
                }
            }

            return totalValue;
        }
        public void MostExp()
        {
            decimal totalPrice = 0;
            string name = string.Empty;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle is Car)
                {
                    var car = (Car)vehicle;
                    if (totalPrice < car.Price)
                    {
                        totalPrice = car.Price;
                        name = car.Brand + ' ' + car.Model;
                    }
                }
                else if (vehicle is Motorcycle)
                {
                    var bike = (Motorcycle)vehicle;
                    if (totalPrice < bike.Price)
                    {
                        totalPrice = bike.Price;
                        name = bike.Brand + ' ' + bike.Model;
                    }
                }
            }

            Console.WriteLine($"Самый дорогой транспорт: {name}, стоймостью: {totalPrice}");
        }
    }
}
