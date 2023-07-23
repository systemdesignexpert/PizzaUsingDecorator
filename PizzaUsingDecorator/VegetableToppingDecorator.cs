using System;
namespace PizzaUsingDecorator
{
    public class VegetableToppingDecorator : PizzaDecorator
    {
        public VegetableToppingDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string display()
        {
            return base.display() + ", Veg Toppings";
        }

        public override double getCost()
        {
            return base.getCost() + 30.0;
        }

        public override int getMakingTimeInSeconds()
        {
            return base.getMakingTimeInSeconds() + 50;
        }
    }
}

