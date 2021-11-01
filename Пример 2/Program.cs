// Ввод массива с клавиатуры
using System;

namespace Пример_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            // Начальное значение
            string strValue;
            int[] iArray = new int[10];
            for (j = 0; j < 10; j++)
            {
                strValue = Console.ReadLine();
                // ввод и присваивание значений
                iArray[j] = Convert.ToInt32(strValue);
            }
            for (j = 0; j < 10; j++)

                // вывод элементов
                Console.WriteLine("\n " + j + " " + iArray[j]);
            
        }
    }
}
