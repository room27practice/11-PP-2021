using Linq_Demo;
using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("asdasd");
List<Person> people = new List<Person>
{
    new Person("Velislava",Gender.Female,25),
    new Person("Svetoslava",Gender.Female,27),
    new Person("Cvekloplama",Gender.Female),
    new Person("Galin",Gender.Male),
    new Person("Radoslava",Gender.Female),
    new Person("Preslava",Gender.Female),
    new Person("Aria",Gender.Female),
};

//string[] names_f = { "Galena", "Malina", "Gloria", "Nelina", "Luna", "Simona", "Simon", "Kati" };
//string[] names_m = { "Aziz", "Toni", "Fiki", "Konstantin", "Medi", "Adam", "Milko", "Vesko" };

//foreach (string f_name in names_f)
//{
//    people.Add(new Person(f_name, Gender.Female));
//}

//foreach (string m_name in names_m)
//{
//    people.Add(new Person(m_name, Gender.Male));
//}

var females = "Galena|Rostislava Malina||Gloria|Nelina|Luna-Simona|Simon|Kati"
    .Split(new char[] { '|', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(x => new Person(x, Gender.Female))
    .ToArray();
people.AddRange(females);

var summary = people.OrderByDescending(x => x.Name.Length)
    .ThenByDescending(x => x.Id).Select(x => $"I am {x.Name} - {x.Gender}. I have Id={x.Id}").ToList();

string[] names_m = { "Aziz", "Toni", "Fiki", "Konstantin", "Medi", "Adam", "Milko", "Vesko" };


int[] nums = { 1, 4, 5, 7 };
Console.WriteLine(nums.Count());
int total = nums.Sum(); //17

double totalSumOfAges = people.Sum(per => per.Age);
double totalSumOfAges2 = people.Sum(GetAgeOfPerson);
double OldestPerson = people.Max(per => per.Age);

var first5singers = people.Take(5).ToArray();
Console.WriteLine(string.Join(" | ", first5singers.Select(x => $"{x.Name} {x.Id}")));

var first5singersAfterFirst2 = people.Skip(2).Take(5).ToArray();
Console.WriteLine(string.Join(" | ", first5singersAfterFirst2.Select(x => $"{x.Name} {x.Id}")));

var allBut2 = people.Skip(2).ToArray().Reverse();
Console.WriteLine(string.Join(" | ", allBut2.Select(x => $"{x.Name} {x.Id}")));






if (people.Any())
{
    Console.WriteLine("there is someone home");
}

if (people.Any(p => p.Age == 27))
{
    Console.WriteLine("There is Velislava at 27");
}
else
{
    Console.WriteLine("No Velislava at 27");
}

if (people.FirstOrDefault(x => x.Age == 27) != null)
{
    Console.WriteLine("There is Velislava at 27");
}


if (people.Where(x => x.Age == 27).Count() > 0)
{
    Console.WriteLine("There is Velislava at 27");
}

bool isFound = false;
for (int i = 0; i < people.Count; i++)
{
    if (people[i].Age == 27)
    {
        isFound = true;
        break;
    }
}
if (isFound)
{
    Console.WriteLine("There is Velislava at 27");
}

var verySelectedPeople = people.Where(p =>
{



    return p.Age == 8;
});


/*
[string].Split("-")-> Колекция от стрингове След което трябва да се избере .ToList() или .ToArray();
[колекция].Select(x=>Int.Parse(x)) -> Команда, която хваща всеки елемент в колекция и го променя на базата на ламбда израза. 
Като получаваме нова колекция от новите елементи.
[колекция].Where(x=>x.Id%2==0).Where(x=>x.Gender==Gender.Female) - Дава филтрация на колекция и връща под-множество.
//////[колекция].FirstOrDefault(x=>x.Id==13) - Връща първото намерено от колекцията което удовлетворява условието в ламбда израза.
[колекция].Where(x=!x.IsDeleted).OrderByDescending(x=>x.Price).ThenByDescending(x=>x.SalesCount).ToArray();
[producti].Where(x=>x.Price>200 && x.Price<300)
  */


int GetAgeOfPerson(Person p)
{
    return p.Age;
}


double Divide1(double a, double b)
{
    return a / b;
}