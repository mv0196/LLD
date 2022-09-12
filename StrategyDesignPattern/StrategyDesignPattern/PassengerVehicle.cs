using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new NormalDriveStrategy())
        { }
    }
}
