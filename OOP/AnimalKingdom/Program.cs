using AnimalKingdom.Model;
using System;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDayMonkey = DateTime.Now;
            birthDayMonkey.AddDays(-500);


            Shimpanzee monkey1 = new Shimpanzee("Nemo", birthDayMonkey, 40.5, 8, true);
            Shimpanzee monkey2 = new Shimpanzee("Roki", birthDayMonkey.AddDays(-100), 52.7, 10, false);
            
  
              

            Console.WriteLine(Mammal.LifeSpan.Days);

            Console.WriteLine(monkey2.ToString());

        }
    }
}
