﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Objects
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, double volume, string fuelType, DateTime year, int numberOfDoors) : base(brand, model, volume, fuelType, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Объем двигателя: {Volume} л");
            Console.WriteLine($"Тип топлива: {FuelType}");
            Console.WriteLine($"Год выпуска: {Year.Year}");
            Console.WriteLine($"Количество дверей: {NumberOfDoors}");
        }
    }
}
