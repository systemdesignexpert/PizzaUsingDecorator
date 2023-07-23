using System;
namespace PizzaUsingDecorator
{
	public interface IPizza
	{
		public double getCost();
		public string display();
		public int getMakingTimeInSeconds();
	}
}

