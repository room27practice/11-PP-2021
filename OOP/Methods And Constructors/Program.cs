namespace Methods_And_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
      

            var test1 = new MethodsAndProperties();
            test1.GetNumber();

           
            var num2 = test1.GetNumber();//5
            var num3 = test1.EnlargeNumber(5);//3x5=15
           // var num4 = test1.GetSecretNumber(); // Не е достъпно отвън.
        }
    }

    class MethodsAndProperties
    {
        public int Number { get; set; } = 5; //Свойство
        private bool IsOdd(int num)
        {
            return num % 2 == 0;
        }
        public int GetNumber() //Метод
        {
            return 5;
        }
        public int GetNumber(string information) //Метод
        {
            return 5;
        }

        public int EnlargeNumber(int num) //Метод
        {
            if (IsOdd(num))
            {
                return 2 * num;
            }
            return 3 * num;
        }
    }
}