using System;
using System.Windows.Forms;

namespace MatthewJacksonInventorySystem
{
    public partial class parentForm : Form
    {
        public parentForm()
        {
            InitializeComponent();
        }

        private void parentForm_Load(object sender, EventArgs e)
        {
            inventoryForm newMDIChild = new();
            newMDIChild.MdiParent = ParentForm;
            newMDIChild.Show();
            newMDIChild.BringToFront();
        }
    }
}
