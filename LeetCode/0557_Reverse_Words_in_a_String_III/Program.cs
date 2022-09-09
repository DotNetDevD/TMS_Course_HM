namespace _0557_Reverse_Words_in_a_String_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            string[] a = s.Split();
            string answer = String.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                char[] ss = a[i].ToCharArray();
                Array.Reverse(ss);
                s = new string(ss);
                answer += s + " ";
            }
            Console.WriteLine(answer.Trim());
        }
    }
}