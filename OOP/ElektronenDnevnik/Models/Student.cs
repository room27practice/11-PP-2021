using System.Collections.Generic;
using System.Linq;

namespace ElektronenDnevnik
{
    public class Student
    {
        private static int studentCounter = 0;

        public Student(string name):this()
        {
            Name = name;
        }

        public Student()
        {
            studentCounter++;
            Id = studentCounter;
            SubjectsGrades = new List<SubjectGrades>();
        }

        static Student()
        {
            SchoolName = "PGMETT";
        }

        public static string SchoolName { get; }

        public string Name { get; set; }
        public int Id { get; }

        public List<SubjectGrades> SubjectsGrades { get; set;}


        public List<SubjectGrades> GetHangingSubjects => 
            SubjectsGrades.Where(x => x.GetGrades().Count() < 3).ToList();

        public List<SubjectGrades> GetFailedSubjects =>
                SubjectsGrades.Where(x => x.GetRoundedAverage() == 2).ToList();

    }
}