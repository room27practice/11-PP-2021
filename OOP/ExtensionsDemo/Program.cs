using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 22, 25 };
            List<int> resultEven = nums.GetEvenEx();
            //NumberMaster.GetEven(nums);

            Console.WriteLine(string.Join("; ", resultEven));


            List<int> resultOdd = nums.GetOddEx();
            // NumberMaster.GetOdd(nums);

            Console.WriteLine(string.Join("; ", resultOdd));


            Console.WriteLine(new string('=', 30));


            var halfNumbers = nums.GetHalf();

            Console.WriteLine(string.Join("; ", halfNumbers));

            string[] names = { "John", "James", "Johnatan", "Jeremiah", "Jerome", "Jack" };

            var halfNames = names.GetHalf();
            Console.WriteLine(string.Join("; ", halfNames));

            var monkeys = new Monkey[]
            {
                new Monkey("ChimChim", 3,4),
                new Monkey("ChupaMunk", 7,4),
                new Monkey("ChupaChups", 1,4),
                new Monkey("Urko", 8,4),
                new Monkey("Urko-Fazera", 5,4),
                new Monkey("Koko", 9,4),
                new Monkey("Shanel", 7,4),
                new Monkey("Rikardo", 2,7.3)
            };





            List<Monkey> halfMonkeys = monkeys.GetHalf();
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(string.Join(Environment.NewLine, halfMonkeys));


            string imput = Console.ReadLine();
            double number = double.Parse(imput);
            double number2 = imput.ToDouble();

            Console.WriteLine(new string('=', 30));
            Console.WriteLine(monkeys[0].GetDetailedMonkeyInfo("Pavian"));

        }
    }
}
