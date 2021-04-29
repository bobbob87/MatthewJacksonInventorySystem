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
