using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    abstract class FileParser
    {
        public string FileName { get; }

        public FileParser(string fileName) => FileName = fileName;
        
        public abstract string ParserFormat { get; }

        public abstract void Open();
        public abstract void Read();
        public abstract void Analize();
        public abstract void Close();

        public void Parse()
        {
            Open(); Read(); Analize(); Close();
        }

        public static FileParser GetParser(string fileName)
        {
            FileParser ourTypeParser;

            if (fileName.EndsWith(".xml"))
                ourTypeParser = new XmlParser(fileName);
            else if (fileName.EndsWith(".rtf"))
                ourTypeParser = new RtfParser(fileName);
            else if (fileName.EndsWith(".html"))
                ourTypeParser = new HtmlParser(fileName);
            else
                ourTypeParser = null;

            return ourTypeParser;
        }
    }
}


/*
 Сущности программы:
В классе реализовать статический метод public static FileParser GetParser(string fileName), 
который создает экземпляр одного из классов XmlParser, RtfParser, HtmlParser, на основании имени файла, 
т.е. нужно получить формат файла из его имени. Ели такого парсера нет, то возвращать null. 
В методе Parse нужно последовательно вызывать методы Open(); Read(); Analize(); Close()
  - Классы XmlParser, RtfParser, HtmlParser, которые наследуют от класса FileParser. 
Каждый метод реализовать примерно так:   
void Read() { Console.WriteLine("{nameof(XmlParser)}: Файл {fileName}, был открыт"); }. 
Реализовать свойство ParserFormat. Например для класса XmlParser - ParserFormat { get => ".xml" }
 Сценарий работы приложения:
  - Программа просит пользователя ввести имя файла в формате: [имя_файла].[формат]. 
Возможет один из трех форматов: xml, rtf, html
 - вызывается статический метод FileParser.GetParser, в качестве аргумента передается введенное имя файла. 
затем для возвращенного объекта надо вызвать метод Parse(). На консоли должны отобразиться сообщения о работе методов парсера.
 */