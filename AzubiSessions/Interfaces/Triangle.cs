namespace Interfaces
{
    public class Triangle : IPolygon
    {
        private readonly int _a;

        public Triangle(int a)
        {
            _a = a;
        }

        public double CalculateArea()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(_a, 2);
        }

        public double CalculatePerimeter()
        {
            return _a * 3;
        }
    }
}
