using System;

namespace FactoryDesignPattern.FactoryDesign
{
    internal class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Printed a Circle!!");
        }
    }
}
