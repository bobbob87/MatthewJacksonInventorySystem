﻿using System;
using System.Windows.Forms;
using System.Linq;
namespace MatthewJacksonInventorySystem
{
    public partial class AddPart : Form
    {
        bool isInhouse;

        private bool AllowSave()
        {
            int minVal = 0;
            int maxVal = 0;
            int invVal = 0;
            bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);
            bool invRes = Int32.TryParse(InventoryTextBox.Text, out invVal);
            int number;

            return (!string.IsNullOrWhiteSpace(nameTextBox.Text)) && (!(string.IsNullOrWhiteSpace(priceTextBox.Text) || (!Int32.TryParse(priceTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(InventoryTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(minTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out number))))
               && (!(string.IsNullOrWhiteSpace(mOrCompanyTexBox.Text) || (isInhouse && !Int32.TryParse(mOrCompanyTexBox.Text, out number)))
               && (!(invVal < minVal))
               && (!(invVal > maxVal))
               && (!(minVal > maxVal))
               && (!(maxVal < minVal)));
 ;
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
            bool invRes = Int32.TryParse(InventoryTextBox.Text, out invVal);
            if (string.IsNullOrWhiteSpace(InventoryTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out _)) || (invVal < minVal || invVal > maxVal))
            {
                InventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                InventoryTextBox.BackColor = System.Drawing.Color.White;
            }
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
        public AddPart()
        {
            InitializeComponent();
            int id = 1;

            idTextBox.Text = (id + Inventory.AllParts.Last().PartID).ToString();
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
                Inventory.AllParts.Add(p);
            }
            else
            {
                Part p = new Outsourced(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(InventoryTextBox.Text), Convert.ToInt32(minTextBox.Text), Convert.ToInt32(maxTextBox.Text), mOrCompanyTexBox.Text);
                Inventory.AllParts.Add(p);
            }

            this.Hide();
            inventoryForm f = new();
            f.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            inventoryForm inventoryForm = new();
            inventoryForm.Show();
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

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxMinInvValCheck();
            //int minVal = 0;
            //int maxVal = 0;
            //int invVal = 0;
            //bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            //bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);
            //bool invRes = Int32.TryParse(InventoryTextBox.Text, out invVal);
            //if (string.IsNullOrWhiteSpace(InventoryTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out _)) || (maxRes == false || minRes == false || invRes == false || (invVal < minVal || invVal > maxVal)))
            //{
            //    InventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            //}
            //else
            //{
            //    InventoryTextBox.BackColor = System.Drawing.Color.White;
            //}
            //if ((string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out _))) || (minRes == false || maxRes == false || maxVal <= minVal))
            //{
            //    maxTextBox.BackColor = System.Drawing.Color.Salmon;
            //}
            //else
            //{
            //    maxTextBox.BackColor = System.Drawing.Color.White;
            //}
            //if (string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out _)) || (minRes == false || maxRes == false || minVal >= maxVal))
            //{
            //    minTextBox.BackColor = System.Drawing.Color.Salmon;
            //}
            //else
            //{
            //    minTextBox.BackColor = System.Drawing.Color.White;
            //}
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
            //int minVal = 0;
            //int maxVal = 0;
            //bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            //bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);

            //if ((string.IsNullOrWhiteSpace(maxTextBox.Text) || (!Int32.TryParse(maxTextBox.Text, out _))) || (minRes == false || maxRes == false || maxVal <= minVal)) 
            //{
            //    maxTextBox.BackColor = System.Drawing.Color.Salmon;
            //}
            //else
            //{
            //    maxTextBox.BackColor = System.Drawing.Color.White;
            //}
            saveButton.Enabled = AllowSave();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxMinInvValCheck();
            //int minVal = 0;
            //int maxVal = 0;
            //bool minRes = Int32.TryParse(minTextBox.Text, out minVal);
            //bool maxRes = Int32.TryParse(maxTextBox.Text, out maxVal);

            //if (string.IsNullOrWhiteSpace(minTextBox.Text) || (!Int32.TryParse(InventoryTextBox.Text, out _)) || (minRes == false || maxRes == false || minVal >= maxVal))
            //{
            //    minTextBox.BackColor = System.Drawing.Color.Salmon;
            //}
            //else
            //{
            //    minTextBox.BackColor = System.Drawing.Color.White;
            //}
            saveButton.Enabled = AllowSave();
        }

        private void mOrCompanyTexBox_TextChanged(object sender, EventArgs e)
        {
            RadioButtonUpdate();
        }
    }
}
