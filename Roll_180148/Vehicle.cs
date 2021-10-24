using System;
using System.Collections.Generic;
using System.Text;
namespace Roll_180148
{
    public abstract class Vehicle
    {
        protected int Wheel { get; set; }
        protected bool Brake { get; set; }
        public Vehicle()
        {
            Wheel = 4;
            Brake = true;
        }
        public Vehicle(int wheel, bool brake)
        {
            Wheel = wheel;
            Brake = brake;
        }
        public abstract void GetDetails();
    }
}
