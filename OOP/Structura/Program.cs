using System;

namespace Structura
{
    class Program
    {
        static void Main(string[] args)
        {
            #region primeri_1
            System.Console.WriteLine("nqkakuv string"); // Държавният клас
            Console.WriteLine("nqkakuv string"); // Моят клас

            var dog1 = new Dog() ;
            var dog2 = new Dog() { FullName = "Sharo" };

            dog1.FullName = "Genadi";

            Dog.SenseOfSmell = "Very Good";


            Donkey donkey = new Donkey();
            donkey.DoSomething();
            var fish1 = new Baracuda();
            var fish2 = new Makarel();
            #endregion

            var test1 = new Demo();
            test1.Name = "Balto";
            test1.Age = 15;
            Demo.Specie = "Humanoid";

        }

        class Demo
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public static string Specie { get; set; }
        }

    }
}