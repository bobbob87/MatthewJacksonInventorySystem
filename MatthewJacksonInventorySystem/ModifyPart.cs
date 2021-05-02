using System;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    public partial class ModifyPart : Form
    {
        bool isInhouse;

        private bool AllowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(nameTextBox.Text)) && (!(string.IsNullOrWhiteSpace(priceTextBox.Text) || (!Int32.TryParse(priceTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(InventoryTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(minTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(mOrCompanyTexBox.Text) || (isInhouse && !Int32.TryParse(mOrCompanyTexBox.Text, out number))));
        }

        private void RadioButtonUpdate()
        {
            int number;
            if (string.IsNullOrWhiteSpace(mOrCompanyTexBox.Text) || (isInhouse && !Int32.TryParse(mOrCompanyTexBox.Text, out number)))
            {
                mOrCompanyTexBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                mOrCompanyTexBox.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = AllowSave();
        }
        public ModifyPart()
        {
            InitializeComponent();
            idTextBox.Text = Inventory.AllParts[Part.currentPart].PartID.ToString();
            nameTextBox.Text = Inventory.AllParts[Part.currentPart].Name;
            InventoryTextBox.Text = Inventory.AllParts[Part.currentPart].InStock.ToString();
            priceTextBox.Text = Inventory.AllParts[Part.currentPart].Price.ToString();
            minTextBox.Text = Inventory.AllParts[Part.currentPart].Min.ToString();
            maxTextBox.Text = Inventory.AllParts[Part.currentPart].Max.ToString();

            // ****NEED TO GET THIS WORKING!****
            //if (Inventory.AllParts[Part.currentPart] is Outsourced)
            //{
            //    outsourcedRadioButton.Checked = true;
            //    mOrCompanyTexBox.Text = Inventory.AllParts[Part.currentPart].
            //}
            //else
            //{
            //    inHouseRadioButton.Checked = true;
            //}
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Machine ID";
            isInhouse = true;
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Company Name";
            isInhouse = false;
        }

        private void inOrOutLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            inventoryForm inventoryForm = new();
            inventoryForm.Show();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            // if txtName has no text, flag an error
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

        private void mOrCompanyTexBox_TextChanged(object sender, EventArgs e)
        {
            RadioButtonUpdate();
        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InventoryTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out _)))
            {
                InventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                InventoryTextBox.BackColor = System.Drawing.Color.White;
            }
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
            if (string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out _)))
            {
                maxTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                maxTextBox.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = AllowSave();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(minTextBox.Text, out _)))
            {
                minTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                minTextBox.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = AllowSave();
        }
    }
}
