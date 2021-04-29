using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewJacksonInventorySystem
{
    static class Inventory
    {
        public static BindingList<Product> ProductBL = new BindingList<Product>();
        // ProductBL.Add(new Product(1, "Pin", 27, 499:M));
        public static BindingList<Product> Products { get; set; }

        public static void addProduct(Product product)
        {
          
        }
    }
}
