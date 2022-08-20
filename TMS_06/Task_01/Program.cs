namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла в формате: [имя_файла].[формат]");
            string userFile = Console.ReadLine();
            FileParser findParser = FileParser.GetParser(userFile);

            if (findParser is null)
                Console.WriteLine("К сожалению данные введены не верно.");
            else
                findParser.Parse();
        }
    }
}

/*
 Написать парсер файлов разных форматов:
 Сущности программы:
  - абстрактный класс FileParser, c абстрактными методами 
void Read(), void Open(), void Analize(), void Close() и виртуальным методом void Parse(). 
Необходимо создать абстрактное свойство только для чтения string ParserFormat. 
Так же класс должен иметь поле только для чтения FileName. 
Конструктор должен принимать параметр типа string.
В конструкторе необходимо устанавливать поле FileName. 
В классе реализовать статический метод public static FileParser GetParser(string fileName), 
который создает экземпляр одного из классов XmlParser, RtfParser, HtmlParser, на основании имени файла, 
т.е. нужно получить формат файла из его имени. Ели такого парсера нет, то возвращать null. 
В методе Parse нужно последовательно вызывать методы Open(); Read(); Analize(); Close()
  - Классы XmlParser, RtfParser, HtmlParser, которые наследуют от класса FileParser. 
Каждый метод реализовать примерно так:   
void Read() { Console.WriteLine("{nameof(XmlParser)}: Файл {fileName}, был открыт"); }. 
Реализовать свойство ParserFormat. 
Например для класса XmlParser - ParserFormat { get => ".xml" }
 Сценарий работы приложения:
  - Программа просит пользователя ввести имя файла в формате: [имя_файла].[формат]. 
Возможен один из трех форматов: xml, rtf, html
 - вызывается статический метод FileParser.GetParser, в качестве аргумента передается введенное имя файла. 
затем для возвращенного объекта надо вызвать метод Parse(). 
На консоли должны отобразиться сообщения о работе методов парсера.
 */