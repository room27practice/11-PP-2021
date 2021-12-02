using System;

namespace AnimalKingdom.Model
{
    public class Mammal : Animal
    {
        public Mammal(string name, DateTime bday, double weight, int nailsCount) : base(name, bday, weight)
        {
            NailsCount = nailsCount;
            //LifeSpan = new TimeSpan(18250, 0, 0, 0);
        }
        public static FoodType FoodType { get; protected set; }
        public static bool CanSeeColor { get; protected set; }
        public int NailsCount { get; set; } // Различно за всеки обект.
        public static double MaxSpeedPerHour { get; protected set; } // Eднакво за група животни затова е статично
    }

    public class Shimpanzee : Mammal
    {
        public Shimpanzee(string name, DateTime bday, double weight, int nailsCount, bool canSpeak) : base(name, bday, weight, nailsCount)
        {
            FoodType = FoodType.Everything;
            CanSeeColor = true;
            MaxSpeedPerHour = 30;
            CanSpeak = canSpeak;
        }
        public bool CanSpeak { get; set; }
    }

    public class Bull : Mammal
    {
        public Bull(string name, DateTime bday, double weight, int nailsCount, bool canTolerateRedColor) : base(name, bday, weight, nailsCount)
        {
            FoodType = FoodType.Plant;
            CanSeeColor = false;
            MaxSpeedPerHour = 15;
            CanTolerateRedColor = canTolerateRedColor;
        }

        public bool CanTolerateRedColor { get; set; }
    }

}
