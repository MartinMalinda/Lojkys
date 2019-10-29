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
        static List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                new BankAccount("Superman", 5000, "$", "Hero", BankAccount.Type.King),
                new BankAccount("Joker", 3000, "$", "Bastard", BankAccount.Type.Loser),
                new BankAccount("Rocky Balboa", 10000, "$", "Boxer", BankAccount.Type.King),
                new BankAccount("Jaromir Jagr", 10, "$", "Hockey Player", BankAccount.Type.King),
                new BankAccount("Milos Zeman", 0, "Idiot!!!", BankAccount.Type.Loser)
            };

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("show")]
        public IActionResult Show()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, "Zebra", "lion", BankAccount.Type.King);

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
            return View(bankAccounts);
        }

        [Route("add")]
        public IActionResult Add(string name, double balance, string currency, string occupation)
        {
            bankAccounts.Add(new BankAccount(name, balance, currency, occupation, BankAccount.Type.Loser));
            return RedirectToAction("accounts");
        }

        [Route("form")]
        public IActionResult Form()
        {
            return View();
        }
    }
}