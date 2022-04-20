using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TasksCreatingKOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PrintStatus();
            //#region OneProcessDemo                       
            //Task t1 = new Task(() => PrintStatus("Process 1", 0.5));
            //t1.Start();
            //CalculateNumbers();
            //Console.WriteLine("Produljavame s neshtata");
            //t1.Wait(); // Ако го няма няма да чака статусите да са стигнали 100%
            //#endregion

            #region TwoOrMoreProcessesDemo          
            List<Task> tasks = new List<Task>();
            tasks.Add( new Task(() => PrintStatus("Process 1", 0.5)));
            tasks.Add( new Task(() => PrintStatus("Process 2", 0.8)));
            tasks.Add(new Task(() => PrintStatus("Process 3", 1.0)));

            Task t1 = new Task(() => PrintStatus("Process 1", 0.5));
            t1.Start();
            //Действия с кода по основната нишка докато се изпълнява t
            TaskStatus st1 = t1.Status; // Връща енумерация със състоянието на асинхронния процес.
            t1.Wait(); // Основната нишка чака да приключи t и чак тогава продължава с кода под този ред.
       
            
            
            var taskA= Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello");
                }
            });

            var getSum1to10=new Task<int>(() =>
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    sum += i;
                    Thread.Sleep(1000);
                }
                return sum;
            });


            getSum1to10.Start();

            //getSum1to10.Wait();
            //Console.WriteLine(getSum1to10.Result);

            Console.WriteLine(getSum1to10.GetAwaiter().GetResult());
            
            foreach (var t in tasks)
            {
                t.Start();
            }

            CalculateNumbers();
            Console.WriteLine("Produljavame s neshtata");
            Task.WaitAll(tasks.ToArray());
            #endregion
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

        public static void PrintStatus(string name, double timeFor1PercentSeconds = 1)
        {
            int readyness = 0;
            while (readyness < 100)
            {
                readyness++;
                Thread.Sleep((int)(timeFor1PercentSeconds * 1000));
                if (readyness % 5 == 0)
                {
                    Console.WriteLine($"[{name}] Update {readyness}% completed :)");
                }
            }

            Console.WriteLine($"Task {name} Finished");
        }
    }
}