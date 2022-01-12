﻿using Greshki.Model;
using System;

namespace Greshki
{
    class StartUp
    {
        public static void Main()
        {

            Console.WriteLine("Hello World 6!");
            try
            {
                int.Parse("asd");
                Console.WriteLine("Hello World 6!");
            }
            catch  
            {
                Console.WriteLine("Problem..........................");
            }


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
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Prazen string");
                }
                catch (BattleException ex)
                {
                    Console.WriteLine("Boi boi boi " + ex.Message);
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Some app error unspecified " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Neochakvana greshka " + ex.Message);
                }


                Console.WriteLine("Vsichko e tochno.");
            }


        }

    }
}
