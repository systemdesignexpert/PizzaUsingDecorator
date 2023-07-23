using System;
namespace PizzaUsingDecorator
{
	public class TomatoToppingDecorator: PizzaDecorator
	{
        public TomatoToppingDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string display()
        {
            return base.display() + ", Tomato topping";
        }

        public override double getCost()
        {
            return base.getCost() + 20.0;
        }

        public override int getMakingTimeInSeconds()
        {
            return base.getMakingTimeInSeconds() + 15;
        }
    }
}

