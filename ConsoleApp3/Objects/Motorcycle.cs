using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, double volume, string fuelType, DateTime year, string type) : base(brand, model, volume, fuelType, year)
        {
            Type = type;
        }

        public string Type { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Объем двигателя: {Volume} л");
            Console.WriteLine($"Тип топлива: {FuelType}");
            Console.WriteLine($"Год выпуска: {Year.Year}");
        }
    }
}
