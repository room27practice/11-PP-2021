using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExtensionsDemo.Program;

namespace ExtensionsDemo
{
    public static class ExtensionMaster
    {
        public static string GetDetailedMonkeyInfo(this Monkey mon,string brand)
        {
            return $"I am monkey called {mon.Name}. And I am {mon.Age} old. I weight {mon.Weight} kg. I am brand : {brand}";
        }

        public static double ToDouble(this string str)
        {
            return double.Parse(str);
        }

        public static List<T> GetHalf<T>(this IEnumerable<T> arr)
        {
            List<T> result = new List<T>();

            T[] newArr = arr.ToArray();
            for (int i = 0; i < newArr.Length / 2; i++)
            {
                result.Add(newArr[i]);
            }
            return result;
        }

        public static List<int> GetEvenEx(this int[] arr)
        {
            List<int> resultEven = new List<int>();
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    resultEven.Add(number);
                }
            }

            return resultEven;
        }









        public static List<int> GetOddEx(this int[] arr)
        {
            List<int> resultEven = new List<int>();
            foreach (int number in arr)
            {
                if (number % 2 == 1)
                {
                    resultEven.Add(number);
                }
            }

            return resultEven;
        }





        public static List<int> GetEven(int[] arr)
        {
            List<int> resultEven = new List<int>();
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    resultEven.Add(number);
                }
            }

            return resultEven;
        }

        public static List<int> GetOdd(int[] arr)
        {
            List<int> resultOdd = new List<int>();
            foreach (int number in arr)
            {
                if (number % 2 == 1)
                {
                    resultOdd.Add(number);
                }
            }

            return resultOdd;
        }



    }
}
