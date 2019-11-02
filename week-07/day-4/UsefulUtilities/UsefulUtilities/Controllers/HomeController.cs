using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsefulUtilities.Models;

namespace UsefulUtilities.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private UtilityService us;

        public HomeController(UtilityService color)
        {
            this.us = color;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("colored")]
        public IActionResult Colored()
        {
            return View((object) us.RandomColor());
        }

        [HttpGet]
        [Route("email")]
        public IActionResult Email(string email)
        { 
            var result = us.ValidateEmail(email);
            return View("email", result);
        }

        [Route("caesar")]
        public IActionResult Caesar(string text, int number)
        {
            var result = us.Caesar(text, number);
            return View((object) result);
        }
    }

}