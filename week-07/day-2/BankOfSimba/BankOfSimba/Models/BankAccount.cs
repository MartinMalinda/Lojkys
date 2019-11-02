using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; } = "CZK";
        public string Occupation { get; set; }
        public Type TypeOf { get; set; }
        public enum Type { King, Loser};

        public BankAccount(string name, double balance, string currency, string occupation, Type type)
        {
            Name = name;
            Balance = balance;
            Currency = currency;
            Occupation = occupation;
            TypeOf = type;
        }
        public BankAccount(string name, double balance, string occupation, Type type)
        {
            Name = name;
            Balance = balance;
            Occupation = occupation;
            TypeOf = type;
        }
    }


}
