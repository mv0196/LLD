using AbstractFactoryDesignPattern.AbstractFactoryDesign.VehicleFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryDesign.MainFactory
{
    // HAS-A IVehicleFactory
    internal class Factory
    {
        internal IVehicleFactory GetVehicleFactory(string category)
        {
            IVehicleFactory vehicleFactory = null;
            category = category.ToLower();
            switch (category)
            {
                case "luxury":
                    vehicleFactory = new LuxuryVehicleFactory();
                    break;
                case "ordinary":
                    vehicleFactory = new OrdinaryVehicleFactory();
                    break;
                default:
                    break;
            }
            return vehicleFactory;
        }
    }
}
