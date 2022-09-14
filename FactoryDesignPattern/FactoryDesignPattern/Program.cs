using FactoryDesignPattern.FactoryDesign;
using FactoryDesignPattern.FactoryDesign.Factory;
using System;

namespace FactoryDesignPattern
{
    public class Program
    {
        //https://docs.google.com/document/d/1O2MSNIC_egBLhLJsiRng2XfBvKpyk0Mp_fd-qk0e47A/edit
        //https://www.youtube.com/watch?v=7g9S371qzwM&list=PL6W8uoQQ2c61X_9e6Net0WdYZidm7zooW&index=5
        //https://refactoring.guru/design-patterns/factory-method
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            IShape shape = factory.GetShape("circle");
            shape.Draw();

            shape = factory.GetShape("square");
            shape.Draw();

            shape = factory.GetShape("rectangle");
            shape.Draw();
        }
    }
}
