using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class Vehicle
    {
        IDriveStrategy driveStrategy;
        public Vehicle( IDriveStrategy driveStrategy)
        {
            this.driveStrategy = driveStrategy;
        }

        public void Drive()
        {
            this.driveStrategy.Drive();
        }
    }
}
