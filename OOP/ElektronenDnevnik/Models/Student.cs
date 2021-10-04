using System;
using System.Collections.Generic;
using System.Linq;

namespace ElektronenDnevnik
{
    public class Student
    {
        private static int studentCounter = 0;
        public Student()
        {
            studentCounter++;
            Id = studentCounter;
            SubjectsGrades = new List<SubjectGrades>();
        }

<<<<<<< HEAD
        static Student()
        {
            SchoolName = "PGMETT";
        }

        public static string SchoolName { get; }
=======
        public static string SchoolName { get; } = "PGMETT";
>>>>>>> 4d70158647894e67e2a17b81598a62f9937c4f74
        public string Name { get; set; }
        public int Id { get; }

        public List<SubjectGrades> SubjectsGrades { get; set; }

<<<<<<< HEAD
        public List<SubjectGrades> GetHangingSubjects =>
=======
        public List<SubjectGrades> GetHangingSubjects => 
>>>>>>> 4d70158647894e67e2a17b81598a62f9937c4f74
            SubjectsGrades.Where(x => x.GetGrades().Count() < 3).ToList();

        public List<SubjectGrades> GetFailedSubjects =>
                SubjectsGrades.Where(x => x.GetRoundedAverage() == 2).ToList();

    }
}
