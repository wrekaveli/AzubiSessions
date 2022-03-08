namespace Extensions
{
    public static class Extensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool IsGreaterThan(this int number, int otherNumber)
        {
            return number > otherNumber;
        }
    }
}
