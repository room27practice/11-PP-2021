using System;
using System.Collections.Generic;
using System.Linq;

namespace ElektronenDnevnik
{
    class StartUp
    {
        static void Main()
        {
            //string[] studentNames = Console.ReadLine().Split('|');
            //var students = new List<Student>();
            //foreach (var name in studentNames)
            //{
            //    students.Add(new Student() { Name = name });
            //}

            //Birol Ahmedov|Sechkin Rahim|Eser Mustafa|Krasimir G. Slavov|Neli Angelova|Ersin|Petko
            //

            Student[] students = Console.ReadLine().Split('|').Select(x => new Student() { Name = x }).ToArray();

            //Muzika_1|Risuvane_2|Planinarstvo_1|Sviat I lichnost_2|Chovek & priroda_1|Grajdanska otbrana_2|Rumunski ezik_4
            Subject[] subjects = Console.ReadLine()
                              .Split('|')
                              .Select(x => x.Split('_'))
                              .Select(x=>new Subject(x[0],int.Parse(x[1])))
                              .ToArray();

            foreach (var std in students)
            {

                foreach (var sbj in subjects)
                {
                    std.SubjectsGrades.Add(new SubjectGrades() { Subject = sbj });
                }
            }

            //var st1 = new Student() { Name = "Miroslav" };
            //var st2 = new Student() { Name = "Petur" };
            //var st3 = new Student() { Name = "Petur III" };
            //Console.WriteLine(st1.Id + "|" + st2.Id + "|" + st3.Id);

            //  var sub = new Subject("Matematika",);

            List<int> nums = null;

            nums.Add(4);

        }
    }
}
