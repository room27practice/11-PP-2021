
using System.ComponentModel.DataAnnotations;

namespace RegexDemo
{
    class User
    {
        public User(int age, string name, string jobPosition)
        {
            Age = age;
            Name = name;
            JobPosition = jobPosition;
        }

        public int Age { get; set; }

        [RegularExpression("(0|(\\+359)|(\\+444))([-\\s]?\\d){9}(?![-\\d])", ErrorMessage = "Your phone number is not correct.")]
        public string GSM { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string JobPosition { get; set; }
        public int MaxAge { get; } = 100;
    }
}
