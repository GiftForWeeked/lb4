using ConsoleApp3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person { Name = "John" };
            Car car1 = new Car { Brand = "Toyota", Model = "Crown", NumberOfDoors = 4, Year = Convert.ToDateTime(2010), Volume = 52, FuelType = "Gasoline" };
            Motorcycle bike1 = new Motorcycle { Brand = "Harley-Davidson", Model = "Sport Glide", Year = Convert.ToDateTime(2021), Volume = 18.9, FuelType = "Gasoline", Type = "Sportster" };

            person1.AddVehicle(car1);
            person1.AddVehicle(bike1);

            Console.WriteLine($"Person: {person1.Name}");
            foreach (var vehicle in person1.Vehicles)
            {
                Console.WriteLine($"Brand: {vehicle.Brand}, Model: {vehicle.Model}");
                if (vehicle is Car)
                {
                    var car = (Car)vehicle;
                    Console.WriteLine($"Number of doors: {car.NumberOfDoors}");
                }
                else if (vehicle is Motorcycle)
                {
                    var bike = (Motorcycle)vehicle;
                    Console.WriteLine($"Type: {bike.Type}");
                }
            }

            person1.RemoveVehicle(bike1);
            person1.RemoveVehicle(car1);
        }
    }
}