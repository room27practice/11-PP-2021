using System;
using System.Threading;
using System.Threading.Tasks;

namespace Blocking_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start!");
            string message = "Hello";

            Task.Run(() =>
            {
                while (true)
                {
                    Console.Write("Insert New Message");
                    message = Console.ReadLine();
                }
            });
            for (int i = 0; i < 20; i++)
            {
                WriteMessage(message, 2);
            }

        
        }

        static void WriteMessage(string message, int seconds)
        {
            Thread.Sleep(seconds * 1000);
            Console.WriteLine(message);
        }
    }
}
