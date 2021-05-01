using System.ComponentModel;

namespace MatthewJacksonInventorySystem
{
    class Product
    {
        public static int currentProduct { get; set; }
        public static int currentCandidatePart { get; set; }
        public static int CurrentAssociatedPart { get; set; }
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();
        //public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public static void AddAssociatedpart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public static bool RemoveAssociatedPart(Part part)
        {
            AssociatedParts.Remove(part);
            return true;// TODO: remove part code and change return to a variable
        }
        public static Part lookupAssociatedPart(Part part)
        {
            return AssociatedParts[CurrentAssociatedPart];
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
    }
}
