using System;

namespace HomeWork_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер сторон треугольника: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < N - i; j++)
                    Console.Write(' ');
                for (int j = N - 2 * i; j <= N; j++)
                {
                    Console.Write('*');
                }
                    
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
