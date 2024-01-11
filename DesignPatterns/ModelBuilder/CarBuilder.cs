using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilder
{
    /// <summary>
    /// Abstract class for CarBuilding
    /// </summary>
    public abstract class CarBuilder
    {

        public string Brand = "Ford";
        public string Color = "Red";
        public string Model = "Mustang";
        public int Year = DateTime.Now.Year;

        public abstract CarBuilder SetBrand(string brand);

        public abstract CarBuilder SetColor(string color);

        public abstract CarBuilder SetModel(string model);

        public abstract CarBuilder SetYear(int year);

        // public abstract CarBuilder SetXYZ(Type t) 
        // ...

        public Car Build()
        {
            return new Car(Color, Brand, Model, Year);
        }
    }
}