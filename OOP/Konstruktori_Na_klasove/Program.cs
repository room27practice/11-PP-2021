using System;

namespace Konstruktori_Na_klasove
{
    class Program
    {
        static void Main()
        {
            var test1 = new Person();
            test1.Age = 7;

            var test2 = new Person(9);
            Console.WriteLine(test2.Age);
            test2 = new Person();


            var a = new[] { new Person(), new Person(2) };
            a = new Person[4];

            var test3 = new Person("Djani", 17);
        }
    }

    //~Person()
    //{
    //    Console.WriteLine($"Zashto me iztri, Moqt age beshe setnat na {Age}");
    //}

    //public Person()
    //{
    //    Scars = new List<Scars>();
    //}

    public class Person
    {
        static Person() // Статичен конструктор активира се веднъж 
        {
            Console.WriteLine("Pusnahme statichniq konstruktor.");
        }

        public Person() // НЕСтатичен конструктор активира се веднъж 
        {

        }
    
        public Person(string name, int age) : this(age)
        {
            Console.WriteLine("Ima ime " + name);
        }
        public Person(int age)
        {
            if (age > 0 && age < 105)
            {
                Age = age;
            }
        }
        public int Age { get; set; }
    }
    // public List<Scars> Scars { get; set; }

    public class Scars
    {
    }
}
