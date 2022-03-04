using FactoryPattern;

var burgerFactory = new BurgerFactory();

var burger = burgerFactory.Create(400);
if (burger != null)
{
    Console.WriteLine(burger);
}
else
{
    Console.WriteLine("Oh, nothing to eat for me today :(");
}

Console.ReadKey();