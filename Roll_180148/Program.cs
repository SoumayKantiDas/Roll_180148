using System;
namespace Roll_180148
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(true, 4, true);
            car.GetDetails();
            Tata_Nexon tata = new Tata_Nexon(true, 4, true);
            tata.GetBrandName("Tata_Nexon");
            tata.GetDetails();
            tata.GetDetails("RED", 4524547, 1600, "petrol");
            tata.Travleling();
            tata.Travelled(45);
            tata.stop();
            Toyta_Car toyta = new Toyta_Car(true, 4, true);
            toyta.GetBrandName(" Toyta_Car");
            toyta.GetDetails();
            toyta.GetDetails("Black", 566524547, 2600, "petrol/octen");
            toyta.Travleling();
            toyta.Travelled(14655);
            toyta.stop();
        }
    }
}
