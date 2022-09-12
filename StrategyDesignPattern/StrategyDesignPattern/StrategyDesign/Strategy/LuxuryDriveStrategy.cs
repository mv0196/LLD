using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Strategy
{
    public class LuxuryDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Luxury Drive Strategy!!");
        }
    }
}
