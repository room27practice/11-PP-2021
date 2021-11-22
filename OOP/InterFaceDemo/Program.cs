using System;
using System.Collections.Generic;

namespace InterFaceDemo
{
    class Program
    {
        static void Main()
        {
            List<object> things = new List<object>();
            things.Add(new Dog(5, "sharo"));
            things.Add(new Human(30, "Nick", "web-dev"));

            List<INamable> named_things = new List<INamable>();
            things.Add(new Dog(5, "sharo1"));
            things.Add(new Human(30, "Nick1", "web-dev"));

            Console.WriteLine(named_things[0].Name);
            named_things[0].Name = "asdasd";
            named_things[0].Age = 2;


            PromotionService t1 = new PromotionService();
            INETProvider t2 = new PromotionService();
            ITVprovider t3 = new PromotionService();
            ITV_NETProvider t4 = new PromotionService();



        }
    }

    public interface INamable
    {
        string Name { get; set; }
        int Age { set; }
        int MaxAge { get; }   
    }

    public interface IWriteableSomething
    {
        string WriteSomething(string start_phrase);
    }

   public class Animal
    {
        public int MyProperty { get; set; }
    }

    public class Dog : Animal, INamable, IWriteableSomething
    {
        public Dog(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public int MaxAge { get; } = 12;

        public void Bark()
        {
            Console.WriteLine("Woof woof....");
        }
        public string WriteSomething(string start_phrase)
        {
            return start_phrase + "alabala";
        }
    }


    class Human : INamable
    {
        public Human(int age, string name, string jobPosition)
        {
            Age = age;
            Name = name;
            JobPosition = jobPosition;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string JobPosition { get; set; }
        public int MaxAge { get; } = 100;

        public void SayHello()
        {
            Console.WriteLine("Hello I am {0}. And I work as a {1}", Name, JobPosition);
        }

        public string WriteSomething(string start_phrase)
        {
            return start_phrase + "message";
        }
    }




}
