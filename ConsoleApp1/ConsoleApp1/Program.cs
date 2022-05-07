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
            Console.WriteLine("Вы хотите числа кратные 3 или 5");
            int divider = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число полученное путем рандома: {number}");

            for (int i = 0; i < number; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма:{sum}");
        }
    }
}