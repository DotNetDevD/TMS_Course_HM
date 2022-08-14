using System.Numerics;

namespace Task_02
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
        public static BigInteger InputNumber()
        {
            string? strNum = Console.ReadLine();
            BigInteger num;

            if (CheckNumber(strNum, out num))
            {
                num = BigInteger.Parse(strNum);
            }
            else
            {
                while (!CheckNumber(strNum, out num))
                {
                    Console.Write("Вас просили ввести число, давайте попробуем снова = ");
                    strNum = Console.ReadLine();
                }
            }
            return num;
        }

       /// <summary>
       /// Метод сравнения двух чисел
       /// </summary>
        public static void Comparation(BigInteger a, BigInteger b)
        {
            if (a > b) Console.WriteLine($"{a} > {b}");
            else if (a < b) Console.WriteLine($"{a} < {b}");
            else if (a == b) Console.WriteLine($"{a} = {b}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа сравнение двух введенных с клавиатуры чисел");
            bool isExit = true;

            while (isExit)
            {
                Console.Write("Введите первое число = ");
                BigInteger firstNum = InputNumber();
                Console.Write("Введите второе число = ");
                BigInteger secondNum = InputNumber();
                Comparation(firstNum, secondNum);
                Console.WriteLine("Желаете продолжить? (Для выхода из программы напишите нет)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "нет")
                    isExit = false;
            }
        }
    }
}
/*Реализовать сравнение двух введенных с клавиатуры чисел. 
  После сравнения, программа не должна закрываться, а должна ожидать ввод следующих цифр для сравнения. */