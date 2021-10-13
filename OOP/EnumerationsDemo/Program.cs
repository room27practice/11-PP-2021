using System;

namespace EnumerationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tyre1 = new Tyre();
            var input = Console.ReadLine();
            var en1 = Enum.Parse<Season>(input, true);


        
            //if (!Enum.TryParse<Season>(input, true, out en2))
            //{
            //    Console.WriteLine("Invalid season");
            //}
            Season s1 = Season.Summer;

            Season en2;
            Enum.TryParse(Console.ReadLine(), true, out en2);

            Console.WriteLine(en2.ToString());
            Console.WriteLine((int)en2);
            tyre1.Season = en2;
        }
    }

    class Tyre
    {
        public string Brand { get; set; }
        public Season Season { get; set; }
    }

    public enum Season
    {
        Default = 0,
        Summer = 1,
        Winter = 2,
        AllSeasons = 14
    }

    public enum Brand
    {
        Michelin = 0,
        GoodYear = 5,
        Continental = 8,
        Kenda = 9,

    }

    public enum Material
    {

        Kauchuk,      //0
        Plastic,      //1
        Microfiber,   //2
        AllSeasons,   //3
    }

}
