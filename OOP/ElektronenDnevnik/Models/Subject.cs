using System.Linq;

namespace ElektronenDnevnik
{
    public class Subject
    {
        public Subject(string name, int semesterCount, string description = "")
        {
            Name = name;
            SemesterCount = semesterCount;
            Description = description;
        }

        public string Name { get; set; }
        public int SemesterCount { get; set; }
        public string Description { get; set; }
    }
}