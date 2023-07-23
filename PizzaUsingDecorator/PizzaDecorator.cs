using System;
namespace PizzaUsingDecorator
{
	public abstract class PizzaDecorator: IPizza
	{
		public IPizza wrappedPizza;
		public PizzaDecorator(IPizza pizza)
		{
			wrappedPizza = pizza;
		}

		public virtual string display()
		{
			return wrappedPizza.display();
		}
        public virtual double getCost()
		{
			return wrappedPizza.getCost();
		}
        public virtual int getMakingTimeInSeconds()
		{
			return wrappedPizza.getMakingTimeInSeconds();
		}
    }
}

