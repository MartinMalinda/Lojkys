using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")] //webshop
        public IActionResult Index()
        {
            return View();
        }      
    }
}