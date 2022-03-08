using AsyncAwait;
using System.Diagnostics;

var sw = new Stopwatch();

sw.Start();

Breakfast.Prepare();
//await BreakfastAsync.PrepareAsync();

sw.Stop();

Console.WriteLine($"Preparing breakfast took {sw.ElapsedMilliseconds} ms");

Console.ReadKey();

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/#dont-block-await-instead