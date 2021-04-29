
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryForm));
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.productSearchgroupBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.partsGroupBox.SuspendLayout();
            this.partSearchGroupBox.SuspendLayout();
            this.productSearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productsGroupBox.Controls.Add(this.productDeleteButton);
            this.productsGroupBox.Controls.Add(this.productsModifyButton);
            this.productsGroupBox.Controls.Add(this.productsAddButton);
            this.productsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsGroupBox.Location = new System.Drawing.Point(867, 369);
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
            this.exitButton.Location = new System.Drawing.Point(1012, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 31);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.inventoryColumn,
            this.priceColumn});
            this.partsDataGridView.Location = new System.Drawing.Point(51, 114);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowTemplate.Height = 25;
            this.partsDataGridView.Size = new System.Drawing.Size(443, 246);
            this.partsDataGridView.TabIndex = 7;
            this.partsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Part ID";
            this.idColumn.Name = "idColumn";
            // 
            // nameColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameColumn.HeaderText = "Part Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // inventoryColumn
            // 
            this.inventoryColumn.HeaderText = "Inventory";
            this.inventoryColumn.Name = "inventoryColumn";
            // 
            // priceColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.partsDeleteButton);
            this.partsGroupBox.Controls.Add(this.partsModifyButton);
            this.partsGroupBox.Controls.Add(this.partsAddButton);
            this.partsGroupBox.Location = new System.Drawing.Point(265, 369);
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
            this.partsLabel.Location = new System.Drawing.Point(46, 86);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(58, 25);
            this.partsLabel.TabIndex = 10;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsLabel.Location = new System.Drawing.Point(639, 86);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(92, 25);
            this.productsLabel.TabIndex = 11;
            this.productsLabel.Text = "Products";
            // 
            // partSearchGroupBox
            // 
            this.partSearchGroupBox.Controls.Add(this.textBox1);
            this.partSearchGroupBox.Controls.Add(this.partsSearchButton);
            this.partSearchGroupBox.Location = new System.Drawing.Point(208, 61);
            this.partSearchGroupBox.Name = "partSearchGroupBox";
            this.partSearchGroupBox.Size = new System.Drawing.Size(291, 34);
            this.partSearchGroupBox.TabIndex = 6;
            this.partSearchGroupBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 4;
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
            this.productSearchgroupBox.Controls.Add(this.textBox2);
            this.productSearchgroupBox.Controls.Add(this.productsSearchButton);
            this.productSearchgroupBox.Location = new System.Drawing.Point(796, 61);
            this.productSearchgroupBox.Name = "productSearchgroupBox";
            this.productSearchgroupBox.Size = new System.Drawing.Size(291, 34);
            this.productSearchgroupBox.TabIndex = 7;
            this.productSearchgroupBox.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 23);
            this.textBox2.TabIndex = 4;
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
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productsDataGridView.Location = new System.Drawing.Point(644, 117);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.Size = new System.Drawing.Size(443, 246);
            this.productsDataGridView.TabIndex = 12;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 509);
            this.Controls.Add(this.productsDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.GroupBox partSearchGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button parts;
        private System.Windows.Forms.GroupBox productSearchgroupBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Button partsSea;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button productDel;
        private System.Windows.Forms.Button productDeleteButton;
    }
}

