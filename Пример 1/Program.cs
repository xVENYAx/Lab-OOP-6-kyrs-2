// Заполнение массивов
using System;

namespace Пример_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            Console.WriteLine("\n\n Одномерный массив iArray");
            int[] iArray = new int[10];
            for (j = 0; j < 10; j++)
                iArray[j] = j * j;
            // присваивание значений
            // элементам в цикле
            for (j = 0; j < 10; j++)
                // вывод элементов
                Console.WriteLine("\n " + j + " " + iArray[j]);
            Console.WriteLine("\n Одномерный массив chArray с инициализацией");
            char[] chArray = { 'a', 'b', 'c', 'd' };
            // Объявление с инициализацией
            j = -1;
            do
            {
                j++;
                Console.WriteLine("\n " + j + "  " + chArray[j]);
            }
            while (chArray[j] != 'd');
            // вывод элементов массива
            Console.WriteLine();
            Console.WriteLine("\n Значения присвоены не всем элемента массива iiArray \n");
            int[] iiArray = new int[10];
            for (j = 1; j < 6; j++)
            {
                iiArray[j] = j * j;
                iiArray[9] = 81;
            }
            foreach (int jj in iiArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");
            Console.Write(" ");
        }
    }
}
