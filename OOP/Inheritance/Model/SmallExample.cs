using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Model
{
    class Program
    {
        //static void Main()
        //{
        //    Animal d1 = new Dog("Sharo", 3, "Chihuahauhauha");
        //    Dog d2 = new Dog("Baro", 2, "Pudel");
        //    List<Animal> things = new List<Animal>();
        //    things.Add(d1);
        //    things.Add(d2);
        //    foreach (Animal anim in things)
        //    {
        //        Console.WriteLine(anim.Name);
        //    }
        //}
    }
    public abstract class Animal
    {
        protected Animal(int age, string name) : this()
        {
            Age = age;
            Name = name;
        }
        protected Animal()
        {
            Things = new List<string>();
        }
        public int Age { get; set; }
        public string Name { get; set; }

        public List<string> Things { get; set; }

        public abstract string GetYourType();
    }

    public sealed class Dog : Animal
    {
        public Dog(string name, int age, string breed) : base(age, name)
        {
            Breed = breed;
        }

        public string Breed { get; set; }
        public void Bark()
        {
            Console.WriteLine("Woof woof");
        }
        public override string GetYourType()
        {
            return "Dog";
        }
    }

}
