using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Vehicles.Proructs
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is drive");
        }

        public void Start()
        {
            Console.WriteLine("Bike is start");
        }

        public void Stop()
        {
            Console.WriteLine("Bike is stop");
        }

    }
}