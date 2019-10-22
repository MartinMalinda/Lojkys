using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Models
{
    [Route("web")]
    public class WebController : Controller
    {
        // GET: /<controller>/
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                ID = 1,
                Content = "from the model"
            };

            return View(greeting);
        }
    }
}
