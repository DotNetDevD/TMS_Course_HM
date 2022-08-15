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

        public RandomOneRankArray()
        {
            Console.Write("Введите длину одномерного массива: ");
            int length = Program.Input();
            while (length < 1)
            {
                Console.Write("Длина не может быть меньше 1 элемента: ");
                length = Program.Input();
            }
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
