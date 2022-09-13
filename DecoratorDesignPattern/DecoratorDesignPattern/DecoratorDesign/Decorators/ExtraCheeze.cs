namespace DecoratorDesignPattern.DecoratorDesign.Decorators
{
    public class ExtraCheeze : ToppingsDecorator
    {
        public ExtraCheeze(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int Cost()
        {
            // Returning cost with case of base pizza  + toppings
            return this.pizza.Cost() + 10;
        }
    }
}
