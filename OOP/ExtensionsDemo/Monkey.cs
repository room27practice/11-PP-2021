namespace ExtensionsDemo
{

    public class Monkey
    {
        public Monkey(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public double Weight { get; set; }

        public override string ToString()
        {
            return $"I am monkey called {Name}. And I am {Age} old.";
        }
    }
}
