namespace MatthewJacksonInventorySystem
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse(int id, string name, int price, int instock, int min, int max, int machineid) : base(id, name, price, instock, min, max)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            MachineID = machineid;
        }
    }

}
