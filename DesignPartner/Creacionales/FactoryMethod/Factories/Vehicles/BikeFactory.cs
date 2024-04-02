using FactoryMethod.FactoryMethod;
using FactoryMethod.Vehicles.Proructs;

namespace FactoryMethod.Factories.vehicle
{
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
           return new Bike();
        }

    }
}