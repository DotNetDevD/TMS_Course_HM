using Task_02_Serialize;
using System.Xml.Serialization;
using System.Text.Json;


Point squarePoint = new(10, 10);
Shape square = new(squarePoint, 100, 100, "Square");
Shape rectangle = new(new Point(20, 20), 100, 200, "Rectangle");
Shape romb = new(new Point(30, 30), 50, 50, "Romb");

Shape[] shapes = new Shape[] { square, rectangle, romb };
XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shape[]));

Console.WriteLine("Введите название файла для Xml сериализации: ");
string pathXmlSerializeName = CorrectFileName();
XmlSerialize(pathXmlSerializeName, xmlSerializer, shapes);

Console.WriteLine("Введите название файла для Xml десериализации: ");
Shape[]? newXmlShapes = isXmlDeserialize(pathXmlSerializeName, xmlSerializer, shapes);
ShowShapes(newXmlShapes);

Console.WriteLine(new string('-', 45));

Console.WriteLine("Введите название файла для Json сериализации: ");
string pathJsonSerializeName = CorrectFileName();
JsonSerialize(pathJsonSerializeName, shapes);

Console.WriteLine("Введите название файла для Json десериализации: ");
Shape[]? newJsonShapes = isJsonDeserialize(pathJsonSerializeName, shapes);
ShowShapes(newJsonShapes);

Console.WriteLine(new string('-', 45));

Console.WriteLine("Введие название файла для Newtonsoft.Json сериализации:");
NewtonsoftJson newtonsoft = new();
string pathNewtonsoftSerializeName = CorrectFileName();
newtonsoft.Serialize(shapes, pathNewtonsoftSerializeName);

Console.WriteLine("Введие название файла для Newtonsoft.Json десериализации:");
string pathNewtonsoftDeserializeName = CorrectFileName();
Shape[] newtonsoftJsonShapes = newtonsoft.Deseralize(shapes, pathNewtonsoftDeserializeName);
ShowShapes(newtonsoftJsonShapes);

static void ShowShapes(Shape[] shapes)
{
    if (shapes != null)
    {
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name} --- Length: {shape.Length} --- Height: {shape.Height}");
        }
    }
    else
    {
        Console.WriteLine("Список пуст");
    }
}

static string CorrectFileName()
{
    string? fileName = Console.ReadLine();
    string sourceFolder = @"D:\";
    if (!string.IsNullOrEmpty(fileName) && fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 &&
              !File.Exists(Path.Combine(sourceFolder, fileName)))
    {
        return fileName;
    }
    else
    {
        throw new Exception("Неверный ввод имя файла");
    }
}

static void XmlSerialize(string pathName, XmlSerializer xmlSerializer, Shape[] shapes)
{
    string xmlPathSerializer = @$"D:\{pathName}.xml";
    using (FileStream fs = new FileStream(xmlPathSerializer, FileMode.OpenOrCreate))
    {
        xmlSerializer.Serialize(fs, shapes);
    }
    Console.WriteLine("Object has been XML serialized");
}

static Shape[] XmlDeserialize(string pathName, XmlSerializer xmlSerializer, Shape[] shapes)
{
    string xmlPathDeserializer = $@"D:\{pathName}.xml";
    using (FileStream fs = new FileStream(xmlPathDeserializer, FileMode.OpenOrCreate))
    {
        shapes = xmlSerializer.Deserialize(fs) as Shape[];
    }
    Console.WriteLine("XML Deserialize");

    return shapes;
}

static Shape[] isXmlDeserialize(string pathXmlSerializeName, XmlSerializer xmlSerializer, Shape[] shapes)
{
    bool isDeserialize = true;
    Shape[]? newXmlShapes = null;
    do
    {
        try
        {
            string pathName = CorrectFileName();
            newXmlShapes = XmlDeserialize(pathName, xmlSerializer, shapes);
            isDeserialize = false;
        }
        catch
        {
            Console.WriteLine("Невозможно десериализовать данный файл!");
            Thread.Sleep(1500);
            Console.WriteLine($"Не унывай! Попробуй название этого файла: {pathXmlSerializeName}");
            isDeserialize = true;
        }
    } while (isDeserialize);

    return newXmlShapes;
}

static void JsonSerialize(string pathName, Shape[] shapes)
{
    string jsonPathSerializer = @$"D:\{pathName}.json";
    using (FileStream fs = new FileStream(jsonPathSerializer, FileMode.OpenOrCreate))
    {
        JsonSerializer.Serialize(fs, shapes);
    }
    Console.WriteLine("Object has been JSON serialized");
}

static Shape[] JsonDeserialize(string pathName, Shape[] shapes)
{
    string jsonPathDeserializer = @$"D:\{pathName}.json";
    string jsonString = File.ReadAllText(jsonPathDeserializer);
    shapes = JsonSerializer.Deserialize<Shape[]>(jsonString)!;
    Console.WriteLine("JSON Deserialize");
    return shapes;
}

static Shape[] isJsonDeserialize(string pathJsonSerializeName, Shape[] shapes)
{
    Shape[]? newJsonShapes = null;
    bool isDeserialize = true;
    do
    {
        try
        {
            string pathName = CorrectFileName();
            newJsonShapes = JsonDeserialize(pathName, shapes);
            isDeserialize = false;
        }
        catch
        {
            Console.WriteLine("Невозможно десериализовать данный файл!");
            Thread.Sleep(1500);
            Console.WriteLine($"Не унывай! Попробуй название этого файла: {pathJsonSerializeName}");
            isDeserialize = true;
        }

    } while (isDeserialize);
    return newJsonShapes;
}

/*
3. Написать программу выполняющую сериализацию и десериализацию. Создать класс Point со свойствами float X, float Y. 
Создать класс Shape со свойствами Point ShapePoint, float Length, float Height, string Name. 
В методе Main создать массив из заполненных элементов типа Shape. Выполнить сериализацию и десериализацию этого массива. 
Название файла для сериализации и десериализации вводить с клавиатуры. Сериализуемые форматы XML и JSON. 
Так же необходимо использовать блоки для обработки исключений.
После выполнения задания, скачать nuget-пакет Newtonsoft.Json. 
Попробовать выполнить сериализацию с помощью Json сериализатора из этого пакета
*/
