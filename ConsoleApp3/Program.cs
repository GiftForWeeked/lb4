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
            Person person1 = new Person("John");
            ;
            Car car1 = new Car("Toyota", "Camry", 2.5, "Gasoline", new DateTime(2020, 1, 1), 4);
            Motorcycle bike1 = new Motorcycle("Harley-Davidson", "Sportster", 1.2, "Gasoline", new DateTime(2015, 1, 1), "Cruiser");

            person1.AddVehicle(car1);
            person1.AddVehicle(bike1);

            Console.WriteLine($"Person: {person1.Name}");
            foreach (var vehicle in person1.Vehicles)
            {
                Console.WriteLine("--------------");
                if (vehicle is Car)
                {
                    car1.DisplayInfo();
                }
                else if (vehicle is Motorcycle)
                {
                    bike1.DisplayInfo();
                }
            }

            person1.RemoveVehicle(bike1);
            person1.RemoveVehicle(car1);
            Console.ReadKey();
        }
    }
}