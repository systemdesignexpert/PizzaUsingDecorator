using System;
namespace PizzaUsingDecorator
{
	public class OnionToppingDecorator: PizzaDecorator
	{
        public OnionToppingDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string display()
        {
            //wrappedPizza.display();
            return base.display() + ", Onion toppings";
        }

        public override double getCost()
        {
            return base.getCost() + 20.0;
        }

        public override int getMakingTimeInSeconds()
        {
            return base.getMakingTimeInSeconds() + 10;
        }
    }
}

