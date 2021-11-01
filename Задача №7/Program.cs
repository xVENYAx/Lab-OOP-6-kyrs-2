using System;

namespace Задача__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum = 0;
            Random rnd = new Random();
            int[] iArray = new int[20];
            for (j = 0; j < 20; j++)
            {
                iArray[j] = 50 - rnd.Next(1, 101);
            }
            for (j = 0; j < 20; j++)
            {
                if (iArray[j] > 0)
                {
                    sum += iArray[j];
                }
            }
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n Сумма положительных чисел массива А: " + sum);
            Console.WriteLine(" ");
        }
    }
}
