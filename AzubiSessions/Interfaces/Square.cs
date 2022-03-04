namespace Interfaces
{
    public class Square : IPolygon
    {
        private readonly int _a;

        public Square(int a)
        {
            _a = a;
        }

        public double CalculateArea()
        {
            return _a * _a;
        }

        public double CalculatePerimeter()
        {
            return 4 * _a;
        }
    }
}
