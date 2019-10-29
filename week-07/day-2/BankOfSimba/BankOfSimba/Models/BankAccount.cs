using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public string Occupation { get; set; }

        public BankAccount(int id, string name, double balance, string currency, string occupation)
        {
            ID = id;
            Name = name;
            Balance = balance;
            Currency = currency;
            Occupation = occupation;
        }
    }


}
