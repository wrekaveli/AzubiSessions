
using Extensions;

string text = "This is a normal string.";
int number = 42;
int otherNumber = 100;

Console.WriteLine("Without extensions:");
Console.WriteLine(CountWords(text));
Console.WriteLine(GetIsGreater(number, otherNumber));

Console.WriteLine("With extensions:");
Console.WriteLine(text.WordCount());
Console.WriteLine(number.IsGreaterThan(otherNumber));

Console.ReadKey();

static int CountWords(string str)
{
    return str.Split(new[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
}

static bool GetIsGreater(int number, int otherNumber)
{
    return number > otherNumber;
}