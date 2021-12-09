using System;
using System.Collections.Generic;
using System.Linq;

namespace TyreJugler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
           
            Manufacturer producer1 = new Manufacturer() { Name = "GoodYear", PhoneNumber = "+376834572902" };
            Manufacturer producer2 = new Manufacturer() { Name = "Michelin", PhoneNumber = "+376034500902", Email = "michelin@gmail.com" };
            producer1.Email = "good_year@yahoo.com";


            var test1 = new Tyre("Michelin","Spring",false,54);

            Tyre leftBackTyre = new Tyre("Kauchuk","All Seasons",false, 20);

            var tyres = new List<Tyre>()
            {
                new Tyre("Kauchuk","All Seasons",false, 20),
                new Tyre("Plastmasa","Winter",true, 30),
                new Tyre("Plastmasa","Winter",true, 30),
                new Tyre("Kauchuk","All Seasons",false, 20),
                new Tyre("Kauchuk","All Seasons",false, 20),
                new Tyre("Kauchuk","All Seasons",false, 20),
            };



            Tyre rightBackTyre = new Tyre()
            {
                Manufacturer = producer2,
                IsWorn = false,
                Season = "Summer",
                MaxPressureBars = 30,
                Material = "Guma"
            };
            Tyre rightFrontTyre = new Tyre()
            {
                Manufacturer = new Manufacturer() { Name = "Continental", PhoneNumber = "+999999999", Email = "continental@abv.bg" },
                Season = "Winter",
                MaxPressureBars = 15,
                Material = "Plastic"
            };


        //    Tyre[] tyres = { leftBackTyre, rightFrontTyre, rightBackTyre ,
        //        new Tyre()
        //    {
        //        Manufacturer = producer1,
        //        Season = "Spring",
        //        MaxPressureBars = 8,
        //        Material = "Wood"
        //    }
        //};

            foreach (Tyre item in tyres.OrderByDescending(x=>x.MaxPressureBars).Where(x=>x.MaxPressureBars>10))
            {
                Console.WriteLine($"Tyre made by {item.Manufacturer.Name}. Has Maximum Pressure of {item.MaxPressureBars} and is made of {item.Material}");
            }

        }
    }
}
