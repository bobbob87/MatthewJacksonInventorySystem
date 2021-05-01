using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            candidatePartsdataGridView.DataSource = Inventory.AllParts;
            associatedPartsDatagridView.DataSource = Product.AssociatedParts;
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
            BindingList<Part> TempPartList = new BindingList<Part>();
            bool found = false;
            if (searchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchTextBox.Text.ToUpper()))
                    {
                        TempPartList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    candidatePartsdataGridView.DataSource = TempPartList;
            }
            if (!found)
            {
                MessageBox.Show("No Search Results.");
                candidatePartsdataGridView.DataSource = Inventory.AllParts;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            candidatePartsdataGridView.Rows.RemoveAt(Product.currentCandidatePart);
            if (Product.currentCandidatePart <= Inventory.AllParts.Count)
            {
                Product.AssociatedParts.Add(Inventory.AllParts[Product.currentCandidatePart]);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void candidatePartsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
