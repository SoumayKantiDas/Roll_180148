
using System;
using System.Collections.Generic;
using System.Text;
namespace Roll_180148
{
    interface ICar
    {
        void GetDetails(string color, int price, int engine, string fueltype);
        bool Travleling();
        bool stop();
        void Travelled(int miles);
    }
}
