using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphysmTask1
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string  Color { get; set; }
        public double Millage { get; set; }

        public Vehicle(string brand, string color, double millage)
        {
            Brand = brand;
            Color = color;
            Millage = millage;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand} \nColor:{Color} \nMillage:{Millage}");
        }
        public abstract void Drive(double a);
        
       
    }
}
