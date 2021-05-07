using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace MatthewJacksonInventorySystem
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> TempPartsList = new BindingList<Part>();
        private bool AllowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(nameTextBox.Text)) && (!(string.IsNullOrWhiteSpace(priceTextBox.Text) || (!Int32.TryParse(priceTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(inventoryTextBox.Text) || (!Int32.TryParse(inventoryTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(minTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out number))))
               && !(associatedPartsDatagridView.RowCount == 0);
        }
        private void MaxMinInvValCheck()
        {
            MinValCheck();
            MaxValCheck();
            InvValCheck();
        }
        private void MinValCheck()
        {
            int minVal = 0;
            int maxVal = 0;
            bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);
            if (string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(minTextBox.Text, out _)) || (minVal >= maxVal))
            {
                minTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                minTextBox.BackColor = System.Drawing.Color.White;
            }
        }
        private void MaxValCheck()
        {
            MinValCheck();
            InvValCheck();
            int minVal = 0;
            int maxVal = 0;
            bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);
            if (string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out _)) || (maxVal <= minVal))
            {
                maxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                maxTextBox.BackColor = System.Drawing.Color.White;
            }
        }
        private void InvValCheck()
        {
            int minVal = 0;
            int maxVal = 0;
            int invVal = 0;
            bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);
            bool invRes = Int32.TryParse(inventoryTextBox.Text, out invVal);
            if (string.IsNullOrWhiteSpace(inventoryTextBox.Text) || (!Int32.TryParse(inventoryTextBox.Text, out _)) || (invVal < minVal || invVal > maxVal))
            {
                inventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                inventoryTextBox.BackColor = System.Drawing.Color.White;
            }
        }
        public ModifyProduct()
        {
            InitializeComponent();
             BindingList<Part> TempPartsList2 = new BindingList<Part>(Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts);
            TempPartsList.Clear();
            TempPartsList = TempPartsList2;
            idTextBox.Text = Inventory.Products[Product.currentProduct].ProductID.ToString();
            nameTextBox.Text = Inventory.Products[Product.currentProduct].Name;
            inventoryTextBox.Text = Inventory.Products[Product.currentProduct].InStock.ToString();
            priceTextBox.Text = Inventory.Products[Product.currentProduct].Price.ToString();
            minTextBox.Text = Inventory.Products[Product.currentProduct].Min.ToString();
            maxTextBox.Text = Inventory.Products[Product.currentProduct].Max.ToString();

            candidatePartsdataGridView.DataSource = Inventory.AllParts;
            associatedPartsDatagridView.DataSource = TempPartsList;
            MaxMinInvValCheck();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProductIndex = 0;
            Product.currentProduct = 0;
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
                TempPartsList.Add(Inventory.AllParts[Product.currentCandidatePart]);
                associatedPartsDatagridView.DataSource = TempPartsList;
            }
            else
            {
                Console.WriteLine("Error");
            }
            saveButton.Enabled = AllowSave();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if ((TempPartsList.Count > 0) && Product.CurrentAssociatedPart >= 0) {
                string message = "Are you sure you wish to remove this part?";
                string caption = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    TempPartsList.RemoveAt(Product.CurrentAssociatedPart);
                    Product.CurrentAssociatedPart = 0;
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
            saveButton.Enabled = AllowSave();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
                Product p = new Product(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                nameTextBox.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = AllowSave();
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxMinInvValCheck();
            saveButton.Enabled = AllowSave();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || (!Int32.TryParse(priceTextBox.Text, out _)))
            {
                priceTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                priceTextBox.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = AllowSave();
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxMinInvValCheck();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxMinInvValCheck();
            saveButton.Enabled = AllowSave();
        }
    }
}
