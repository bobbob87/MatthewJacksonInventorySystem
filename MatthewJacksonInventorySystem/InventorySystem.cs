using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MatthewJacksonInventorySystem
{
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct newMDIChild = new();
            newMDIChild.MdiParent = ParentForm;
            newMDIChild.Show();
            newMDIChild.BringToFront();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyProduct newMDIChild = new();
            newMDIChild.MdiParent = ParentForm;
            newMDIChild.Show();
            newMDIChild.BringToFront();
        
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart newMDIChild = new();
            newMDIChild.MdiParent = ParentForm;
            newMDIChild.Show();
            newMDIChild.BringToFront();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPart newMDIChild = new();
            newMDIChild.MdiParent = ParentForm;
            newMDIChild.Show();
            newMDIChild.BringToFront();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
