using System;

class StartUp
{
    static void Main()
    {
        //Dice dice1 = new Dice() { Sides = 7 };

        ////dice1.Sides = 4;
        //for (int i = 0; i < 25; i++)
        //{
        //    Console.WriteLine($"Roll dice {dice1.Roll()}");
        //}

        Dog homeDog = new Dog() { Age = 1 };
        Console.WriteLine(homeDog.Weight);
        homeDog.FeedDog(400);
        Console.WriteLine(homeDog.Weight);

        //homeDog.Age = -10;
        //homeDog.Age = 100;
        homeDog.Age = 5;
        homeDog.FeedDog(250);
        Console.WriteLine(homeDog.Weight);
        //homeDog.Age = 55;
        //Console.WriteLine($"I am a dog and {homeDog.GetAge}");
        Console.WriteLine(homeDog.GetAge);
    }
}

public class Dice
{
    private int sides;
    string type;
    public int Sides { get => sides; set => sides = value; }
    public int Roll()
    {
        Random random = new Random();
        int result = random.Next(1, this.Sides + 1);
        return result;
    }
}

class Dog
{
    private int age;
    public double Weight { get; private set; }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Nevalidna vuzrast na kucheto");
            }
            else if (value > 50)
            {
                Console.WriteLine("Mnogo golqma vuzrast");
            }
            else
            {
                age = value;
            }
        }
    }
    public string GetAge
    {
        get
        {
            return $"I am {age} years old";
        }
    }
    public string Breed { get; set; } = "chihuahaaha";
    public void FeedDog(int foodWeightGrams)
    {
        if (foodWeightGrams > 500)
        {
            foodWeightGrams = 500;
        }
        if (age < 2)
        {
            Weight += 0.6 * foodWeightGrams/1000;
        }
        else
        {
            Weight += 0.3 * foodWeightGrams/1000;
        }
    }
}