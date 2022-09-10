using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_AttributePractice
{
    [AccessLevel(AccesLevelType.MinorLevelSecret)]
    internal class Manager: Employee
    {
        public string Name { get; private set; }
        public Manager(string name)
        {
            Name = name;
        }
    }
}
