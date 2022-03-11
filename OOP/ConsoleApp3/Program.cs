using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConvertDecimalToBynary();
            // ConvertBynaryToDecimal();

            var res = BinaryToDecimal("101111");
            Console.WriteLine(res);
        }

        public static void ConvertDecimalToBynary()
        {
            Console.Write("Input Decimal Number: ");
            int number = int.Parse(Console.ReadLine());
            string result = "";

            while (number > 0)
            {
                result = number % 2 + result;
                number /= 2;
            }
            result += "b";
            Console.WriteLine("Result: " + result);
        }

        public static void ConvertBynaryToDecimal()
        {
            Console.Write("Input Bynary Number: ");
            string number = Console.ReadLine();
            number.Replace("b", "");             
            double result = 0;
            //"1011" - > 2^0 + 2^1 + 2^3
            double counter = 0.5d;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                counter *= 2;
                char digit = number[i];
                if (digit == '1')
                {
                    result += counter;
                }
            }

            Console.WriteLine("Result: " + result);
        }

        static int BinaryToDecimal(string binarno1)
        {
            int answer = 0;
            foreach (var n in binarno1)  //101111
            {
                answer = (n - '0') + answer * 2;
            }
            return answer;
        }


    }
}