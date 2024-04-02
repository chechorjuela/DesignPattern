using FactoryMethod.FactoryMethod;

namespace  FactoryMethod.Factories.vehicle
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();

        public IVehicle OrderVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

            return vehicle;

        }
    }
}