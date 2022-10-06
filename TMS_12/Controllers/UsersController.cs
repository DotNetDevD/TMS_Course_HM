using Microsoft.AspNetCore.Mvc;
using test.Models;
using Newtonsoft.Json;

namespace test.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetUserInfo(string button, string userName, string surname,
            string patronymic, string male, string birthdayDate, string aboutYourself)
        {
            UserInfo user = new(userName, surname, patronymic, male, birthdayDate, aboutYourself);
            using (StreamWriter writer = new StreamWriter(@"D:\user.json", true))
            {
                string s = JsonConvert.SerializeObject(user);
                writer.WriteLine(s);
            }
            return View("Registration");
        }
        public IActionResult UserBase(string button)
        {
            List<UserInfo> users = new();
            string[] lines = System.IO.File.ReadAllLines(@"D:\user.json");
            foreach (string s in lines)
            {
                users.Add(JsonConvert.DeserializeObject<UserInfo>(s));
            } 
            return View("UserBase", users);
        }
    }
}
