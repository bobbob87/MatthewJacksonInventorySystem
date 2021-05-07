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

            if (Inventory.AllParts[Part.currentPart] is Outsourced)
            {
                Outsourced e = (Outsourced)Inventory.lookupPart(Part.currentPart);
                mOrCompanyTexBox.Text = e.CompanyName;
                isInhouse = false;
                outsourcedRadioButton.Checked = true;

            }
            else
            {
                Inhouse e = (Inhouse)Inventory.lookupPart(Part.currentPart);
                mOrCompanyTexBox.Text = e.MachineID.ToString() ;
                inHouseRadioButton.Checked = true;
                isInhouse = true;
            }
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
            if (isInhouse)
            {
                Part p = new Inhouse(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(InventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), Convert.ToInt32(mOrCompanyTexBox.Text));
                Inventory.updatePart(1,p);
            }
            else
            {
                Part p = new Outsourced(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(InventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), mOrCompanyTexBox.Text);
                Inventory.updatePart(1,p);
            }

            this.Hide();
            inventoryForm f = new();
            f.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Inventory.CurrentPartIndex = 0;
            Part.currentPart = 0;
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
