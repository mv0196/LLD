using System;

namespace FactoryDesignPattern.FactoryDesign
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Printed a Rectangle!!");
        }
    }
}
