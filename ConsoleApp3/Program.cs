using ConsoleApp3.Objects;
using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John");
            
            Car car1 = new Car("Toyota", "Camry", 2.5, "Gasoline", new DateTime(2020, 1, 1), 4, 4300000);
            Car car2 = new Car("Toyota", "Camry", 2.5, "Gasoline", new DateTime(2024, 1, 1), 4, 6599999);
            Car car3 = new Car("Toyota", "Corolla", 2, "Gasoline", new DateTime(2020, 1, 1), 4, 2545000);
            Motorcycle bike1 = new Motorcycle("Harley-Davidson", "Sportster", 1.2, "Gasoline", new DateTime(2015, 1, 1), "Cruiser", 659000);
            Motorcycle bike2 = new Motorcycle("Ducati", "HyperMotard", 1, "Gasoline", new DateTime(2024, 1, 1), "Pitbike", 1999000);
            person1.AddVehicle(bike1);
            person1.AddVehicle(bike2); 
            person1.AddVehicle(car1);
            person1.AddVehicle(car3);
            person1.AddVehicle(car2);

            Console.WriteLine($"Person: {person1.Name}");
            foreach (var vehicle in person1.Vehicles)
            {
                Console.WriteLine("--------------");
                if (vehicle is Car)
                {
                    var car = (Car)vehicle;
                    Console.WriteLine($"Марка: {car.Brand}");
                    Console.WriteLine($"Модель: {car.Model}");
                    Console.WriteLine($"Объем двигателя: {car.Volume} л");
                    Console.WriteLine($"Тип топлива: {car.FuelType}");
                    Console.WriteLine($"Год выпуска: {car.Year.Year}");
                    Console.WriteLine($"Количество дверей: {car.NumberOfDoors}");
                    Console.WriteLine($"Цена: {car.Price}");
                }
                else if (vehicle is Motorcycle)
                {
                    var bike = (Motorcycle)vehicle;
                    Console.WriteLine($"Марка: {bike.Brand}");
                    Console.WriteLine($"Модель: {bike.Model}");
                    Console.WriteLine($"Объем двигателя: {bike.Volume} л");
                    Console.WriteLine($"Тип топлива: {bike.FuelType}");
                    Console.WriteLine($"Год выпуска: {bike.Year.Year}");
                    Console.WriteLine($"Тип: {bike.Type}");
                    Console.WriteLine($"Цена: {bike.Price}");
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine($"Сумма автопарка: {person1.PriceFleet()}");
            Console.WriteLine("--------------");
            person1.MostExp();
            person1.RemoveVehicle(bike1);
            person1.RemoveVehicle(car1);

            Console.ReadKey();
        }
    }
}