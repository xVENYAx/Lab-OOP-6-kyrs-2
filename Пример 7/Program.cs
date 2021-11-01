// Определить индексы второго положительного и третьего отрицательного элементов одномерного массива, состоящих из 20 элементов.
// Заполнение массива происходит при помощи генератора случайных чисел.
using System;

namespace Пример_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, jnum = 0;
            Random rnd = new Random();
            int[] iArray = new int[20];
            for (j=0;j<20;j++)
            {
                iArray[j] = 50 - rnd.Next(1, 101);
            }
            for (j=0;j<20;j++)
            {
                if (iArray[j] > 0) jnum += 1;
                if (jnum == 2) break;
            }
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\n индекс вторго положительного элемента = " + j);
            Console.WriteLine("\n iArray[" + j + "] = " + iArray[j]);
            jnum = 0;
            for (j=0;j<20;j++)
            {
                if (iArray[j] < 0) jnum += 1;
                if (jnum == 3) break;
            }
            Console.WriteLine("\n индекс третьего отрицательного элемента = " + j);
            Console.WriteLine("\n iArray[" + j + "] = " + iArray[j]);
            Console.WriteLine();
            Console.WriteLine(" ");
        }
    }
}
