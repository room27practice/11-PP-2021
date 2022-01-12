namespace Linq_Demo
{
    public class Person
    {
        private static int idCounter;
        public Person()
        {
            idCounter++;
            Id = idCounter;
        }




        public Person(string name, Gender gender,int age=0) : this()
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string GSM { get; set; }
    }

}