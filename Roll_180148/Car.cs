using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace Roll_180148
{
    public class Car : Vehicle
    {
        protected bool IncreaseGear { get; set; }
        public Car()
        {
        }
        public Car(bool increaseGear)
        {
            IncreaseGear = increaseGear;
        }
        public Car(bool increaseGear, int wheel, bool brake) : base(wheel, brake)
        {
            IncreaseGear = increaseGear;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Can increase gear {IncreaseGear} How many Wheel {Wheel} Can use break {Brake}");
        }
    }
}
