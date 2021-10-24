using System;
using System.Collections.Generic;
using System.Text;
namespace Roll_180148
{
    public sealed class Tata_Nexon : Car, ICar, IBrand_Name
    {
        public Tata_Nexon(bool increaseGear, int wheel, bool brake) 
            : base(increaseGear, wheel, brake)
        {
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Can increase gear {IncreaseGear} How many Wheel {Wheel} Can use break {Brake}");
        }
        public string Brand { get; set; }
        public void GetBrandName(string brand)
        {
            Brand = brand;
            Console.WriteLine($"{Brand}");
        }
        private string Color { get; set; }
        private int Price { get; set; }
        private int Engine { get; set; }
        private string FuelType { get; set; }
        private bool isRunning { get; set; }
        public void GetDetails(string color, int price, int engine, string fueltype)
        {
            Color = color;
            Price = price;
            Engine = engine;
            FuelType = fueltype;
            Console.WriteLine($"{Color},{Price},{Engine},{FuelType}");
        }
        public bool Travleling()
        {
            isRunning = true;
            Console.WriteLine("Tata nexon is traveling");
            return isRunning;
        }
        public bool stop()
        {
            isRunning = false;
            Console.WriteLine("The car is not running");
            return isRunning;
        }
        public void Travelled(int miles)
        {
            if (isRunning)
                Console.WriteLine("Tata_Nexon: " + miles);
            else
                Console.WriteLine("Car is not running");
        }
    }
}
