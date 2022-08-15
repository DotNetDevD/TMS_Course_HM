using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class RandomOneRankArray
    {
        int[] a;

        // Переопределение метода ToString, для вывода массива
        public override string ToString()
        {
            string result = string.Join(", ", a);
            return result;
        }

        public RandomOneRankArray(int length)
        {
            a = new int[length];
            a.FillRandNum(); // заполняем массив
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
            a.BubbleSort();
            Console.WriteLine(this);
        }

        public void MergeSort()
        {
            Console.WriteLine("Сортировка слиянием: ");
            a.MergeSort();
            Console.WriteLine(this);
        }

    }
}
