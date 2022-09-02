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
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int[] test = { -1 };
            Rotate(test, 2);
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
        }
    }
}