using AbstractFactoryDesignPattern.AbstractFactoryDesign.Vehicle;

namespace AbstractFactoryDesignPattern.AbstractFactoryDesign.VehicleFactory
{
    internal class LuxuryVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(string brand)
        {
            IVehicle vehicle = null;
            brand = brand.ToLower();
            switch (brand)
            {
                case "mercedes":
                    vehicle = new Mercedes();
                    break;
                case "rollsroyce":
                    vehicle = new RollsRoyce();
                    break;
                default:
                    break;
            }
            return vehicle;
        }
    }
}
