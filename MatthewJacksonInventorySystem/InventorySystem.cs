using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MatthewJacksonInventorySystem
{
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();

            ProductsDataGridView.DataSource = Inventory.Products;
            partsDataGridView.DataSource = Inventory.AllParts;

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
            if (Inventory.Products.Count == 0 || Inventory.CurrentProductIndex == ProductsDataGridView.RowCount)
            {
                string box_msg = "Please select a valid Product";

                string box_title = "Selection Error";

                MessageBox.Show(box_msg, box_title);
                return;
            }

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
            BindingList<Part> TempPartList = new BindingList<Part>();
            bool found = false;
            if (partsSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsSearchTextBox.Text.ToUpper()))
                    {
                        TempPartList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    partsDataGridView.DataSource = TempPartList;
            }
            if (!found)
            {
                MessageBox.Show("No Search Results.");
                partsDataGridView.DataSource = Inventory.AllParts;
            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempProductList = new BindingList<Product>();
            bool found = false;
            if (productsSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productsSearchTextBox.Text.ToUpper()))
                    {
                        TempProductList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    ProductsDataGridView.DataSource = TempProductList;
            }
            if (!found)
            {
                MessageBox.Show("No Search Results.");
                ProductsDataGridView.DataSource = Inventory.Products;
            }
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
            if (Inventory.AllParts.Count == 0 || Inventory.CurrentPartIndex == partsDataGridView.RowCount)
            {
                string box_msg = "Please select a valid Part";

                string box_title = "Selection Error";

                MessageBox.Show(box_msg, box_title);
                return;
            }
            this.Hide();
            ModifyPart newMDIChild = new();
            newMDIChild.MdiParent = ParentForm;
            newMDIChild.Show();
            newMDIChild.BringToFront();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Count == 0 || Inventory.CurrentPartIndex == partsDataGridView.RowCount)
            {
                string box_msg = "Please select a valid Part";

                string box_title = "Selection Error";

                MessageBox.Show(box_msg, box_title);
            }
            else
            {
                string message = "Are you sure you wish to delete this part?";
                string caption = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Inventory.deletePart(Inventory.AllParts[Part.currentPart]);
                }
            }
        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            if (Inventory.Products.Count == 0 || Inventory.CurrentProductIndex == ProductsDataGridView.RowCount)
            {
                string box_msg = "Please select a valid Product";

                string box_title = "Selection Error";

                MessageBox.Show(box_msg, box_title);
            }
            else
            {
                string message = "Are you sure you wish to delete this product?";
                string caption = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Inventory.removeProduct(Product.currentProduct);
                }
            }        
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product.currentProduct = ProductsDataGridView.CurrentCell.RowIndex;
                Inventory.CurrentProductIndex = ProductsDataGridView.CurrentCell.RowIndex;
            }
        }

        private void partsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Part.currentPart = partsDataGridView.CurrentCell.RowIndex;
                Inventory.CurrentPartIndex = partsDataGridView.CurrentCell.RowIndex;
            }
        }

        private void partsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productsSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productsSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                productsSearchButton.PerformClick();
            }
        }

        private void partsSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partsSearchButton.PerformClick();
            }
        }
    }
}
