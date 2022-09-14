using FactoryDesignPattern.FactoryDesign;
using FactoryDesignPattern.FactoryDesign.Factory;
using System;

namespace FactoryDesignPattern
{
    public class Program
    {
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
