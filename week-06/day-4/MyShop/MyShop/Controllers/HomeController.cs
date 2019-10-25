using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        List<ShopItem> listItem = new List<ShopItem>()
        {
            new ShopItem("Running shoes", "Nike running shoes for every day sport", 1000, 5),
            new ShopItem("Printer", "Some HP printer that will print pages", 3000, 2),
            new ShopItem("Coca Cola", "0.5l standard coke", 25, 0),
            new ShopItem("Wokin", "Chicken with fried rice and WOKIN sauce", 119, 100),
            new ShopItem("T-shirt", "Blue with a corgi on a bike", 300, 1)
        };


        [Route("")] //webshop
        public IActionResult Index()
        {
            ViewBag.Items = listItem;
            return View();
        }      
    }
}