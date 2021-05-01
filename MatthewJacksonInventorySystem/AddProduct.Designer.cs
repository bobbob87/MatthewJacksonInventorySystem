
namespace MatthewJacksonInventorySystem
{
    partial class AddProduct
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.candidatePartsdataGridView = new System.Windows.Forms.DataGridView();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.associatedPartsDatagridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductLabel.Location = new System.Drawing.Point(13, 24);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(126, 25);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(84, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Enter search text here...";
            this.searchTextBox.Size = new System.Drawing.Size(237, 23);
            this.searchTextBox.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Controls.Add(this.searchTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(814, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 57);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // candidatePartsdataGridView
            // 
            this.candidatePartsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsdataGridView.Location = new System.Drawing.Point(592, 87);
            this.candidatePartsdataGridView.Name = "candidatePartsdataGridView";
            this.candidatePartsdataGridView.RowTemplate.Height = 25;
            this.candidatePartsdataGridView.Size = new System.Drawing.Size(543, 201);
            this.candidatePartsdataGridView.TabIndex = 4;
            this.candidatePartsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidatePartsdataGridView_CellClick);
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Location = new System.Drawing.Point(615, 65);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(107, 15);
            this.candidatePartsLabel.TabIndex = 5;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1056, 629);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(953, 629);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1056, 571);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1056, 307);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // associatedPartsDatagridView
            // 
            this.associatedPartsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDatagridView.Location = new System.Drawing.Point(588, 353);
            this.associatedPartsDatagridView.Name = "associatedPartsDatagridView";
            this.associatedPartsDatagridView.RowTemplate.Height = 25;
            this.associatedPartsDatagridView.Size = new System.Drawing.Size(543, 201);
            this.associatedPartsDatagridView.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(163, 201);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(142, 255);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(124, 309);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(57, 15);
            this.inventoryLabel.TabIndex = 13;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(148, 363);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(151, 412);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 15);
            this.maxLabel.TabIndex = 15;
            this.maxLabel.Text = "Max";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(208, 409);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(78, 23);
            this.maxTextBox.TabIndex = 16;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(307, 412);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 15);
            this.minLabel.TabIndex = 17;
            this.minLabel.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(357, 409);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(78, 23);
            this.minTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(208, 360);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(227, 23);
            this.priceTextBox.TabIndex = 18;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(208, 306);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(227, 23);
            this.inventoryTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(208, 252);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 23);
            this.nameTextBox.TabIndex = 20;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(208, 198);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(227, 23);
            this.idTextBox.TabIndex = 21;
            // 
            // AddProduct
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1161, 674);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.associatedPartsDatagridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.candidatePartsdataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDatagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView candidatePartsdataGridView;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView associatedPartsDatagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}