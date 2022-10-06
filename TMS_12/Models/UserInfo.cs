namespace test.Models
{
    public class UserInfo
    {
        public string? UserName { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public string? Male { get; set; }
        public string? BirthdayDate { get; set; }
        public string? AboutYourself { get; set; }
        public UserInfo() { }
        public UserInfo(string? userName, string? surname, string? patronymic, string? male, 
            string? birthdayDate, string? aboutYourself)
        {
            UserName = userName;
            Surname = surname;
            Patronymic = patronymic;
            Male = male;
            BirthdayDate = birthdayDate;
            AboutYourself = aboutYourself;
        }
        public override string ToString()
        {
            return $"UserName: {UserName}, Surname: {Surname}, " +
                   $"Patronymic: {Patronymic}, Male: {Male}, Birthday: {BirthdayDate}, AboutYourself: {AboutYourself}";
        }
    }
}
