using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.DecoratorDesign.Decorators
{
    // IS-A
    public abstract class ToppingsDecorator : Pizza
    {
        // HAS-A
        public Pizza pizza;
    }
}
