namespace _0167_Two_Sum_II
{
    internal class Program
    {
        static int BinarySearch(int[] a, int target)
        {
            int left = 0;
            int right = a.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (a[mid] == target)
                {
                    return right + 1;
                }
                else if (a[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return right;
                }
            }
            return right;
        }
        public static int[] TwoSum(int[] a, int target)
        {
            int min = 0;
            int max = BinarySearch(a, target);

            while (min<max)
            {
                if (a[min] + a[max] == target)
                {
                    return new int[2] { ++min, ++max };
                }
                else if (a[min] + a[max] > target)
                {
                    max--;
                }
                else
                {
                    min++;
                }
            }
            return new int[] { 1, 2 };
        }

        public void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
        static void Main(string[] args)
        {
            int[] test = { 5, 25, 75 };
            int[] test2 = { 2, 7, 11, 15 };
            int[] test3 = { -1, 0 }; // target -1
            int[] test4 = { -3, 3, 4, 90 }; // target 0
            int[] a = TwoSum(test4, 0);
        }
    }
}