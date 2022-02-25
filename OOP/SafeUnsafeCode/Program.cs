using System;

namespace SafeUnsafeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sum = 0; //0-255
            Console.Write("Input new Number...");
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                try
                {
                    checked
                    {
                        sum += sbyte.Parse(input);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("!!!Sorry your number exceeded byte range!!!");
                }

                Console.WriteLine("New Sum: " + sum);
                Console.WriteLine(new string('=', 15));

                Console.Write("Input new Number...");
                input = Console.ReadLine();
            }



            //int a = int.MinValue;
            //int b = a - 1;

            //Console.WriteLine(b);
        }
    }
}
