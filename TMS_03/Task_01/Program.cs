namespace Task_01
{
    internal class Program
    {
        /// <summary>
        /// Обмен двух чисел с использованием буфера
        /// </summary>
        public static void Swap1(ref long a, ref long b)
        {
            long c;
            c = a; // Сейчас в a записана a, в b — b, а в c — a.
            a = b; // Теперь в a хранится b, в b — также b и в c — a.
            b = c; // Сейчас в a находится старое значение b, в b — a, ну и в c остаётся a.
        }

        /// <summary>
        /// Обмен двух чисел арифметически (Сложение / Вычитание)
        /// </summary>
        public static void Swap2(ref long a, ref long b)
        {
            a = a + b; // Сeйчас в a записано значение a + b, а в b всё ещё b.
            b = a - b; // В a также хранится a + b, но в b уже a.
            a = a - b; // В a теперь содержится b, а в b — a.
        }

        /// <summary>
        /// Обмен двух чисел арифметически (Умножение / деление)
        /// </summary>
        public static void Swap3(ref long a, ref long b)
        {
            a = a * b;
            b = a / b; // деление НЕ целочисленное
            a = a / b;
        }

        /// <summary>
        /// Обмен двух чисел побитовой операцией XOR
        /// </summary>
        public static void Swap4(ref long a, ref long b)
        {
            //Пример для a = 101 (в двоичной системе) и b = 110
            a = a ^ b; // a = 101^110 = 011
            b = b ^ a; // b = 011^110 = 101
            a = a ^ b; // a = 011^101 = 110
        }

        /// <summary>
        /// Проверка строки, конвертируемой в число
        /// </summary>
        public static bool CheckNumber(string s, out long num)
        {
            bool isNumber = true;
            try
            {
                num = Convert.ToInt64(s);
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
        public static long InputNumber()
        {
            string? strNum = Console.ReadLine();
            long num;
            if (CheckNumber(strNum, out num))
            {
                num = Convert.ToInt64(strNum);
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

        static void Main(string[] args)
        {
            Console.WriteLine("Консольное приложение для обмена значениями двух переменных");
            Console.Write("Введите первое число = ");
            long firstNum = InputNumber();
            Console.Write("Введите второе число = ");
            long secondNum = InputNumber();
            Console.WriteLine($"Значение ваших чисел до обмена\n" +
                              $"1 = {firstNum}\n2 = {secondNum}");

            Console.WriteLine("Каким споособом будем менять числа? (Нажать цифру для выбора)\n" +
                              "1. С использованием буфера (3 переменной)\n" +
                              "2. Aрифметически (Сложение / Вычитание)\n" +
                              "3. Aрифметически (Умножение / деление)\n" +
                              "4. Побитовой операцией XOR");

            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Swap1(ref firstNum, ref secondNum);
                    break;
                case "2":
                    Swap2(ref firstNum, ref secondNum);
                    break;
                case "3":
                    if (firstNum != 0 && secondNum != 0)
                    {
                        Swap3(ref firstNum, ref secondNum);
                    }
                    else
                        Console.WriteLine("К сожаление данных способ не подерживает если одно из чисел равно 0");
                    break;
                case "4":
                    Swap4(ref firstNum, ref secondNum);
                    break;
                default:
                    Console.WriteLine("Что-то пошло не так...");
                    break;
            }

            Console.WriteLine($"Значение ваших чисел после обмена\n" +
                              $"1 = {firstNum}\n2 = {secondNum}");
        }
    }
}
// Составить программу обмена значениями двух переменных (при возможности не создавать третью переменную).