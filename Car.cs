using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphysmTask1
{
   internal class Car : Vehicle
    {
       

        //FuelCapacity ,CurrentFuel, FuelFor1km
        public int FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }

        public Car(string brand, string color, double millage, int fuelcapacity, double currentFuel, double fuelFor1km) : base(brand, color, millage)
        {
            FuelCapacity = fuelcapacity;
            CurrentFuel = currentFuel;
            FuelFor1km = fuelFor1km;
        }
        public override void Drive(double a)
        {
            if(CurrentFuel > a * FuelFor1km)
            {
                CurrentFuel = CurrentFuel - (a * FuelFor1km);
                Millage +=(int) a;

            }
            else
            {
                Console.WriteLine("Benzin Yoxdur");
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Bakin Hecmi: {FuelCapacity} \nHazirki Benzin:{CurrentFuel} \n1Litre Yandirir {FuelFor1km}");
        }


    }
}
