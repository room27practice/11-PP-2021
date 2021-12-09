using Inheritance.Model;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {

            // var doggy = new Dog(6);
            #region inheritanceAbstractDemo    
            BaseParent t1 = new Tuhla(1, TuhlaSize.chetvorka, Materials.keramic, 23.4);
            Tuhla t2 = new Tuhla(2, TuhlaSize.chetvorka, Materials.keramic, 23.4);
            BaseParent b1 = new Diubel(4, 13.4);

            t1.GiveBaseInfo();
            t2.GiveBaseInfo();
            b1.GiveBaseInfo();

            //t2.Delete();
            //b1.Delete();
            t2.IsDeleted = false;
            t2.IsDeleted = false;
            t2.IsDeleted = false;
            t2.IsDeleted = false;
            t2.IsDeleted = false;


            List<BaseParent> col = new List<BaseParent>();
            col.Add(t1);
            col.Add(t2);
            col.Add(b1);

            List<Tuhla> col2 = new List<Tuhla>();
            //col2.Add(t1);
            //col2.Add(t2);
            //col2.Add(b1);

            Tuhla exp1 = t1 as Tuhla;
            Console.WriteLine(exp1.Size);
            Tuhla exp2 = b1 as Tuhla;
            if (exp2 != null)
            {
                Console.WriteLine(exp2.Size);
            }
            else
            {
                Console.WriteLine("Sorry no casting...");
            }

            #endregion

            //Animal t1 = new Animal("Marko");
            //Dog t2 = new Dog("sharo");
            //t2.Breed = "San Bernar";
            //Duck t3 = new Duck();
            //Duck t4 = new Duck();

            //t3.Breed = "Niskoletqshta";
            //t2.Weight = 200;

            //List<Animal> animals = new List<Animal>();
            //animals.Add(t2);
            //animals.Add(t3);
            //animals.Add(t1);
            //Console.WriteLine(((Dog)animals[1]).TailLength);
        }
    }

    public class Test : Object
    { }

    public class Animal
    {
        protected int EyeCount;

        public Animal()
        {
            Console.WriteLine("Bezparametrichen konstruktor ot animal se vkliuchi.....");
        }
        public Animal(string nme) : this()
        {
            Console.WriteLine("Parametrichen konstruktor ot animal se vkliuchi.....");
            Name = nme;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
    }

    public class Dog : Animal
    {
        public Dog(int a) : base("rex")
        {
            Console.WriteLine("Magichnoto chislo e {0}", a);
        }
        public Dog(string nme) : base(nme)
        {
            Weight = 0.5;
        }

        public void Bark()
        {
            Console.WriteLine("Woff Woff");
            Console.WriteLine(Breed);
        }
        public double TailLength { get; set; } = 99.2;
    }


    public class Duck : Animal
    {
        public Duck() : base("kvaklio")
        {
            Weight = 0.1;
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}