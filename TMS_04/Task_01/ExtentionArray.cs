using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    static class ExtentionArray
    {
        // Аналог оператора 'in'
        public static bool In<T>(this T value, params T[] options)
        {
            return options.Contains(value);
        }

        // Метод расширения для одномерногого массива - Заполнение рандомными числами
        static public void FillRandNum(this int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
        }

        // Перегрузка метода расширения для двумерного массива - Заполнение рандомными числами
        static public void FillRandNum(this int[,] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rand.Next(-100, 100);

        }

        // Метод расширения для одномерногого массива - Поиск Мax элемента
        static public void FindMaxElement(this int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                // max = Math.Max(max, array[i]); // простой способ
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Максимальный элемент в одномерном массиве = {max}");
        }

        // Перегрузка метода расширения для двумерного массива - Поиск Мax элемента
        static public void FindMaxElement(this int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    max = Math.Max(max, array[i, j]);

            Console.WriteLine($"Максимальный элемент в двумерном массиве = {max}");
        }

        // Метод расширения для одномерногого массива - Поиск Min элемента
        static public void FindMinElement(this int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                // min = Math.Min(min, array[i]); // простой способ
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($"Минимальный элемент в одномерном массиве = {min}");
        }

        // Перегрузка метода расширения для двумерного массива - Поиск Min элемента
        static public void FindMinElement(this int[,] array)
        {
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    min = Math.Min(min, array[i, j]);

            Console.WriteLine($"Минимальный элемент в двумерном массиве = {min}");
        }

        // Метод расширения для одномерногого массива - Поиск суммы элементов
        static public void FindSum(this int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            Console.WriteLine($"Сумма всех элементов массива = {sum}");
        }

        // Перегрузка метода расширения для двумерного массива - Поиск суммы элементов
        static public void FindSum(this int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    sum += array[i, j];

            Console.WriteLine($"Сумма всех элементов массива = {sum}");
        }

        // Метод расширения для одномерногого массива - Поиск среднего арифметического
        static public void FindAvg(this int[] array)
        {
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
                avg += array[i];

            avg /= array.Length;
            Console.WriteLine($"Cреднее арифметическое всех элементов одномерного массива = {avg}"); 
        }

        // Перегрузка метода расширения для одномерногого массива - Поиск среднего арифметического
        static public void FindAvg(this int[,] array)
        {
            double avg = 0;
            
            for(int i = 0; i<array.GetLength(0); i++)
                for(int j = 0; j<array.GetLength(1); j++)
                   avg += array[i, j];

            avg /= array.Length;
            Console.WriteLine($"Cреднее арифметическое всех элементов одномерного массива = {avg}");
        }
    }
}
