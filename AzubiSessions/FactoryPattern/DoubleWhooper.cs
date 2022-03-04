namespace FactoryPattern
{
    public class DoubleWhooper : Burger
    {
        public DoubleWhooper() : base("Double Whooper", 800)
        {
        }

        public override string[] GetStack()
        {
            return new[] { "Top bun", "Lettuce", "Tomato", "Onions", "Prickles", "Beef", "Bacon", "Beef", "Bottom bun" };
        }
    }
}
