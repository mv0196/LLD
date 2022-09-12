using StrategyDesignPattern.Strategy;

namespace StrategyDesignPattern
{
    public class LuxuryVehicle : Vehicle
    {
        public LuxuryVehicle() : base(new LuxuryDriveStrategy())
        { }
    }
}
