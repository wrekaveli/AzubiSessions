namespace FactoryPattern
{
    public abstract class Burger
    {
        public int Calories { get; private set; }

        public string Name { get; private set; }

        public Burger(string name, int calories)
        {
            this.Name = name;
            this.Calories = calories;
        }

        public abstract string[] GetStack();

        public override string ToString()
        {
            return $"{this.Name} has {this.Calories} and contain is made of\n{string.Join('\n', this.GetStack())}";
        }
    }
}
