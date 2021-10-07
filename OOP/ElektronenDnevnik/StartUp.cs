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

            Console.WriteLine("Input student names separated by '|' ... ");
            List<Student> students = "Birol Ahmedov|Sechkin Rahim|Eser Mustafa|Krasimir G. Slavov|Neli Angelova|Ersin|Petko"
                //Console.ReadLine()
                .Split('|')
                .Select(name => new Student(name))
                .ToList();
            Console.WriteLine("Input subjects separated by '|' in format[name_semesterCount] ...");

            var subjects = "Muzika_1|Risuvane_2|Planinarstvo_1|Sviat I lichnost_2|Chovek & priroda_1|Grajdanska otbrana_2|Rumunski ezik_4"
                             //  Console.ReadLine()
                             .Split('|')
                             .Select(x => x.Split('_'))
                             .Select(x => new Subject(x[0], int.Parse(x[1])))
                             .OrderByDescending(x => x.Name)
                             .ThenBy(x => x.SemesterCount)
                             .ToList();

            foreach (var std in students)
            {
                foreach (var sbj in subjects)
                {
                    std.SubjectsGrades.Add(new SubjectGrades() { Subject = sbj });
                }
            }

            Console.WriteLine(new string('=', 30));
            string[] menuOptions = { "read", "write", "exit" };
            Console.WriteLine($"Choose menu [{string.Join("][", menuOptions)}]...");

            string command = Console.ReadLine().ToLower();
            while (command != "exit")
            {
                if (!menuOptions.Contains(command))
                {//RRRRREADDDD
                    Console.WriteLine($"Choose menu [{string.Join("][", menuOptions)}]...");
                    command = Console.ReadLine().ToLower();
                    continue;
                }
                string choise = string.Empty;
                switch (command)
                {
                    case "read":
                        {
                            Console.WriteLine("Choose command [Get Grades of Student=1][Get Grades for Subject=2][exit]");
                            choise = Console.ReadLine();
                            break;
                        }
                    case "write":
                        {
                            Console.WriteLine("Choose command [Add Student=1][Add Subject=2][Assign Grade=3][exit]");
                            choise = Console.ReadLine();

                            if (choise == "1")
                            {
                                Console.Write("Student Name...");
                                var st = new Student(Console.ReadLine());
                                students.Add(st);
                                foreach (var sbj in subjects)
                                {
                                    st.SubjectsGrades.Add(new SubjectGrades() { Subject = sbj });
                                }
                            }
                            if (choise == "2")
                            {
                                Console.Write("Input subject name...");
                                string name = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Input semester count...");
                                int count = int.Parse(Console.ReadLine());
                                var subj = new Subject(name, count);
                                subjects.Add(subj);
                                foreach (var std in students)
                                {
                                    std.SubjectsGrades.Add(new SubjectGrades() { Subject = subj });
                                }

                            }
                            break;
                        }
                }

                if (choise == "exit")
                {
                    Console.WriteLine($"Choose menu [{string.Join("][", menuOptions)}]...");
                    command = Console.ReadLine().ToLower();
                }

            }



            //var st1 = new Student() { Name = "Miroslav" };
            //var st2 = new Student() { Name = "Petur" };
            //var st3 = new Student() { Name = "Petur III" };
            //Console.WriteLine(st1.Id + "|" + st2.Id + "|" + st3.Id);

            //  var sub = new Subject("Matematika",);



        }
    }
}
