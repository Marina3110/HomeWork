using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    class Program
    {
        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next()%100;
            }
            Output(array);

            Console.WriteLine("\nСортировка по возрастанию:");
            Array.Sort(array);
            Output(array);

            Console.WriteLine("\nСортировка по убыванию:");
            Array.Reverse(array);
            Output(array);
            Console.ReadKey();
        }
    }
}
