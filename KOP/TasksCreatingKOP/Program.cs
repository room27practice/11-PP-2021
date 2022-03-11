using System;
using System.Threading;
using System.Threading.Tasks;

namespace TasksCreatingKOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // PrintStatus();
            //  Task t1 = new Task(()=> PrintStatus(0.5));
            //  t1.Start();


            //  CalculateNumbers();
            //  Console.WriteLine("Produljavame s neshtata");
            ////  t1.Wait();
            ///

            Task t1 = new Task(() => CalculateNumbers());
            t1.Start();

            PrintStatus(0.5);
            Console.WriteLine("Produljavame s neshtata");
            t1.Wait();
        }

        public static void CalculateNumbers()
        {
            string opt = String.Empty;
            while (opt != "end")
            {
                Console.WriteLine("Choose option?");
                Console.WriteLine("1 - Decimal To Bynary");
                Console.WriteLine("2 - Bynary To Decimal");
                Console.WriteLine("End - Exit");
                opt = Console.ReadLine().ToLower();// => End END end
                if (opt == "1")
                {
                    ConvertDecimalToBynary();
                }
                if (opt == "2")
                {
                    ConvertBynaryToDecimal();
                }
                Console.WriteLine(new String('-', 25));
            }
            Console.WriteLine("Goodbye");

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




        public static void PrintStatus(double timeFor1PercentSeconds = 1)
        {
            int readyness = 0;
            while (readyness < 100)
            {
                readyness++;
                Thread.Sleep((int)(timeFor1PercentSeconds * 1000));
                if (readyness % 5 == 0)
                {
                    Console.WriteLine($"Update {readyness}% completed :)");
                }
            }

            Console.WriteLine("Task Finished");
        }



    }
}