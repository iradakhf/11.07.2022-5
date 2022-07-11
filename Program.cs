using System;
namespace ConsoleApp33
{
    class Program
    {
        public static void Main (string[] args)
        {
            EvenOdd evenOrOdd = new EvenOdd(4);
           bool i= evenOrOdd.FindEvenOrOdd(evenOrOdd.Number);
            Console.WriteLine($"{evenOrOdd.Number} {i}");
        }
    }
    class EvenOdd
    {
        public int Number { get; set; }
        public EvenOdd(int number)
        {
            this.Number = number;
        }
        public bool FindEvenOrOdd(int number)
        {
            bool isEven = false;
            if (number % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }
            return isEven;
        }
    }
}