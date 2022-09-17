using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task_02_Serialize
{
    internal class NewtonsoftJson
    {
        public void Serialize(Shape[] shapes, string pathName)
        {
            string pathNewtonsoftSerializeName = @$"D:\{pathName}.xml";
            string s = JsonConvert.SerializeObject(shapes);
            File.WriteAllText(pathNewtonsoftSerializeName, s);
            Console.WriteLine("Object has been Newtonsoft.Json serialized");
        }
        public Shape[] Deseralize(Shape[] shapes, string pathName)
        {
            string pathNewtonsoftSerializeName = @$"D:\{pathName}.xml";
            string path = File.ReadAllText(pathNewtonsoftSerializeName);
            Shape[]? newShapes = JsonConvert.DeserializeObject<Shape[]>(path);
            Console.WriteLine("Newtonsoft.Json Deserialize");
            return newShapes!;
        }
    }
}
