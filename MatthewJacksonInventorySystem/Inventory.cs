using System.ComponentModel;

namespace MatthewJacksonInventorySystem
{
    static class Inventory
    {



        public static BindingList<Product> Products = new BindingList<Product>();
        // public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts = new BindingList<Part>();
        //public static BindingList<Part> AllParts { get; set; }
        public static int CurrentPartIndex { get; set; }
        public static int CurrentProductIndex { get; set; }
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(int index)
        {
            Products.RemoveAt(index);
            return true;
        }
        public static Product lookupProduct(int product)
        {
            return Inventory.Products[product];
        }
        public static void updateProduct(int id, Product product)
        {

        }
        public static void addPart(Part part)
        {
            AllParts.Insert(Inventory.AllParts.Count, part);
        }
        public static bool deletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }
        public static Part lookupPart(int part)
        {
            return AllParts[part];
        }
        public static void updatePart(int inc, Part part)
        {
            {
                AllParts.Insert(CurrentPartIndex, part);
                AllParts.RemoveAt(CurrentPartIndex + inc);
            }
        }

    }
}
