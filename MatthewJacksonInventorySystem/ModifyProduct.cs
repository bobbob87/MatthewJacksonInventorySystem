using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace MatthewJacksonInventorySystem
{
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
            idTextBox.Text = Inventory.Products[Product.currentProduct].ProductID.ToString();
            nameTextBox.Text = Inventory.Products[Product.currentProduct].Name;
            inventoryTextBox.Text = Inventory.Products[Product.currentProduct].InStock.ToString();
            priceTextBox.Text = Inventory.Products[Product.currentProduct].Price.ToString();
            minTextBox.Text = Inventory.Products[Product.currentProduct].Min.ToString();
            maxTextBox.Text = Inventory.Products[Product.currentProduct].Max.ToString();
            candidatePartsdataGridView.DataSource = Inventory.AllParts;
            associatedPartsDatagridView.DataSource = Product.AssociatedParts;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
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
            if (Product.currentCandidatePart <= Inventory.AllParts.Count)
            {
                //Product.AssociatedParts.Add(Inventory.AllParts[Product.currentCandidatePart]);
                Product.AddAssociatedpart(Inventory.AllParts[Product.currentCandidatePart]);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {


            string message = "Are you sure you wish to remove this part?";
            string caption = "Please Confirm Deletion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Product.RemoveAssociatedPart(Product.AssociatedParts[Product.CurrentAssociatedPart]);
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void candidatePartsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product.currentCandidatePart = candidatePartsdataGridView.CurrentCell.RowIndex;
        }

        private void associatedPartsDatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product.CurrentAssociatedPart = associatedPartsDatagridView.CurrentCell.RowIndex;
        }
    }
}
