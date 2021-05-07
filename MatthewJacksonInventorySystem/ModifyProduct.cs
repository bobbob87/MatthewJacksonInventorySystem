using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace MatthewJacksonInventorySystem
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> TempPartsList = new BindingList<Part>(Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts);

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
            associatedPartsDatagridView.DataSource = TempPartsList;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //if (TempPartsList.Count > 0)
            //{
            //    TempPartsList.Clear();
            //}
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
            if (Product.currentCandidatePart >= 0)
            {
                //Product.AddAssociatedpart(Inventory.AllParts[Product.currentCandidatePart]);
                TempPartsList.Add(Inventory.AllParts[Product.currentCandidatePart]);
                associatedPartsDatagridView.DataSource = TempPartsList;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts.Count > 0) {
                string message = "Are you sure you wish to remove this part?";
                string caption = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Product.RemoveAssociatedPart(Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts[Product.CurrentAssociatedPart]);
                    Product.RemoveAssociatedPart(TempPartsList[Product.CurrentAssociatedPart]);
                }
            }
            else
            {
                {
                    string box_msg = "Please select a valid Part";

                    string box_title = "Selection Error";

                    MessageBox.Show(box_msg, box_title);
                }
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
                Product p = new Product(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
                //p.AssociatedParts = new BindingList<Part>(TempPartsList);
                foreach (Part part in TempPartsList)
            {
                p.AssociatedParts.Add(part);
            }
                TempPartsList.Clear();
                Inventory.updateProduct(1, p);
                

            this.Hide();
            inventoryForm f = new();
            f.Show();
        }

        private void candidatePartsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.currentCandidatePart = candidatePartsdataGridView.CurrentCell.RowIndex;
            }
        }

        private void associatedPartsDatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.CurrentAssociatedPart = associatedPartsDatagridView.CurrentCell.RowIndex;
            }
        }
    }
}
