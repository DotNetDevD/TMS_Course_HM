namespace _0977_Squares_of_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -4, -1, 0, 3, 10 };

            int left = 0;
            int right = a.Length - 1;

            int[] sorted = new int[a.Length];

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(a[left]) > a[right])
                {
                    sorted[i] = a[left] * a[left];
                    left++;
                }
                else
                {
                    sorted[i] = a[right] * a[right];
                    right--;
                }
            }

            for (int i = 0; i < sorted.Length; i++)
                Console.Write(sorted[i] + " ");
        }
    }
}
// https://leetcode.com/problems/squares-of-a-sorted-array/