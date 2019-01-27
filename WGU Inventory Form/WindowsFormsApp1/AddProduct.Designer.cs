namespace WindowsFormsApp1
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
            this.ProductIDText = new System.Windows.Forms.RichTextBox();
            this.ProductNameText = new System.Windows.Forms.RichTextBox();
            this.ProductMinText = new System.Windows.Forms.RichTextBox();
            this.ProductInvText = new System.Windows.Forms.RichTextBox();
            this.ProductMaxText = new System.Windows.Forms.RichTextBox();
            this.ProductPriceText = new System.Windows.Forms.RichTextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.associatedPartsTable = new System.Windows.Forms.DataGridView();
            this.allPartsTable = new System.Windows.Forms.GroupBox();
            this.allParts_Table = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).BeginInit();
            this.allPartsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allParts_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductIDText
            // 
            this.ProductIDText.Location = new System.Drawing.Point(209, 109);
            this.ProductIDText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductIDText.Name = "ProductIDText";
            this.ProductIDText.ReadOnly = true;
            this.ProductIDText.Size = new System.Drawing.Size(187, 49);
            this.ProductIDText.TabIndex = 0;
            this.ProductIDText.Text = "Auto Gen.";
            this.ProductIDText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(209, 197);
            this.ProductNameText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(187, 49);
            this.ProductNameText.TabIndex = 1;
            this.ProductNameText.Text = "";
            // 
            // ProductMinText
            // 
            this.ProductMinText.Location = new System.Drawing.Point(209, 522);
            this.ProductMinText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductMinText.Name = "ProductMinText";
            this.ProductMinText.Size = new System.Drawing.Size(187, 49);
            this.ProductMinText.TabIndex = 2;
            this.ProductMinText.Text = "";
            // 
            // ProductInvText
            // 
            this.ProductInvText.Location = new System.Drawing.Point(209, 283);
            this.ProductInvText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductInvText.Name = "ProductInvText";
            this.ProductInvText.Size = new System.Drawing.Size(187, 49);
            this.ProductInvText.TabIndex = 4;
            this.ProductInvText.Text = "";
            // 
            // ProductMaxText
            // 
            this.ProductMaxText.Location = new System.Drawing.Point(209, 448);
            this.ProductMaxText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductMaxText.Name = "ProductMaxText";
            this.ProductMaxText.Size = new System.Drawing.Size(187, 49);
            this.ProductMaxText.TabIndex = 5;
            this.ProductMaxText.Text = "";
            // 
            // ProductPriceText
            // 
            this.ProductPriceText.Location = new System.Drawing.Point(209, 363);
            this.ProductPriceText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPriceText.Name = "ProductPriceText";
            this.ProductPriceText.Size = new System.Drawing.Size(187, 49);
            this.ProductPriceText.TabIndex = 6;
            this.ProductPriceText.Text = "";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(95, 122);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(103, 25);
            this.ID.TabIndex = 7;
            this.ID.Text = "Product ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inv #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 491);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 12;
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 536);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Min Qty";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.associatedPartsTable);
            this.groupBox1.Location = new System.Drawing.Point(515, 420);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(642, 331);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts in Product";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(213, 286);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 35);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(365, 286);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(519, 286);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 35);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // associatedPartsTable
            // 
            this.associatedPartsTable.AllowUserToAddRows = false;
            this.associatedPartsTable.AllowUserToDeleteRows = false;
            this.associatedPartsTable.AllowUserToResizeColumns = false;
            this.associatedPartsTable.AllowUserToResizeRows = false;
            this.associatedPartsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsTable.Location = new System.Drawing.Point(7, 52);
            this.associatedPartsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.associatedPartsTable.Name = "associatedPartsTable";
            this.associatedPartsTable.RowHeadersVisible = false;
            this.associatedPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsTable.Size = new System.Drawing.Size(624, 203);
            this.associatedPartsTable.TabIndex = 0;
            // 
            // allPartsTable
            // 
            this.allPartsTable.Controls.Add(this.allParts_Table);
            this.allPartsTable.Controls.Add(this.searchTextBox);
            this.allPartsTable.Controls.Add(this.searchBtn);
            this.allPartsTable.Controls.Add(this.addBtn);
            this.allPartsTable.Location = new System.Drawing.Point(515, 40);
            this.allPartsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPartsTable.Name = "allPartsTable";
            this.allPartsTable.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPartsTable.Size = new System.Drawing.Size(642, 371);
            this.allPartsTable.TabIndex = 18;
            this.allPartsTable.TabStop = false;
            this.allPartsTable.Text = "All Parts";
            // 
            // allParts_Table
            // 
            this.allParts_Table.AllowUserToAddRows = false;
            this.allParts_Table.AllowUserToDeleteRows = false;
            this.allParts_Table.AllowUserToResizeColumns = false;
            this.allParts_Table.AllowUserToResizeRows = false;
            this.allParts_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allParts_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allParts_Table.Location = new System.Drawing.Point(9, 69);
            this.allParts_Table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allParts_Table.MultiSelect = false;
            this.allParts_Table.Name = "allParts_Table";
            this.allParts_Table.ReadOnly = true;
            this.allParts_Table.RowHeadersVisible = false;
            this.allParts_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allParts_Table.Size = new System.Drawing.Size(624, 240);
            this.allParts_Table.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(423, 29);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(208, 26);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(302, 25);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 35);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(520, 318);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 35);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 793);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allPartsTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ProductPriceText);
            this.Controls.Add(this.ProductMaxText);
            this.Controls.Add(this.ProductInvText);
            this.Controls.Add(this.ProductMinText);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.ProductIDText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1297, 849);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).EndInit();
            this.allPartsTable.ResumeLayout(false);
            this.allPartsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allParts_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProductIDText;
        private System.Windows.Forms.RichTextBox ProductNameText;
        private System.Windows.Forms.RichTextBox ProductMinText;
        private System.Windows.Forms.RichTextBox ProductInvText;
        private System.Windows.Forms.RichTextBox ProductMaxText;
        private System.Windows.Forms.RichTextBox ProductPriceText;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView associatedPartsTable;
        private System.Windows.Forms.GroupBox allPartsTable;
        private System.Windows.Forms.DataGridView allParts_Table;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
    }
}