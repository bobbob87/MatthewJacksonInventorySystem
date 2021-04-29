
namespace MatthewJacksonInventorySystem
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPartLabel = new System.Windows.Forms.Label();
            this.radioFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.inOrOutLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.radioFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPartLabel.Location = new System.Drawing.Point(6, 15);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(92, 25);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // radioFlowLayoutPanel
            // 
            this.radioFlowLayoutPanel.Controls.Add(this.inHouseRadioButton);
            this.radioFlowLayoutPanel.Controls.Add(this.outsourcedRadioButton);
            this.radioFlowLayoutPanel.Location = new System.Drawing.Point(241, 15);
            this.radioFlowLayoutPanel.Name = "radioFlowLayoutPanel";
            this.radioFlowLayoutPanel.Size = new System.Drawing.Size(177, 30);
            this.radioFlowLayoutPanel.TabIndex = 1;
            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Checked = true;
            this.inHouseRadioButton.Location = new System.Drawing.Point(3, 3);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(74, 19);
            this.inHouseRadioButton.TabIndex = 1;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.inHouseRadioButton_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(83, 3);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(87, 19);
            this.outsourcedRadioButton.TabIndex = 2;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.outsourcedRadioButton_CheckedChanged);
            // 
            // inOrOutLabel
            // 
            this.inOrOutLabel.AutoSize = true;
            this.inOrOutLabel.Location = new System.Drawing.Point(168, 344);
            this.inOrOutLabel.Name = "inOrOutLabel";
            this.inOrOutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inOrOutLabel.Size = new System.Drawing.Size(67, 15);
            this.inOrOutLabel.TabIndex = 2;
            this.inOrOutLabel.Text = "Machine ID";
            this.inOrOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inOrOutLabel.Click += new System.EventHandler(this.inOrOutLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(196, 137);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(217, 85);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(178, 189);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(57, 15);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(167, 241);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 15);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price / Cost";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(205, 293);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 15);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "Max";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(263, 290);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 23);
            this.maxTextBox.TabIndex = 9;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(384, 293);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 15);
            this.minLabel.TabIndex = 10;
            this.minLabel.Text = "Min";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 11;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(263, 241);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(155, 23);
            this.priceTextBox.TabIndex = 12;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(263, 189);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(155, 23);
            this.InventoryTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(263, 137);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 23);
            this.nameTextBox.TabIndex = 14;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(263, 85);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(155, 23);
            this.idTextBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(579, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(687, 398);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inOrOutLabel);
            this.Controls.Add(this.addPartLabel);
            this.Controls.Add(this.radioFlowLayoutPanel);
            this.Name = "AddPart";
            this.Text = "Part";
            this.radioFlowLayoutPanel.ResumeLayout(false);
            this.radioFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.FlowLayoutPanel radioFlowLayoutPanel;
        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label inOrOutLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}