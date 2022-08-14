using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class RandomTwoRankArray
    {
        int[,] a;

        public RandomTwoRankArray()
        {
            Console.Write("Введите числу строк двумерного массива: ");
            int row = Program.Input();
            while (row < 1)
            {
                Console.Write("Длина строк не может быть меньше 1 элемента: ");
                row = Program.Input();
            }
            Console.Write("Введите числу столбцов двумерного массива: ");
            int column = Program.Input();
            while (column < 1)
            {
                Console.Write("Длина столбцов не может быть меньше 1 элемента: ");
                column = Program.Input();
            }

            a = new int[row, column];
            a.FillRandNum(); // заполняем массив
        }

        public void ShowInfo()
        {
            a.Print(); // выводим
            a.FindMaxElement(); // находим максимальный элемент
            a.FindMinElement(); // находим минимальный элемент
            a.FindSum(); // находим сумму элементов
            a.FindAvg(); // находим среднее арифметическое
        }

        public void BubbleSort()
        {
            Console.WriteLine("Сортировка пузырьком: ");
            int length = a.Length;
            int[] oneLineArray = new int[length];
            //Создаю одномерный массив из матрицы, сортирую его и вывожу
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    oneLineArray[(i * a.GetLength(1)) + j] = a[i, j];
                }
            }

            oneLineArray.BubbleSort();
            // создаем новый массив, в который запишем все значения из отсортированного одномерного
            int[,] sortedArray = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    sortedArray[i, j] = oneLineArray[(i * a.GetLength(1)) + j];

            sortedArray.Print();
        }

        public void MergeSort()
        {
            Console.WriteLine("Сортировка слиянием: ");
            int length = a.Length;
            int[] oneLineArray = new int[length];
            //Создаю одномерный массив из матрицы, сортирую его и вывожу
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    oneLineArray[(i * a.GetLength(1)) + j] = a[i, j];
                }
            }

            oneLineArray.MergeSort();
            // создаем новый массив, в который запишем все значения из отсортированного одномерного
            int[,] sortedArray = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    sortedArray[i, j] = oneLineArray[(i * a.GetLength(1)) + j];

            sortedArray.Print();
        }

    }
}