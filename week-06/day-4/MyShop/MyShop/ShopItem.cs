using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public int QuantityStock { get; set; }

        public ShopItem()
        {

        }
    }
}
