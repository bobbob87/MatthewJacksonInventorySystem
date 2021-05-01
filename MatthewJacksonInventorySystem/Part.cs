namespace MatthewJacksonInventorySystem
{
    abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        protected Part(int id, string name, decimal price, int instock, int min, int max)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }

    }
}
