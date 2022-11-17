namespace TMS_13.Models
{
    public class Worker
    {
        public string? Name { get; private set; }
        public int? Age { get; private set; }
        public DateOnly? DateOfBirth { get; private set; }
        public string? Adress { get; private set; }

        public Worker(string? name, int? age, DateOnly? dateOnly, string? adress)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateOnly;
            Adress = adress;
        }
        public override string ToString()
        {
            return $@"Name: {Name},
                      Age: {Age},
                      Date of Birth: {DateOfBirth},
                      Adress: {Adress}.";
        }
    }
}