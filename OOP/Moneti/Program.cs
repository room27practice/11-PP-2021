using System;

namespace Moneti
{
    public class Program
    {
        public static void Main()
        {
            decimal ammount = decimal.Parse(Console.ReadLine());
            int coins_2lv = (int)ammount / 2;
            ammount -= coins_2lv * 2;
            int coins_1lv = (int)ammount / 1;
            ammount -= coins_1lv * 1;
            //--------------------------------
            int stotinki = (int)(ammount * 100);
            int coins_50st = stotinki / 50;
            stotinki = stotinki - coins_50st * 50;

            int coins_20st = stotinki / 20;
            stotinki = stotinki - coins_20st * 20;

            int coins_10st = stotinki / 10;
            stotinki = stotinki - coins_10st * 10;

            int coins_5st = stotinki / 5;
            stotinki = stotinki - coins_5st * 5;
            int coins_2st = stotinki / 2;
            stotinki = stotinki - coins_2st * 2;

            int coins_1st = stotinki / 1;
           
            if (coins_2lv > 0) Console.WriteLine($"2 lv -> {coins_2lv} br.");
            if (coins_1lv > 0) Console.WriteLine("1 lv -> {0} br.", coins_1lv);
            if (coins_50st > 0) Console.WriteLine($"50 st -> {coins_50st} br.");
            if (coins_20st > 0) Console.WriteLine($"20 st -> {coins_20st} br.");
            if (coins_10st > 0) Console.WriteLine($"10 st -> {coins_10st} br.");
            if (coins_5st > 0) Console.WriteLine($"5 st -> {coins_5st} br.");
            if (coins_2st > 0) Console.WriteLine($"2 st -> {coins_2st} br.");
            if (coins_1st > 0) Console.WriteLine($"1 st -> {coins_1st} br.");      
        }
    }
}