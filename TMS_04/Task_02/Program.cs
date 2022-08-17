namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary translator = new Dictionary();
            Console.WriteLine("Введите слово для перевода на английский язык\n" +
                "Чтобы узнать слова доступные для перевода напишите: Exists\n" +
                "Для выхода из программы напишите Exit");

            bool isExit = true;
            while (isExit)
            {
                string? word = Console.ReadLine();
                if (word.ToLower() == "exists")
                    translator.DictionaryList();
                else if (word.ToLower() == "exit")
                    isExit = false;
                else
                    translator.Translate(word);
            }
        }
    }
}
/*
 4. Создать программу-переводчик, которая знает 10 английских слов. 
Пользователь должен ввести слово на английском, программа выводит перевод на русском. 
В случае если слова нет, то нужно вывести на консоль сообщение "Слово не было найдено". 
Для решения задачи можно использовать класс Dictionary<string, string> и методы этого класса, такие как ContainsKey()*/
