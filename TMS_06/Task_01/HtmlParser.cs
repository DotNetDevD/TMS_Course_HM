using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class HtmlParser : FileParser
    {
        FileInfo fileInfo;
        string path;
        public HtmlParser(string fileName) : base(fileName)
        {
            path = $@"D:\{fileName}";
        }

        public override string ParserFormat => ".html";

        public override void Open()
        {
            fileInfo = new FileInfo(path);
        }
        public override void Read()
        {
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }
        public override void Analize()
        {
            if (fileInfo.Exists)
            {
                Console.WriteLine($"{nameof(HtmlParser)}: Файл {FileName}, был проанализирован");
                Console.WriteLine($"Имя файла: {fileInfo.Name}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length}");
            }
        }
        public override void Close()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {FileName}, был закрыт");
        }
    }
}
