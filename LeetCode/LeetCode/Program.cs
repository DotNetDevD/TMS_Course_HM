namespace LeetCode
{
    internal class Program
    {
        static int BinarySearch(int[] array, int searchedValue)
        {
            /* Алгоритм заключается в следующем:
             * Определяем значение элемента в середине рабочей области массива данных и сравниваем его с искомым;
             * Если они равны, возвращаем индекс середины;
             * Если значение элемента в середине массива больше искомого, то поиск продолжается в левой, от среднего 
               элемента, части массива, иначе в правой;
             * Проверяем не сошлись ли границы рабочей области, если да - искомого значения нет, нет - переходим на 
               первый шаг. */
            int left = 0;
            int right = array.Length - 1;
            //пока не сошлись границы массива
            while (left <= right)
            {
                //индекс среднего элемента
                var middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {
                    //сужаем рабочую зону массива с правой стороны
                    right = middle - 1;
                }
                else
                {
                    //сужаем рабочую зону массива с левой стороны
                    left = middle + 1;
                }
            }
            //ничего не нашли
            return -1;
        }
        static int BinarySearch(int[] array, int searchedValue, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            //int mid = left + (right - left) / 2;
            var mid = (left + right) / 2;

            if (searchedValue == array[mid])
            {
                return mid;
            }
            else
            {
                if (searchedValue < array[mid])
                    return BinarySearch(array, searchedValue, left, mid - 1);
                else
                    return BinarySearch(array, searchedValue, mid + 1, right);
            }

        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 9 };
            Console.WriteLine(BinarySearch(array, 10));
            Console.WriteLine(BinarySearch(array, 5));
            int left = 0;
            int right = array.Length - 1;
            Console.WriteLine(BinarySearch(array, 1, left, right));
        }
    }
}