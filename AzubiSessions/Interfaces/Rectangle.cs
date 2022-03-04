namespace Interfaces
{
    public class Rectangle : IPolygon

    {
        private readonly int _a;
        private readonly int _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public double CalculatePerimeter()
        {
            return 2 * _a + 2 * _b;
        }

        public double CalculateArea()
        {
            return _a * _b;
        }
    }
}
