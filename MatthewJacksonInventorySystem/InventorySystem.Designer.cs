
namespace MatthewJacksonInventorySystem
{
    partial class inventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryForm));
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.productSearchgroupBox = new System.Windows.Forms.GroupBox();
            this.productsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.partsGroupBox.SuspendLayout();
            this.partSearchGroupBox.SuspendLayout();
            this.productSearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productsGroupBox.Controls.Add(this.productDeleteButton);
            this.productsGroupBox.Controls.Add(this.productsModifyButton);
            this.productsGroupBox.Controls.Add(this.productsAddButton);
            this.productsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsGroupBox.Location = new System.Drawing.Point(1157, 369);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(220, 75);
            this.productsGroupBox.TabIndex = 0;
            this.productsGroupBox.TabStop = false;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(144, 21);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(64, 36);
            this.productDeleteButton.TabIndex = 2;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsModifyButton.Location = new System.Drawing.Point(75, 21);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(64, 36);
            this.productsModifyButton.TabIndex = 1;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsAddButton.Location = new System.Drawing.Point(6, 22);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(64, 36);
            this.productsAddButton.TabIndex = 0;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1302, 507);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 31);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(12, 117);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.partsDataGridView.RowTemplate.Height = 25;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(688, 246);
            this.partsDataGridView.TabIndex = 7;
            this.partsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataGridView_CellClick);
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.partsDeleteButton);
            this.partsGroupBox.Controls.Add(this.partsModifyButton);
            this.partsGroupBox.Controls.Add(this.partsAddButton);
            this.partsGroupBox.Location = new System.Drawing.Point(471, 369);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(229, 75);
            this.partsGroupBox.TabIndex = 8;
            this.partsGroupBox.TabStop = false;
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsDeleteButton.Location = new System.Drawing.Point(149, 22);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(64, 36);
            this.partsDeleteButton.TabIndex = 2;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            this.partsDeleteButton.Click += new System.EventHandler(this.partsDeleteButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsModifyButton.Location = new System.Drawing.Point(78, 22);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(64, 36);
            this.partsModifyButton.TabIndex = 1;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsAddButton
            // 
            this.partsAddButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsAddButton.Location = new System.Drawing.Point(6, 22);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(64, 36);
            this.partsAddButton.TabIndex = 0;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mainScreenLabel.Location = new System.Drawing.Point(-3, -4);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(347, 32);
            this.mainScreenLabel.TabIndex = 9;
            this.mainScreenLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partsLabel.Location = new System.Drawing.Point(12, 86);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(58, 25);
            this.partsLabel.TabIndex = 10;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsLabel.Location = new System.Drawing.Point(733, 86);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(92, 25);
            this.productsLabel.TabIndex = 11;
            this.productsLabel.Text = "Products";
            // 
            // partSearchGroupBox
            // 
            this.partSearchGroupBox.Controls.Add(this.partsSearchTextBox);
            this.partSearchGroupBox.Controls.Add(this.partsSearchButton);
            this.partSearchGroupBox.Location = new System.Drawing.Point(409, 71);
            this.partSearchGroupBox.Name = "partSearchGroupBox";
            this.partSearchGroupBox.Size = new System.Drawing.Size(291, 34);
            this.partSearchGroupBox.TabIndex = 6;
            this.partSearchGroupBox.TabStop = false;
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(88, 11);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(198, 23);
            this.partsSearchTextBox.TabIndex = 4;
            this.partsSearchTextBox.TextChanged += new System.EventHandler(this.partsSearchTextBox_TextChanged);
            this.partsSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.partsSearchTextBox_KeyDown);
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(0, 10);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 3;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // productSearchgroupBox
            // 
            this.productSearchgroupBox.Controls.Add(this.productsSearchTextBox);
            this.productSearchgroupBox.Controls.Add(this.productsSearchButton);
            this.productSearchgroupBox.Location = new System.Drawing.Point(1086, 71);
            this.productSearchgroupBox.Name = "productSearchgroupBox";
            this.productSearchgroupBox.Size = new System.Drawing.Size(291, 34);
            this.productSearchgroupBox.TabIndex = 7;
            this.productSearchgroupBox.TabStop = false;
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Location = new System.Drawing.Point(93, 11);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(198, 23);
            this.productsSearchTextBox.TabIndex = 4;
            this.productsSearchTextBox.TextChanged += new System.EventHandler(this.productsSearchTextBox_TextChanged);
            this.productsSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productsSearchTextBox_KeyDown);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(6, 10);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 3;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(733, 117);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersVisible = false;
            this.ProductsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProductsDataGridView.RowTemplate.Height = 25;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(644, 246);
            this.ProductsDataGridView.TabIndex = 12;
            this.ProductsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellClick);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1423, 550);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.productSearchgroupBox);
            this.Controls.Add(this.partSearchGroupBox);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.mainScreenLabel);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.productsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inventoryForm";
            this.Text = "Main Screen";
            this.productsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.partsGroupBox.ResumeLayout(false);
            this.partSearchGroupBox.ResumeLayout(false);
            this.partSearchGroupBox.PerformLayout();
            this.productSearchgroupBox.ResumeLayout(false);
            this.productSearchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.GroupBox partSearchGroupBox;
        private System.Windows.Forms.TextBox partsSearchTextBox;
        private System.Windows.Forms.Button parts;
        private System.Windows.Forms.GroupBox productSearchgroupBox;
        private System.Windows.Forms.TextBox productsSearchTextBox;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Button partsSea;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button productDel;
        private System.Windows.Forms.Button productDeleteButton;
    }
}

