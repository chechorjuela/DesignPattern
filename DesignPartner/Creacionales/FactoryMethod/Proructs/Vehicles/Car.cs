using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Vehicles.Proructs
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is drive");
        }

        public void Start()
        {
            Console.WriteLine("Car is start");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stop");
        }

    }
}