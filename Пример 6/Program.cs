// Вычислить сумму всех четных элементов одномерного массива, состочщих из 10 элементов.
// Заполнение одномерного массива происходит при помощи генератора случайных чисел
using System;

namespace Пример_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num, sum = 0;
            Random rnd = new Random();
            int[] iArray = new int[10];
            for (j=0;j<10;j++)
            {
                iArray[j] = rnd.Next(1, 101);
            }
            for (j=0; j<10;j++)
            {
                num = Convert.ToInt32(iArray[j]%2);
                if (num == 0) sum += iArray[j];
            }
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\n Сумма четных элементов = " + sum);
            Console.WriteLine();
            Console.WriteLine(" ");
        }
    }
}
