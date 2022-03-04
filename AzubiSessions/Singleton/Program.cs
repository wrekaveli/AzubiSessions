using Singleton;

var s1 = RealSingleton.GetInstance();
var s2 = RealSingleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Yeah, same instance of object.");
}

var f1 = new NoSingleton();
var f2 = new NoSingleton();

if (f1 != f2)
{
    Console.WriteLine("Yeah, not the same instance of object.");
}

Console.ReadKey();
