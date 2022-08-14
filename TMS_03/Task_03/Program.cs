using System.Numerics;

namespace Task_03
{
    internal class Program
    {
        /// <summary>
        /// Проверка строки, конвертируемой в число
        /// </summary>
        public static bool CheckNumber(string s, out BigInteger num)
        {
            bool isNumber = true;
            try
            {
                num = BigInteger.Parse(s);
            }
            catch
            {
                num = 0;
                isNumber = false;
            }
            return isNumber;
        }

        /// <summary>
        /// Ввод числа и проверка его с помощью метода CheckNumber 
        /// </summary>
        public static string InputNumber()
        {
            string? strNum = Console.ReadLine();
            BigInteger num;

            if (!CheckNumber(strNum, out num))
            {
                while (!CheckNumber(strNum, out num))
                {
                    Console.Write("Вас просили ввести число, давайте попробуем снова = ");
                    strNum = Console.ReadLine();
                }
            }
            return strNum;
        }

        /// <summary>
        /// Алгоритм построен на сравнение чаровых значений строкового массива
        /// </summary>
        public static bool isPalidnrome(string s)
        {
            bool answer = true; 
            // Дополнительная проверка, если число отрицательное, убираем в строке 1 символ '-'
            if (s[0] == '-') 
                s = s.Substring(1);
            // Начинаем проверять только числа которые больше 2 символов, тк любая цифра сама по себе палиндром
            if (s.Length >= 2)
                for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
                {
                    if (s[i] != s[j] && i != j)
                    {
                        answer = false;
                        break;
                    }
                }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для определения является ли введенное целочисленное число палиндромом");
            Console.Write("Введите ваше число: ");
            string number = InputNumber();
            if (isPalidnrome(number))
                Console.WriteLine("Данное число является полиндромом");
            else
                Console.WriteLine("Данное число не является полиндромом");
        }
    }
}
/* Реализовать алгоритм, который определяет является ли введенное целочисленное число палиндромом 
   (читается одинаково слева направо и справа налево) */