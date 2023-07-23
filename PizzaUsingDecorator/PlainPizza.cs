using System;
namespace PizzaUsingDecorator
{
	public class PlainPizza: IPizza
	{
		public PlainPizza()
		{
		}

        public  string display()
        {
            return "Plain Pizza";
        }

        public  double getCost()
        {
            return 100.0;
        }

        public  int getMakingTimeInSeconds()
        {
            return 300;
        }
    }
}

