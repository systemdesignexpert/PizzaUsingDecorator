using System;
namespace PizzaUsingDecorator
{
	public class CheezeBurstDecorator: PizzaDecorator
	{
        public CheezeBurstDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string display()
        {
            return base.display() + ", Cheeze Burst";
        }

        public override double getCost()
        {
            return base.getCost() + 50.0;
        }

        public override int getMakingTimeInSeconds()
        {
            return base.getMakingTimeInSeconds() + 100;
        }
    }
}

