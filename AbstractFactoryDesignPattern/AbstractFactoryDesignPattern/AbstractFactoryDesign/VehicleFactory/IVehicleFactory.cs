using AbstractFactoryDesignPattern.AbstractFactoryDesign.Vehicle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryDesign.VehicleFactory
{
    internal interface IVehicleFactory
    {
        IVehicle GetVehicle(string brand);
    }
}
