using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int sum = 0;
            int starNumber = 0;
            int remains = 0;
            int divider = 3;
            Console.WriteLine($"Число полученное путем рандома: {number}");

            for (int correctNumber = starNumber; correctNumber < number; correctNumber++)
            {
                if (correctNumber % divider == remains)
                {
                    Console.WriteLine(correctNumber);
                    sum += correctNumber;
                }
            }
            Console.WriteLine("Сумма");
            Console.WriteLine(sum);
        }
    }
}
