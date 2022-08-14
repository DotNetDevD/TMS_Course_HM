namespace Task_01
{
    internal class Program
    {
        public static void Swop(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Input()
        {
            string temp = Console.ReadLine();

            if (!int.TryParse(temp, out int n))
            {
                while (!int.TryParse(temp, out n))
                {
                    Console.WriteLine("Неверный ввод, введите число");
                    temp = Console.ReadLine();
                }
            }
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа по нахождению некоторых значений массива\nВыберите какой Ранг массива:\n" +
                "1 - Одномерный\n" +
                "2 - Двумерный");

            int rank = Input();

            while (!rank.In(1, 2))
            {
                Console.WriteLine("Неверное число - попробуйте 1 или 2");
                rank = Input();
            }

            switch (rank)
            {
                case 1:
                    RandomOneRankArray oneRank = new();
                    oneRank.ShowInfo();
                    oneRank.BubbleSort();
                    oneRank.MergeSort();
                    break;
                case 2:
                    RandomTwoRankArray twoRank = new();
                    twoRank.ShowInfo();
                    twoRank.BubbleSort();
                    twoRank.MergeSort();
                    break;
            }

            Console.WriteLine("Для выхода нажмите любую кнопку");
            Console.ReadKey();
        }

    }
}
/*2. Создать консольное приложение:
    - Приложение должно создавать массив целых чисел, размер которого должен задавать пользователь с клавиатуры.
    - Массив необходимо заполнить произвольными целыми числами (для генерации чисел нужно использовать     
        Random rand = new Random();
        int value = rand.Next(-100, 100);). Сгенерированный массив необходимо вывести на экран
    - С помощью математических операций, условий и циклов на консоль необходимо вывести наибольшее значение в массиве, 
    наименьшее значение в массиве, общую сумму всех элементов, среднее арифметическое всех элементов. 
Вычисленные значения необходимо вывести на экран
   - Программа должна ожидать нажатия клавиши клавиатуры для завершения работы программы.
   * Выполнить сортировку элементов массива по убыванию и вывести результат на экран, без использования методов класса Array.
3. * Тоже самое только массив должен быть двумерный - матрица.
*/