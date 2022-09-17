using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Serialize
{
    public class Shape
    {
        public Point ShapePoint { get; set; } = new Point();
        public float Length { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }
        public Shape() { }
        public Shape(Point shapePoint, float length, float height, string name)
        {
            ShapePoint = shapePoint;
            Length = length;
            Height = height;
            Name = name;
        }
    }
}