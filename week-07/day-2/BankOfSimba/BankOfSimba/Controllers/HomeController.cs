using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("show")]
        public IActionResult Show()
        {
            BankAccount bankAccount = new BankAccount(1, "Simba", 2000, "Zebra", "lion");

            return View(bankAccount);
        }

        [Route("raw")]
        public IActionResult HtmlRaw()
        {
            return View();
        }

        [Route("accounts")]
        public IActionResult Accounts()
        {
            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                new BankAccount(1, "Superman", 5000, "$", "Hero"),
                new BankAccount(2, "Joker", 3000, "$", "Bastard"),
                new BankAccount(3, "Rocky Balboa", 10000, "$", "Boxer"),
                new BankAccount(4, "Jaromir Jagr", 10, "$", "Hockey Player"),
                new BankAccount(5, "Milos Zeman", 0, "$", "Idiot!!!")
            };

            return View(bankAccounts);
        }
    }
}