namespace FactoryPattern
{
    public class BurgerFactory
    {
        public Burger Create(int caloriesLeft)
        {
            if (caloriesLeft >= 800)
            {
                return new DoubleWhooper();
            } 
            else if (caloriesLeft < 800 && caloriesLeft >= 350)
            {
                return new CheeseBurger();
            }
            else if (caloriesLeft < 350 && caloriesLeft >= 200)
            {
                return new VeggieBurger();
            }

            return null;
        }
    }
}
