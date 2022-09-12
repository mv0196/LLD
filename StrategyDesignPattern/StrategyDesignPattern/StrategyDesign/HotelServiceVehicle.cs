using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern
{
    public class HotelServiceVehicle : Vehicle
    {
        public HotelServiceVehicle() : base(new LuxuryDriveStrategy())
        { }
    }
}
