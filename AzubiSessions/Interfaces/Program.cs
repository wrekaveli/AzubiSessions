using Interfaces;

var square = new Square(3);
var rectangle = new Rectangle(2, 4);
var triangle = new Triangle(5);

IPolygon[] polygons = { square, rectangle, triangle };

foreach (IPolygon polygon in polygons)
{
    Console.WriteLine($"The area of this polygon is: {polygon.CalculateArea()}");
    Console.WriteLine($"The perimeter of this polygon is: {polygon.CalculatePerimeter()}");
}

Console.ReadKey();