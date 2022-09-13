namespace DecoratorDesignPattern.DecoratorDesign.Decorators
{
    public class Mushroom : ToppingsDecorator
    {
        public Mushroom(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int Cost()
        {
            // Returning cost with case of base pizza  + toppings
            return this.pizza.Cost() + 5;
        }
    }
}
