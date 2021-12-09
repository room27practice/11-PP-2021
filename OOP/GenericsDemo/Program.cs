using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main()
        {

            var primer = new List<MyClass<string>>();

            var primer2 = new MyClass<string>("str");
            var primer3 = new MyClass<User>();

            primer.Add(primer2);

            Console.WriteLine("Hello World!");


            var primer4 = new MyClass<User>();

            var names = new List<string>() { "Marin", "Martin", "Margarin" };
            var ages = new List<int>() { 12, 15, 22 };
            primer4.GenMethod<string>(names);
            primer4.GenMethod(ages);

        }
    }

    class MyClass<T>
    // where T : new()
    {
        public MyClass()
        {
            innerCollection = new List<T>();
        }
        public MyClass(T item) : this()
        {
            Item = item;
        }
        public T Item { get; set; }
        private List<T> innerCollection;

        public int MyProperty2 { get; set; }


        public T GetSomething(T item)
        {
            return default(T);
        }

        public void GenMethod<B>(ICollection<B> items)
            where B : IComparable<B>
        {
            // Код на метода 
        }
    }





    public abstract class BaseDB<T>
    {
        public BaseDB()
        {
            CreatedOn = DateTime.UtcNow;
        }

        public T Id { get; private set; }
        public DateTime CreatedOn { get; }
        public DateTime? DeletedOn { get; private set; } = null;
        private bool isDeleted { get; set; }
        public bool IsDeleted
        {
            get
            {
                return isDeleted;
            }
            set
            {
                if (!isDeleted && value)
                {
                    isDeleted = value;
                    DeletedOn = DateTime.UtcNow;
                }
            }
        }
    }


    public class User : BaseDB<string>
    {
        public User()
        { }
        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }

}
