using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Process_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int threads = Environment.ProcessorCount;
            Console.WriteLine(threads);
            var cpuInfo = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            Console.WriteLine(cpuInfo);


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            BigInteger sum_a = SumAllEvenNumbersAssinc(0, 100000000);
            stopWatch.Stop();
            var timeSpent = stopWatch.ElapsedMilliseconds;
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Multiple threads time spent :" + timeSpent);
            Console.WriteLine("Input numer:");
            //int num = int.Parse(Console.ReadLine());

            stopWatch.Reset();
            stopWatch.Start();
            BigInteger sum_b = GetSumOfEvenNumbers(0, 100000000);
            stopWatch.Stop();
            timeSpent = stopWatch.ElapsedMilliseconds;
            Console.WriteLine("1 thread time spent :" + timeSpent);

            var dif = sum_a - sum_b;
            Console.WriteLine("Result of sum: " + sum_a);
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Difference: " + (dif == 0 ? "OK" : "Wrong!"));
        }

        private static BigInteger GetSumOfEvenNumbers(int start, int end)
        {
            BigInteger sum = 0;
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static BigInteger SumAllEvenNumbersAssinc(int start, int end)
        {//0-100
            int cpuCount = Environment.ProcessorCount -1;
            BigInteger sum = 0;
            int portion = (end - start) / cpuCount;
            List<Task> tasks = new List<Task>();
            object key = new object();
            for (int i = 0; i < cpuCount; i++)
            {
                int st_i = start + portion * i;
                int end_i = portion * (i + 1);
                Console.WriteLine($"Interval : {st_i} - {end_i}");
                Task task = new Task(() =>
                                {
                                    var newValue = GetSumOfEvenNumbers(st_i, end_i);
                                    lock (key)
                                    {
                                        sum += newValue;
                                    }
                                });

                task.Start();
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
            return sum;
        }

    }
}
