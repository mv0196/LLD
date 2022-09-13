using DecoratorDesignPattern.DecoratorDesign;
using DecoratorDesignPattern.DecoratorDesign.Decorators;
using System;

namespace DecoratorDesignPattern
{
    internal class Program
    {
        //https://docs.google.com/document/d/1O2MSNIC_egBLhLJsiRng2XfBvKpyk0Mp_fd-qk0e47A/edit
        //https://www.youtube.com/watch?v=w6a9MXUwcfY&list=PL6W8uoQQ2c61X_9e6Net0WdYZidm7zooW&index=4
        //https://refactoring.guru/design-patterns/decorator
        static void Main(string[] args)
        {
            Pizza pizza = new ExtraCheeze(new Margherita());

            Console.WriteLine($"Pizza Cost: {pizza.Cost()}");

            pizza = new Mushroom(pizza);
            Console.WriteLine($"Pizza Cost: {pizza.Cost()}");
        }
    }
}
