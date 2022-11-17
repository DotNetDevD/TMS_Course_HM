using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TMS_13.Filters;
using TMS_13.Models;

namespace TMS_13.Controllers
{
    public class HomeController : Controller
    {
        List<Worker> dbWorkers = new List<Worker>() 
        { 
            new Worker("Степан", 20, DateOnly.Parse("06.01.2002"), "Минск"), 
            new Worker("Артем", 40, DateOnly.Parse("06.01.1982"), "Гомель"), 
            new Worker("Виктор", 37, DateOnly.Parse("06.01.1985"), "Орша") 
        };
        [HttpGet]
        public IActionResult Index()
        {
            Worker worker = null;
            try
            {
                string? name = Request.Query["name"];
                int? age = Convert.ToInt32(Request.Query["age"]);
                DateOnly? dateOnly = DateOnly.Parse(Request.Query["dateOnly"]);
                string? adress = Request.Query["name"];
                worker = new(name, age, dateOnly, adress);
            }
            catch
            {
                Random rand = new Random();
                worker = dbWorkers[rand.Next(3)];
            }
            return View(worker);
        }
        public IActionResult CatchError()
        {
            int x = 0;
            int y = 8 / x;
            return View();
        }
    }
}
