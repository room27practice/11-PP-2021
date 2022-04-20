using System;

namespace Diamant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halfRowsCount = (n - 1) / 2;
            for (int row = 0; row <= halfRowsCount; row++)
            {
                int startEnd_count = halfRowsCount - row;
                int inner_count = n - 2 - 2 * startEnd_count;
                if (inner_count < 0)
                {
                    Console.WriteLine(new String('_', startEnd_count)
                                       + "*"+ new String('_', startEnd_count));
                }
                else
                {
                Console.WriteLine(new String('_', startEnd_count)
                    + "*" + new String('_', inner_count) + "*"
                    + new String('_', startEnd_count));
                }                
            }

            for (int row = halfRowsCount-1; row >= 0; row--)
            {
                int startEnd_count = halfRowsCount - row;
                int inner_count = n - 2 - 2 * startEnd_count;
                if (inner_count < 0)
                {
                    Console.WriteLine(new String('_', startEnd_count)
                                       + "*" + new String('_', startEnd_count));
                }
                else
                {
                    Console.WriteLine(new String('_', startEnd_count)
                        + "*" + new String('_', inner_count) + "*"
                        + new String('_', startEnd_count));
                }

            }




        }
    }
}
