using System;

namespace AbstractFactoryPattern.FactoryDesign
{
    internal class  Square: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Printed a Square!!");
        }
    }
}
