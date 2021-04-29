using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewJacksonInventorySystem
{
    class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }   
        public void addAssociatedpart(Part part)
        {
            // TODO: add part code
        }
        public bool removeAssociatedPart(Part part)
        {
            // TODO: remove part code and change return to a variable
        }
        public Part lookupAssociatedPart(Part part)
        {
            // TODO: lookup part code
        }
    }
}
