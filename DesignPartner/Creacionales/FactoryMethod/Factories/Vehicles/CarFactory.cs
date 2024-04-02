using FactoryMethod.FactoryMethod;
using FactoryMethod.Vehicles.Proructs;

namespace  FactoryMethod.Factories.vehicle
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }

    }
}