using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Dictionary
{
    internal class ApplicationDictionary<T, V>
    {
        private Dictionary<T, V> dictionary;

        public ApplicationDictionary()
        {
            dictionary = new Dictionary<T, V>();
        }
        public void Add(T key, V value)
        {
            dictionary.Add(key, value);
        }
        public void Remove(T key)
        {
            dictionary.Remove(key, out V? value);
            Console.WriteLine($"По ключу: <{key}> был удален элемент: <{value}>");
        }
        public void ListOfKey()
        {
            foreach (var key in dictionary)
            {
                Console.WriteLine(key.Key);
            }
        }
        public bool ContainsKey(T key)
        {
            return dictionary.ContainsKey(key);
        }
        public V GetValueByKey(T key)
        {
            if (ContainsKey(key))
            {
                dictionary.TryGetValue(key, out V? value);
                return value;
            }
            else
            {
                throw new Exception("Данного ключа нет в словаре");
            }
        }
        // Второй вариант получения элемента по ключу через индексатор
        public string this[T key]
        {
            get
            {
                string getValue = string.Empty;
                if (ContainsKey(key))
                {
                    dictionary.TryGetValue(key, out V? value);
                    getValue = $"По ключу: <{key}> был найден элемент: <{value}>";
                }
                else
                {
                    getValue = $"По ключу: <{key}> элемента в словаре не найдено";
                }
                return getValue;
            }
        }
    }
}
