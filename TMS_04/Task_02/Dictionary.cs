using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Dictionary
    {
        Dictionary<string, string> numbers;

        public Dictionary()
        {
            numbers = new Dictionary<string, string>()
            {
                ["один"] = "one",
                ["два"] = "two",
                ["три"] = "three",
                ["четыре"] = "four",
                ["пять"] = "five",
                ["шесть"] = "six",
                ["семь"] = "seven",
                ["восемь"] = "eight",
                ["девять"] = "nine",
                ["десять"] = "ten",
            };
        }
        public void Translate(string s)
        {
            s = s.ToLower();
            string answer = String.Empty;

            if (numbers.ContainsKey(s))
                answer = numbers[s];
            else
                answer = "Слово не было найдено";

            Console.WriteLine(answer);
        }

        public void DictionaryList()
        {
            Console.WriteLine("Данный словарь содержить следующие слова для перевода: ");

            Dictionary<string, string>.KeyCollection keyColl = numbers.Keys;

            string list = "";
            foreach (string s in keyColl)
            {
                list += s + ", ";
            }
            list = list.Remove(list.Length - 2);
            Console.WriteLine(list);
        }
    }
}
