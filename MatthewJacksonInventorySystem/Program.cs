using System;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    static class Program
    {
        /// Matthew Jackson's C968 Software 1 - C# Performance Assessment
        /// 
        /// 
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Product p = new Product(1, "Gear", 3, 19, 4, 150);
            Inventory.Products.Add(p);
            Inventory.Products.Add(new Product(2, "Lever", 1, 43, 2, 400));  // constructor is an argument for "add", saves lines of code and no "p" variable is needed
            Product q = new Product(3, "Shank", 4, 15, 9, 46);
            Inventory.addProduct(q); // instantiates the object, then adds it using the addProduct method in Inventory
            Inventory.addProduct(new Product(4, "Piston", 2, 220, 37, 999)); // same as above but with constructor as an argument to addProduct
            Inventory.addPart(new Inhouse(1, "Spigot", 5, 22, 2, 49, 4));
            Inventory.addPart(new Inhouse(2, "Spaghetti", 3, 4, 2, 333, 12));
            Inventory.addPart(new Outsourced(3, "Spigotaa", 6, 22, 2, 49, "The Dot"));
            Inventory.addPart(new Outsourced(4, "Spaghettirra", 7, 4, 2, 333, "Blue Echo"));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new inventoryForm());
        }
    }
}
