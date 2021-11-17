using System;

namespace Greshki.Model
{
    public class Window : IProduct
    {
        public Material Material { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
        public Manufacturer Manufacturer { get; set; }


        public int GetDayOfWeek(string day)
        {
            if (day=="combat")
            {
            throw new BattleException("moq ap se schupi");
            }

            if (day=="schupi se qko")
            {
                //int[] arr = new int[5];
                //Console.WriteLine(arr[-10]);
                //Console.WriteLine(arr[10]);
                int.Parse("babaliugi");
            }
            
            if (string.IsNullOrEmpty(day))
            {
                throw new ArgumentNullException("Ne moje bez parametur da puskash programata....");
            }

            switch (day)
            {
                case "ponedelnik":
                    {
                        return 1;
                    }
                case "vtornik":
                    {
                        return 2;
                    }
                case "srqda":
                    {
                        return 3;
                    }
                case "chetvurtuk":
                    {
                        return 4;
                    }
                case "petuk":
                    {
                        return 5;
                    }
                case "subota":
                    {
                        return 6;
                    }
                case "nedelq":
                    {
                        return 7;
                    }
            }

            throw new InvalidOperationException("Vuvel si nevalien den ot sedmicata!!!");
        }


        public void DoSomething(string parameter)
        {
            if (parameter.Length < 5)
            {
                Console.WriteLine("Nqma problemi");
            }
            else
            {
                throw new Exception("Mnogo dulug string");
            }
        }
    }
}