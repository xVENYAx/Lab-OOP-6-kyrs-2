// Ввод массива в файл и вывод массива из файла
using System;
using System.IO;

namespace Пример_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            string strValue;
            int[] iArray1 = new int[10];
            int[] iArray2 = new int[10];
            StreamReader sRead = new StreamReader("C:\\VS\\dat.txt");
            StreamWriter sWrite = new StreamWriter("C:\\VS\\res.txt");
            for (j=0;j<10;j++)
            {
                strValue = sRead.ReadLine();
                iArray1[j] = Convert.ToInt32(strValue);
                iArray2[j] = 10 * iArray1[j];
                strValue = string.Format("\n {0, 4:D} {1, 6:D} {2, 6:D}", j, iArray1[j], iArray2[j]);
                Console.WriteLine(strValue);
                Console.WriteLine();
                sWrite.WriteLine(iArray2[j]);
            }
            sRead.Close();
            sWrite.Close();
        }
    }
}
