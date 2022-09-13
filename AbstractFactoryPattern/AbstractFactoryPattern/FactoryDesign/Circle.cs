using System;

namespace AbstractFactoryPattern.FactoryDesign
{
    internal class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Printed a Circle!!");
        }
    }
}
