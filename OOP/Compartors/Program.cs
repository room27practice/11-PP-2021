using System;
using System.Linq;

namespace Compartors
{
    class Program
    {
        static void Main()
        {
            var hero1 = new Hero("Johny Walker", 14, 20, 4);
            var hero2 = new Hero("Rickardo Patron", 10, 15, 20);
            var hero3 = new Hero("Horhe", 7, 7, 7);

            var hero5 = hero1.Clone() as Hero;
            hero5.Name = "Genadi";

            //var hero6 = hero1;
            //hero6.Name = "Genadi";

            if (hero1.CompareTo(hero2) < 0)
            {
                Console.WriteLine("Vtoriq geroi e po silen");
            }
            else if (hero1.CompareTo(hero2) > 0)
            {
                Console.WriteLine("Purviq geroi geroi e po silen");
            }
            else 
            {
                Console.WriteLine("Dvamata geroi sa ednakvo silni.");
            }

            Hero[] guild = new[] { hero1, hero2, hero3 };

            guild = guild.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join("; ", guild.Select(x => x.Name)));
        }
    }

    class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Age>other.Age) return 1;
            else if (this.Age < other.Age)   return -1;
            return 0;
        }
    }

    class Hero : ICloneable, IComparable<Hero>
    {
        public Hero(string name, double attack, double health, double defence)
        {
            Name = name;
            Attack = attack;
            Health = health;
            Defence = defence;
        }
        public string Name { get; set; }
        public double Attack { get; set; }
        public double Health { get; set; }
        public double Defence { get; set; }

        public object Clone()
        {
            return new Hero(Name + " copy", Attack, Health, Defence);
        }

        private double Evaluate(Hero hero) =>
                                hero.Attack * 3.5 + hero.Health * 3 + hero.Defence * 2;

        public int CompareTo(Hero opponent)
        {
            double myscore = Evaluate(this);  //4.53
            double opponentScore = Evaluate(opponent); //4.0

            if (myscore > opponentScore)
            {
                return 1;
            }
            else if (myscore < opponentScore)
            {
                return -1;
            }

            return 0;
        }
    }
}
