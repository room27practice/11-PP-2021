using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousDemo
{
    class Program
    {
        const int TOTAL_SCORE = 81;
        static void Main(string[] args)
        {
            var input = @"1 Бирол 56
2 Даниел 0
3 Елена 0
4 Ерсин 51
5 Есер 33
6 Ивайло 51
7 Красимир 41
8 Нели 55
9 Петко 32
10 Пламен 26
11 Сезгин 39
12 Селим 59
13 Сечкин 69";

            var test = input
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Student> students = input
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => new Student(x))
                .ToList();

            foreach (Student st in students.OrderByDescending(x => GetGradeFromPoints(x.Points)).Where(x => x.Points > 0))
            {
                Console.WriteLine($"{st.Number}-{st.Name}-{GetGradeFromPoints(st.Points)}");
            }

            var anon1 = new { Name = "Genadi", GSM = "094323234542", Town = "Shumen" };
            var anon2 = new { Neim = "Genadi", GSM = "094323234542", Town = "Shumen" };
            var experiment = students.Select(s => new { s.Number, s.Name }).ToArray();

            foreach (var item in experiment)
            {
                Console.WriteLine(item.Name + " " + item.Number);
            }
        }

        public static int GetGradeFromPoints(int points) =>
                (int)Math.Round((2 + Math.Ceiling(4 * points / TOTAL_SCORE / 0.25) * 0.25));
    }

    public class Student
    {
        public Student(string input)
        {
            //"1 Birol 56"
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Number = int.Parse(tokens[0]);
            Name = tokens[1];
            Points = int.Parse(tokens[2]);
        }

        public Student(int number, string name, int points)
        {
            Number = number;
            Name = name;
            Points = points;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}
