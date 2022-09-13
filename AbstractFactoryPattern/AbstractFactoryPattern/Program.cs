using AbstractFactoryPattern.FactoryDesign;
using AbstractFactoryPattern.FactoryDesign.Factory;
using System;

namespace AbstractFactoryPattern
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
