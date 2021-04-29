using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryForm inventoryForm = new();
            inventoryForm.Show();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
