using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Serialize
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point() { }
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
