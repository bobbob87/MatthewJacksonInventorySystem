using System;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
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
