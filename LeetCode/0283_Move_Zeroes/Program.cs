namespace _0283_Move_Zeroes
{
    internal class Program
    {
        static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] == 0)
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        static void MoveZeroes1(int[] nums)
        {
            int notZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[notZero++] = nums[i];
                }
            }
            for (int i = notZero; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        static void MoveZeroes2(int[] nums)
        {
            int lastNonZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var x = nums[i];
                    nums[i] = nums[lastNonZero];
                    nums[lastNonZero++] = x;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] test = { 0, 1, 0, 3, 12, 0 };

            MoveZeroes2(test);
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
        }
    }
}
// https://leetcode.com/problems/move-zeroes/