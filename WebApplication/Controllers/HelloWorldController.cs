using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name = "User", int numTimes = 1, int id = 5)
        {
            ViewData["Name"] = name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IActionResult Results()
        {
            return View();
        }

        public IActionResult PrintData(Calculus input)
        {
            ViewData["Value"] = input.WindowSize;
            ViewData["Array"] = input.ListOfNumbers;
            ViewData["Output"] = input.Calculate();
            
            return View();
        }
    }
}