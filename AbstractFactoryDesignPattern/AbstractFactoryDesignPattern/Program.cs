using AbstractFactoryDesignPattern.AbstractFactoryDesign.MainFactory;
using AbstractFactoryDesignPattern.AbstractFactoryDesign.Vehicle;
using AbstractFactoryDesignPattern.AbstractFactoryDesign.VehicleFactory;
using System;

namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        //https://docs.google.com/document/d/1O2MSNIC_egBLhLJsiRng2XfBvKpyk0Mp_fd-qk0e47A/edit
        //https://www.youtube.com/watch?v=7g9S371qzwM&list=PL6W8uoQQ2c61X_9e6Net0WdYZidm7zooW&index=5
        //https://refactoring.guru/design-patterns/abstract-factory
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            IVehicleFactory vehicleFactory = factory.GetVehicleFactory("luxury");

            IVehicle vehicle = vehicleFactory.GetVehicle("rollsroyce");
            Console.WriteLine($"Cost: {vehicle.cost()}");


            vehicle = vehicleFactory.GetVehicle("mercedes");
            Console.WriteLine($"Cost: {vehicle.cost()}");


            //=====================================================
            
            vehicleFactory = factory.GetVehicleFactory("ordinary");

            vehicle = vehicleFactory.GetVehicle("maruti");
            Console.WriteLine($"Cost: {vehicle.cost()}");


            vehicle = vehicleFactory.GetVehicle("hyundai");
            Console.WriteLine($"Cost: {vehicle.cost()}");


        }
    }
}
