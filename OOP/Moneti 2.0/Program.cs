using System;

namespace Moneti_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int stotinki = (int)(100 * decimal.Parse(Console.ReadLine()));
            int[] moneti = new int[] { 10000,5000,2000,1000,500,200, 100, 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < moneti.Length; i++)
            {
                int currentCoin = moneti[i];
                int coinCount = stotinki / currentCoin;
                if (coinCount > 0)
                {
                    if (currentCoin >= 100)
                    {
                        Console.WriteLine($"Restoto vi e {currentCoin / 100 } leva-> {coinCount} br.");
                    }
                    else
                    {
                        Console.WriteLine($"Restoto vi e {currentCoin} stotinki -> {coinCount} br.");
                    }
                    stotinki -= currentCoin * coinCount;
                }

            }
        }
    }
}