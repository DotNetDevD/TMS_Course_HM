using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_AttributePractice
{
    [AccessLevel(AccesLevelType.TopLevelSecret)]
    internal class Director: Employee
    {
        public string Name { get; private set; }
        public Director(string name)
        {
            Name = name;
        }
    }
}
