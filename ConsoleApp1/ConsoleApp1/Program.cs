using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 101);
            int sum = 0;
            int dividerThree = 3;
            int dividerFive = 5;
            Console.WriteLine($"Число полученное путем рандома: {number}");

            for (int i = 0; i < number; i++)
            {
                if (i % dividerThree == 0 || i % dividerFive == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма:{sum}");
        }
    }
}