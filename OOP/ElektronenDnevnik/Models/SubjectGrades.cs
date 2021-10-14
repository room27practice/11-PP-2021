using System;
using System.Collections.Generic;
using System.Linq;

namespace ElektronenDnevnik
{
    public class SubjectGrades
    {
        public SubjectGrades()
        {
            grades = new List<int>();
        }

        private List<int> grades { get; set; }

        public Subject Subject { get; set; }

        public void AddGrade(int grade)
        {
            if (grade < 2 || grade > 6)
            {
                System.Console.WriteLine("Cant register invalid grades");
                return;
            }
            grades.Add(grade);
        }

        public List<int> GetGrades()
        {
            return this.grades.ToList();
        }

        public double GetAverage()
        {
            return (double)grades.Sum() / grades.Count();
        }
        public int GetRoundedAverage()
        {
            double avg = GetAverage();
            if (avg < 3)
            {
                return 2;
            }

            return (int)Math.Round(avg, 0);
        }
    }
}