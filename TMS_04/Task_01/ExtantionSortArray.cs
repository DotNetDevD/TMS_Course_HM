using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    static class ExtantionSortArray
    {
        static void Swop(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Немного улучшенная сортировка пузырьком
        public static void BubbleSort(this int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length - i; j++)
                {
                    if (a[j] > a[j - 1])
                    {
                        Swop(ref a[j], ref a[j - 1]);
                    }
                }
            }
        }

        // Cортировка слиянием
        public static void DoMergeSort(int[] a)
        {
            if (a.Length == 1)
                return;

            int mid = a.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[a.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = a[i];
            }

            for (int i = mid; i < a.Length; i++)
            {
                right[i - mid] = a[i];
            }

            MergeSort(left);
            MergeSort(right);
            Merge(a, left, right);
        }

        public static void MergeSort(this int[] a)
        {
            DoMergeSort(a);
        }

        private static void Merge(int[] dist, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int distIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] >= right[rightIndex])
                {
                    dist[distIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    dist[distIndex] = right[rightIndex];
                    rightIndex++;
                }
                distIndex++;
            }

            while (leftIndex < left.Length)
            {
                dist[distIndex] = left[leftIndex];
                leftIndex++;
                distIndex++;
            }

            while (rightIndex < right.Length)
            {
                dist[distIndex] = right[rightIndex];
                rightIndex++;
                distIndex++;
            }
        }
    }
}
