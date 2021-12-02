using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Model
{
    public abstract class Animal
    {
        private double weight;
        protected Animal(string name, DateTime birthDate, double weight)
        {
            Name = name;
            BirthDate = birthDate;
            Weight = weight;
        }

        public static TimeSpan LifeSpan { get; protected set; }

        public string Name { get; set; }
        public DateTime BirthDate { get; }
        public double Weight
        {
            get => weight;
            set
            {
                if (value > 0)
                {
                    weight = value;
                }

                throw new ApplicationException("Invalid Weight");
            }
        }

        public TimeSpan Age => DateTime.UtcNow - BirthDate;

        public AgeGrade GetAgeGrade()
        {
            long percentAge = 100 * (Age.Ticks / LifeSpan.Ticks);
            if (percentAge > 100)
            {
                return AgeGrade.Venerable;
            }
            if (percentAge > 75)
            {
                return AgeGrade.Old;
            }
            if (percentAge > 40)
            {
                return AgeGrade.Average;
            }
            if (percentAge > 15)
            {
                return AgeGrade.Young;
            }
            if (percentAge > 5)
            {
                return AgeGrade.Child;
            }
            else
            {
                return AgeGrade.Infant;
            }
        }

        public override string ToString()
        {
            return $"I am {Name} and I am {Age.TotalDays} days old.I weight {Weight:2F}";
        }

    }
}
