using AbstractFactoryDesignPattern.AbstractFactoryDesign.Vehicle;

namespace AbstractFactoryDesignPattern.AbstractFactoryDesign.VehicleFactory
{
    internal class OrdinaryVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(string brand)
        {
            IVehicle vehicle = null;
            brand = brand.ToLower();
            switch (brand)
            {
                case "maruti":
                    vehicle = new Maruti();
                    break;
                case "hyundai":
                    vehicle = new Hyundai();
                    break;
                default:
                    break;
            }
            return vehicle;
        }
    }
}
