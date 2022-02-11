using System;
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
            BigInteger sum_a = SumAllEvenNumbersAssinc(0, 100);
            stopWatch.Stop();
            BigInteger sum_b = GetSumOfEvenNumbers(0, 100);
            var res = sum_a - sum_b;
            var timeSpent = stopWatch.ElapsedMilliseconds;
            Console.WriteLine(timeSpent);
            Console.WriteLine(sum_a);
        }

        private static BigInteger SumAllEvenNumbersAssinc(int start, int end)
        {//0-100
            int cpuCount = Environment.ProcessorCount-1;
            BigInteger sum = 0;
            int portion = (end - start) / cpuCount;
            Task[] tasks = new Task[cpuCount];
            for (int i = 0; i < cpuCount; i++)
            {
                tasks[i] = new Task(() => sum += GetSumOfEvenNumbers(start + portion * i, portion * (i + 1)));
                tasks[i].Start();
            }

            Task.WaitAll(tasks);

            return sum;
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
    }
}
