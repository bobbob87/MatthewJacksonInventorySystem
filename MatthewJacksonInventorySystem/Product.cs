using System.ComponentModel;

namespace MatthewJacksonInventorySystem
{
    class Product
    {
        public static int ProductCount = Inventory.Products.Count -1;
        public static int currentProduct { get; set; }
        public static int currentCandidatePart { get; set; }
        public static int CurrentAssociatedPart { get; set; }
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public static void AddAssociatedpart(Part part)
        {
            Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts.Add(part);
        }
        public static bool RemoveAssociatedPart(Part part)
        {
            Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts.Remove(part);
            return true;// TODO: remove part code and change return to a variable
        }
        public static Part lookupAssociatedPart(Part part)
        {
            return Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts[CurrentAssociatedPart];
        }
        public Product(int ID, string name, decimal price, int instock, int min, int max)
        {
            ProductID = ID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }
        public Product(string name, decimal price, int instock, int min, int max)
        {
            ProductID = ProductCount++;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }
    }
}
