using Greshki.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greshki
{
    class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Hello World 6!");

            //int number1 = int.Parse("51");
            //int number2 = int.Parse("asdasd");

            Window win1 = new Window();
            Window win2 = null;
            //win2.DoSomething("alabala");
            while (true)
            {
                Console.Write("Write Day Of Week:");

                string day = Console.ReadLine();
                try
                {
                    int dayNum = win1.GetDayOfWeek(day);
                    Console.WriteLine("You selected day = {0}", dayNum);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Nevalidna operacia: {ex.Message}");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Prazen string");
                }
                catch (BattleError ex)
                {
                    Console.WriteLine("Boi boi boi " + ex.Message);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Neochakvana greshka " + ex.Message);
               
                }



            }


        }

    }
}
