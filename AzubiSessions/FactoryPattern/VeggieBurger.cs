namespace FactoryPattern
{
    public class VeggieBurger : Burger
    {
        public VeggieBurger() : base("Veggie burger", 200)
        {
        }

        public override string[] GetStack()
        {
            return new[] { "Top bun", "Tomato", "Mushrooms", "Lettuce", "Bottom bun" };
        }
    }
}
