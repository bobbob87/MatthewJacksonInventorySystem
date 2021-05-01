using System;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    public partial class ModifyPart : Form
    {
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
            bool isInhouse = true;
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Company Name";
            bool isOutsourced = true;
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
    }
}
