using Task_01_Dictionary;

ApplicationDictionary<string, string> dictionary = new ApplicationDictionary<string, string>();
dictionary.Add("машина", "car");
dictionary.Add("камень", "stone");
dictionary.Add("ножницы", "scissors");
dictionary.Add("бумага", "paper");
Console.WriteLine(dictionary["машина"]);
Console.WriteLine(dictionary["..."]);
dictionary.Remove("машина");
dictionary.ListOfKey();
//dictionary.GetValueByKey("машина");

ApplicationDictionary<int, Person> dictionary1 = new ApplicationDictionary<int, Person>();
Person p1 = new("Valery", 54);
Person p2 = new("Ibragim", 25);
Person p3 = new("Masha", 18);
dictionary1.Add(1, p1);
dictionary1.Add(2, p2);
dictionary1.Add(3, p3);
dictionary1.ListOfKey();
Person p = dictionary1.GetValueByKey(1);
Console.WriteLine(p.Name);
dictionary1.Remove(3);
Console.WriteLine(dictionary1[3]);

/*
Реализовать простейший вариант класса Dictionary<TKey, TValue>, например 
ApplicationDictionary<TKey, TValue>. Класс должен предоставлять возможность добавления элемента в словарь, 
удаления элемента, получения элемента по ключу, получение списка всех ключей.
*/