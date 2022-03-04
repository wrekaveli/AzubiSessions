namespace FactoryPattern
{
    public class CheeseBurger : Burger
    {
        public CheeseBurger() : base("Cheese burger", 350)
        {
        }

        public override string[] GetStack()
        {
            return new[] { "Top bun", "Tomato", "Onion", "Cheese", "Beef", "Bottom bun" };
        }
    }
}
