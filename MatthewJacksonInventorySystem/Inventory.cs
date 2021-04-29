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

        public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts { get; set; }
        public static void addProduct(Product product)
        {
          
        }
        public static bool removeProduct(int removeCount)
        {
     
        }
        public static Product lookupProduct(int lookupProductId)
        {
            
        }
        public static void updateProduct(int id, Product product)
        {

        }
        public static void addpart(Part part)
        {

        }
        public static bool deletePart(Part part)
        {

        }
        public static Part lookupPart(int lookupPartId)
        {

        }
        public static void updatePart(int id, Part part)
        {

        }
    }
}
