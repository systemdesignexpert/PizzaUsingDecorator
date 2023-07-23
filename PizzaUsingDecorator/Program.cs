// See https://aka.ms/new-console-template for more information
using PizzaUsingDecorator;

Console.WriteLine("Hello, World!");
IPizza pizza;

// make onion pizza

IPizza plainPizza = new PlainPizza();
pizza = new OnionToppingDecorator(plainPizza);

Console.WriteLine("ONION PIZZA");
Console.WriteLine(pizza.display());
Console.WriteLine("PIZZA COST = " + pizza.getCost());
Console.WriteLine("PIZZA TIME = " + pizza.getMakingTimeInSeconds());


// make tomato pizza
pizza = new TomatoToppingDecorator(plainPizza);

Console.WriteLine("TOMATO PIZZA");
Console.WriteLine(pizza.display());
Console.WriteLine("PIZZA COST = " + pizza.getCost());
Console.WriteLine("PIZZA TIME = " + pizza.getMakingTimeInSeconds());


// make onion and tomato pizza
// todo:

pizza = new TomatoToppingDecorator(new OnionToppingDecorator(new PlainPizza()));

Console.WriteLine("ONION and TOMATO PIZZA");
Console.WriteLine(pizza.display());
Console.WriteLine("PIZZA COST = " + pizza.getCost());
Console.WriteLine("PIZZA TIME = " + pizza.getMakingTimeInSeconds());



// make margharita pizza
pizza = new CheezeBurstDecorator(plainPizza);

Console.WriteLine("Margharita PIZZA");
Console.WriteLine(pizza.display());
Console.WriteLine("PIZZA COST = " + pizza.getCost());
Console.WriteLine("PIZZA TIME = " + pizza.getMakingTimeInSeconds());

// make farmhouse pizza
pizza = new VegetableToppingDecorator( new CheezeBurstDecorator(plainPizza));

Console.WriteLine("Farm house PIZZA");
Console.WriteLine(pizza.display());
Console.WriteLine("PIZZA COST = " + pizza.getCost());
Console.WriteLine("PIZZA TIME = " + pizza.getMakingTimeInSeconds());

// make chicken extravanganza pizza
pizza = new ChickenToppingDecorator( new VegetableToppingDecorator(new CheezeBurstDecorator(new PlainPizza())));

Console.WriteLine("chicken extravanganza pizza");
Console.WriteLine(pizza.display());
Console.WriteLine("PIZZA COST = " + pizza.getCost());
Console.WriteLine("PIZZA TIME = " + pizza.getMakingTimeInSeconds());

