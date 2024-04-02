using FactoryMethod.FactoryMethod;
using FactoryMethod.Vehicles.Proructs;

namespace  FactoryMethod.Factories.vehicle
{
    public class MotorCicleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Motorcicle();
        }

    }
}