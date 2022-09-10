using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_AttributePractice
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class AccessLevelAttribute : Attribute
    {
        public AccesLevelType type;
        public AccessLevelAttribute(AccesLevelType type)
        {
            this.type = type;
        }
    }
}
