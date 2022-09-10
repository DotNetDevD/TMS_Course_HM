Book book = new("CLR via C#", 100);
book.GetName();
book.SetPrice(200);
Console.WriteLine(book.Price);

class Book
{
    public string Name { get; private set; }
    public int Price { get; private set; }

    public Book(string name, int price)
    {
        Name = name;
        price = price;
    }
    [Obsolete("Обращайтесь непосредственно к полю Name")]
    public void GetName()
    {
        Console.WriteLine(Name);
    }
    [Obsolete("Назначение прайса только через конструктор!", true)]
    public void SetPrice(int sum)
    {
        Price = sum;
    }
}