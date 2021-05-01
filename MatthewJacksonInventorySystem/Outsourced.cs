namespace MatthewJacksonInventorySystem
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(int id, string name, int price, int instock, int min, int max, string companyname) : base(id, name, price, instock, min, max)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            CompanyName = companyname;
        }
    }
}
