using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class ShopItem
    {
        public string Name { get; }
        public string Description { get; }
        public int Price { get; }
        public int Quantity { get; }

        public ShopItem(string name, string description, int price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

    }
}
