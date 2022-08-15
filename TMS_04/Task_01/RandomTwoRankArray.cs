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

        // Переопределение метода ToString, для вывода массива
        public override string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result += string.Format("{0,4}", a[i, j]);
                }
                result += "\n";
            }
            return result;
        }

        public RandomTwoRankArray(int row, int column)
        {
            a = new int[row, column];
            a.FillRandNum(); // заполняем массив
        }

        public RandomTwoRankArray(int[,] a)
        {
            this.a = a;
        }

        public void ShowInfo()
        {
            Console.WriteLine(this); // выводим
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

            RandomTwoRankArray bubbleSortArray = new(sortedArray);
            Console.WriteLine(bubbleSortArray);
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

            RandomTwoRankArray mergeSortArray = new(sortedArray);
            Console.WriteLine(mergeSortArray);
        }
    }
}