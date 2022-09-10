using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_AttributePractice
{
    [AccessLevel(AccesLevelType.PublicTrust)]
    internal class Worker : Employee
    {
        public string Name { get; private set; }
        
        public Worker(string name)
        {
            Name = name;
        }
    }
}
