using System;
using System.Linq;

namespace Stack_And_Heep
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Smartphone("Nokia");
            Smartphone b = a;

            b.Brand = "Vodafone";
            Console.WriteLine(a.Brand);

            int c = 5;
            int d = c;
            d = 9;
            Console.WriteLine(c);

            int[] numbers = { 1, 2, 3, 4 };
            int[] doubledNumbers = PureDoubleNumbersInArray(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ", doubledNumbers));
        }

        private static int[] DoubleNumbersInArray(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }

            return numbers;
        }
        private static int[] PureDoubleNumbersInArray(int[] numbers)
        {
            numbers = numbers.ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }
    }

    class Smartphone
    {
        public Smartphone(string brand)
        {
            Brand = brand;
        }

        public string Brand { get; set; }

    }


}
