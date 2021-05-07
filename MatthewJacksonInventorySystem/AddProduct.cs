using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace MatthewJacksonInventorySystem
{
    public partial class AddProduct : Form
    {


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
        public AddProduct()
        {
            InitializeComponent();
            Product p = new(Inventory.Products.Count, "Default", 3, 2, 1, 3);
            Inventory.Products.Add(p);
            Inventory.CurrentProductIndex = Inventory.Products.Count -1;
            MaxMinInvValCheck();
            idTextBox.Text = (Inventory.Products.Last().ProductID).ToString();
            candidatePartsdataGridView.DataSource = Inventory.AllParts;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Inventory.Products.RemoveAt(Inventory.CurrentProductIndex);
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
            if (associatedPartsDatagridView.RowCount >= 0)
            {
                Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts.Add(Inventory.AllParts[Product.currentCandidatePart]);
                associatedPartsDatagridView.DataSource = Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts.Count > 0)
            {
                string message = "Are you sure you wish to remove this part?";
                string caption = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Product.RemoveAssociatedPart(Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts[Product.CurrentAssociatedPart]);
                    saveButton.Enabled = AllowSave();
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

            Product p = new Product(nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(inventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text));
            p.AssociatedParts = Inventory.Products[Inventory.CurrentProductIndex].AssociatedParts;
            Inventory.Products.RemoveAt(Inventory.CurrentProductIndex);
            Inventory.Products.Add(p);

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
            saveButton.Enabled = AllowSave();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxMinInvValCheck();
            saveButton.Enabled = AllowSave();
        }

        private void associatedPartsDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.CurrentAssociatedPart = associatedPartsDatagridView.CurrentCell.RowIndex;
            }
        }

        private void associatedPartsDatagridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            saveButton.Enabled = AllowSave();
        }
    }
}
