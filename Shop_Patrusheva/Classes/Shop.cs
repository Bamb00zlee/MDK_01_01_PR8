using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Patrusheva.Classes
{
    public class Shop
    {
        public string Name;
        public int Price;

        public Shop(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
