using System;

namespace EX1
{ 
    class Program
    {
        static void Main()
        {
            int[] arrayInts = GetArrayWithRandomNum(20); // целочисленый массив
            Console.WriteLine("Массив элементов из случайных чисел:");
            Array.ForEach(arrayInts, Console.WriteLine); ; //вывод всех элементов в консоль
            Console.WriteLine();
            int count = GetCountGoodNumbers(arrayInts); // количество пар
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 - {count}");


        }

        static int[] GetArrayWithRandomNum(int size)
        {
            Random rnd = new Random();
            int[] retArr = new int[size];
            for (int i = 0; i < retArr.Length; i++)
            {
                retArr[i] = rnd.Next(-10_000, 10_000);
            }
            return retArr;
        }

        static int GetCountGoodNumbers(int[] arrayInts)
        {
            int count = default;
            for (int i = 0; i < arrayInts.Length - 1; i++)
            {
                if (arrayInts[i] % 3 == 0 ^ arrayInts[i + 1] % 3 == 0) //подсчет всех хороших пар чисел
                {
                    count++;
                }
            }
            return count;
        }
    }
}