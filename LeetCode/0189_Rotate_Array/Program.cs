namespace _0189_Rotate_Array
{
    internal class Program
    {
        static void Rotate(int[] arr, int k)
        {
            k %= arr.Length;
            int[] extendArr = new int[arr.Length + arr.Length];
            arr.CopyTo(extendArr, 0);
            arr.CopyTo(extendArr, arr.Length);
            for (int i = arr.Length - k, j = 0; j < arr.Length; i++, j++)
            {
                arr[j] = extendArr[i];
            }
        }
        static void Rotate2(int[] arr, int k)
        {
            k %= arr.Length;

            Array.Reverse(arr, 0, arr.Length - k);
            Array.Reverse(arr);
            Array.Reverse(arr, 0, k);
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int[] test = { -1 };
            int[] test2 = { -1, -100, 3, 99 };
            Rotate2(test2, 2);
            for (int i = 0; i < test2.Length; i++)
            {
                Console.Write(test2[i] + " ");
            }
        }
    }
}