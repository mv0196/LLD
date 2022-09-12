using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Strategy
{
    public class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Normal Drive Strategy!!");
        }
    }
}
