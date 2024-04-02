using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Vehicles.Proructs
{
    public class Motorcicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("MotorCicle is drive");
        }

        public void Start()
        {
            Console.WriteLine("MotorCicle is Start");
        }

        public void Stop()
        {
            Console.WriteLine("MotorCicle is Stop");
        }

    }
}