using System.ComponentModel;

namespace MatthewJacksonInventorySystem
{
    static class Inventory
    {

        public static int currentPart { get; set; }

        public static BindingList<Product> Products = new BindingList<Product>();
        // public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts = new BindingList<Part>();
        //public static BindingList<Part> AllParts { get; set; }
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(int index)
        {
            Products.RemoveAt(index);
            return true;
        }
        public static Product lookupProduct(int lookupProductId)
        {
            return Inventory.Products[1];
        }
        public static void updateProduct(int id, Product product)
        {

        }
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public static bool deletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }
        public static Part lookupPart(int lookupPartId)
        {
            return AllParts[lookupPartId];
        }
        public static void updatePart(int id, Part part)
        {

        }
    }
}
