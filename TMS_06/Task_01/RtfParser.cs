using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class RtfParser : FileParser
    {
        public RtfParser(string fileName) : base(fileName)
        {
        }

        public override string ParserFormat { get => $"{nameof(RtfParser)}: Файл {FileName}"; }

        public override void Open() => Console.WriteLine($"{ParserFormat}, был открыт");
        public override void Read() => Console.WriteLine($"{ParserFormat}, был считан");
        public override void Analize() => Console.WriteLine($"{ParserFormat}, был проанализирован");
        public override void Close() => Console.WriteLine($"{ParserFormat}, был закрыт");
    }
}
