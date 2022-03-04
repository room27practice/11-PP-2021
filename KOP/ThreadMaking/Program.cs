using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsMaking
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           
            var watch = new Stopwatch();
            watch.Start();
 
          //  CookBreakfast(); //23 s
                                CookBreakfastAsync().Wait(); //14 s
                             //  CookBreakfastOptimizedAsync().Wait(); //12 s
            watch.Stop();
            Console.WriteLine($"Total Time needed to make breakfast: {watch.Elapsed.Seconds:F1}");
        }

        private static void CookBreakfast()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("toast is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        private static async Task CookBreakfastAsync()
        {

            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Main Thread Id:" + id);

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = await FryEggsAsync(2); // няма смисъл от асинхронно защото искаме да осовободим тигана за бекона
            Console.WriteLine("eggs are ready");

            Task<Bacon> baconT = FryBaconAsync(3); // Има смисъл от асинхронно но трябва да се изчака, иначе закуската приключва преди бекона да е готов!
            Console.WriteLine("bacon is ready");

            var toast = ToastBreadAsync(2);// Има смисъл от асинхронно защото можем да налеем сок докато се препича
            
            Juice oj = PourOJ(); //Няма смисъл от асинхронно защото чакаме филийките така или иначе а те отнемат повече време

            Console.WriteLine("oj is ready");

            ApplyButter(toast.Result);
            ApplyJam(toast.Result);

            Console.WriteLine("toast is ready");
            baconT.Wait();

            Console.WriteLine("Breakfast is ready!");
        }

        private static async Task CookBreakfastOptimizedAsync()
        {            
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Task usePan = Task.Run(() =>
            {
                var eggs = FryEggs(2);
                Console.WriteLine("eggs are ready");
                Bacon baconT = FryBacon(3);
                Console.WriteLine("bacon is ready");
            });

            Task<Toast> toast = ToastBreadAsync(2); // Има смисъл от асинхронно защото можем да налеем сок докато се препича

            Juice oj = PourOJ(); //Няма смисъл от асинхронно защото чакаме филийките така или иначе а те отнемат повече време

            Console.WriteLine("oj is ready");

            ApplyButter(toast.Result);
            ApplyJam(toast.Result);

            Console.WriteLine("toast is ready");
            usePan.Wait();

            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            Thread.Sleep(8000);
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();

            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }
        public static List<int> ThreadIds { get; set; } = new List<int>();

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            ThreadIds.Add(id);
            Console.WriteLine("Secondary Thread Id:" + id);

            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            var a = Task.Delay(3000);
            await Task.Run(() => a);

            Console.WriteLine("Remove toast from toaster");


            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }


        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
