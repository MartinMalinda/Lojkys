using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Models
{
    [Route("api")]
    public class RestController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            var greeting = new Greeting();
            //greeting.Content = Request.Query["Hello, World!"];
            //greeting.ID = Convert.ToInt64(Request.Query["id"]);
            return new Greeting(Greeting.counter++, $"Hello, {name}");
        }
    }
}
