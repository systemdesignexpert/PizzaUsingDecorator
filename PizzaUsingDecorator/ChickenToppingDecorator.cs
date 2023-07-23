using System;
namespace PizzaUsingDecorator
{
	public class ChickenToppingDecorator: PizzaDecorator
	{
        public ChickenToppingDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string display()
        {
            return base.display() + ", Chicken Topping";
        }

        public override double getCost()
        {
            wra
            return base.getCost() + 50.0;
        }

        public override int getMakingTimeInSeconds()
        {
            return base.getMakingTimeInSeconds() + 50;
        }
    }
}

