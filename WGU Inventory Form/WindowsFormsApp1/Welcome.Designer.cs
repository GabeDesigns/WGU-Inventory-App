namespace WindowsFormsApp1
{
    partial class Welcome
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
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.searchProduct = new System.Windows.Forms.Button();
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.modifyPart = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.searchPart = new System.Windows.Forms.Button();
            this.searchPartTextBox = new System.Windows.Forms.TextBox();
            this.partGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            this.partGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.AddProduct);
            this.productGroupBox.Controls.Add(this.modifyProduct);
            this.productGroupBox.Controls.Add(this.deleteProduct);
            this.productGroupBox.Controls.Add(this.searchProduct);
            this.productGroupBox.Controls.Add(this.searchProductTextBox);
            this.productGroupBox.Controls.Add(this.productsTable);
            this.productGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.productGroupBox.Location = new System.Drawing.Point(798, 144);
            this.productGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productGroupBox.Size = new System.Drawing.Size(755, 629);
            this.productGroupBox.TabIndex = 8;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            this.productGroupBox.Enter += new System.EventHandler(this.productGroupBox_Enter);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(9, 502);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(135, 45);
            this.AddProduct.TabIndex = 5;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(264, 502);
            this.modifyProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(149, 45);
            this.modifyProduct.TabIndex = 4;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(522, 502);
            this.deleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(166, 45);
            this.deleteProduct.TabIndex = 3;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(336, 23);
            this.searchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(134, 45);
            this.searchProduct.TabIndex = 2;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Location = new System.Drawing.Point(480, 26);
            this.searchProductTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(208, 39);
            this.searchProductTextBox.TabIndex = 1;
            this.searchProductTextBox.TextChanged += new System.EventHandler(this.searchProductTextBox_TextChanged);
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.AllowUserToDeleteRows = false;
            this.productsTable.AllowUserToResizeColumns = false;
            this.productsTable.AllowUserToResizeRows = false;
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Location = new System.Drawing.Point(27, 78);
            this.productsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(681, 385);
            this.productsTable.TabIndex = 0;
            this.productsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellContentClick);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(296, 502);
            this.modifyPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(152, 45);
            this.modifyPart.TabIndex = 2;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(38, 502);
            this.addPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(130, 45);
            this.addPart.TabIndex = 1;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(570, 502);
            this.deletePart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(149, 45);
            this.deletePart.TabIndex = 3;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // partsTable
            // 
            this.partsTable.AllowUserToAddRows = false;
            this.partsTable.AllowUserToDeleteRows = false;
            this.partsTable.AllowUserToResizeColumns = false;
            this.partsTable.AllowUserToResizeRows = false;
            this.partsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Location = new System.Drawing.Point(38, 75);
            this.partsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partsTable.MultiSelect = false;
            this.partsTable.Name = "partsTable";
            this.partsTable.ReadOnly = true;
            this.partsTable.RowHeadersVisible = false;
            this.partsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsTable.Size = new System.Drawing.Size(681, 385);
            this.partsTable.TabIndex = 0;
            this.partsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsTable_CellContentClick);
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(350, 26);
            this.searchPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(136, 42);
            this.searchPart.TabIndex = 4;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // searchPartTextBox
            // 
            this.searchPartTextBox.Location = new System.Drawing.Point(511, 26);
            this.searchPartTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPartTextBox.Name = "searchPartTextBox";
            this.searchPartTextBox.Size = new System.Drawing.Size(208, 39);
            this.searchPartTextBox.TabIndex = 5;
            this.searchPartTextBox.TextChanged += new System.EventHandler(this.searchPartTextBox_TextChanged);
            // 
            // partGroupBox
            // 
            this.partGroupBox.Controls.Add(this.searchPartTextBox);
            this.partGroupBox.Controls.Add(this.searchPart);
            this.partGroupBox.Controls.Add(this.partsTable);
            this.partGroupBox.Controls.Add(this.deletePart);
            this.partGroupBox.Controls.Add(this.addPart);
            this.partGroupBox.Controls.Add(this.modifyPart);
            this.partGroupBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partGroupBox.Location = new System.Drawing.Point(16, 144);
            this.partGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partGroupBox.Name = "partGroupBox";
            this.partGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partGroupBox.Size = new System.Drawing.Size(755, 629);
            this.partGroupBox.TabIndex = 7;
            this.partGroupBox.TabStop = false;
            this.partGroupBox.Text = "Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventory";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 930);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.partGroupBox);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            this.partGroupBox.ResumeLayout(false);
            this.partGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.TextBox searchProductTextBox;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.DataGridView partsTable;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.TextBox searchPartTextBox;
        private System.Windows.Forms.GroupBox partGroupBox;
        private System.Windows.Forms.Label label1;
    }
}