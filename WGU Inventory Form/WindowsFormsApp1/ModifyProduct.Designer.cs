﻿namespace WindowsFormsApp1
{
    partial class ModifyProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.associatedPartsTable = new System.Windows.Forms.DataGridView();
            this.allPartsGroupBox = new System.Windows.Forms.GroupBox();
            this.allPartsTable = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ProductPriceText = new System.Windows.Forms.RichTextBox();
            this.ProductMaxText = new System.Windows.Forms.RichTextBox();
            this.ProductInvText = new System.Windows.Forms.RichTextBox();
            this.ProductMinText = new System.Windows.Forms.RichTextBox();
            this.ProductNameText = new System.Windows.Forms.RichTextBox();
            this.ProductIDText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).BeginInit();
            this.allPartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.associatedPartsTable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(505, 528);
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
            this.saveBtn.Location = new System.Drawing.Point(62, 286);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 35);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(293, 286);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // associatedPartsTable
            // 
            this.associatedPartsTable.AllowUserToAddRows = false;
            this.associatedPartsTable.AllowUserToDeleteRows = false;
            this.associatedPartsTable.AllowUserToResizeColumns = false;
            this.associatedPartsTable.AllowUserToResizeRows = false;
            this.associatedPartsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsTable.Location = new System.Drawing.Point(9, 29);
            this.associatedPartsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.associatedPartsTable.Name = "associatedPartsTable";
            this.associatedPartsTable.RowHeadersVisible = false;
            this.associatedPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsTable.Size = new System.Drawing.Size(624, 203);
            this.associatedPartsTable.TabIndex = 0;
            this.associatedPartsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associatedPartsTable_CellContentClick);
            // 
            // allPartsGroupBox
            // 
            this.allPartsGroupBox.Controls.Add(this.allPartsTable);
            this.allPartsGroupBox.Controls.Add(this.searchTextBox);
            this.allPartsGroupBox.Controls.Add(this.searchBtn);
            this.allPartsGroupBox.Controls.Add(this.addBtn);
            this.allPartsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.allPartsGroupBox.Location = new System.Drawing.Point(505, 118);
            this.allPartsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPartsGroupBox.Name = "allPartsGroupBox";
            this.allPartsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPartsGroupBox.Size = new System.Drawing.Size(642, 371);
            this.allPartsGroupBox.TabIndex = 18;
            this.allPartsGroupBox.TabStop = false;
            this.allPartsGroupBox.Text = "All Parts";
            // 
            // allPartsTable
            // 
            this.allPartsTable.AllowUserToAddRows = false;
            this.allPartsTable.AllowUserToDeleteRows = false;
            this.allPartsTable.AllowUserToResizeColumns = false;
            this.allPartsTable.AllowUserToResizeRows = false;
            this.allPartsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsTable.Location = new System.Drawing.Point(9, 69);
            this.allPartsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allPartsTable.MultiSelect = false;
            this.allPartsTable.Name = "allPartsTable";
            this.allPartsTable.ReadOnly = true;
            this.allPartsTable.RowHeadersVisible = false;
            this.allPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsTable.Size = new System.Drawing.Size(624, 240);
            this.allPartsTable.TabIndex = 0;
            this.allPartsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsDataGridView_CellContentClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(423, 29);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(208, 35);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(302, 25);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(112, 39);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 655);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Min Qty";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 581);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Max Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Inv #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 495);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(78, 241);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(103, 25);
            this.ID.TabIndex = 26;
            this.ID.Text = "Product ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ProductPriceText
            // 
            this.ProductPriceText.Location = new System.Drawing.Point(192, 482);
            this.ProductPriceText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductPriceText.Name = "ProductPriceText";
            this.ProductPriceText.Size = new System.Drawing.Size(187, 49);
            this.ProductPriceText.TabIndex = 25;
            this.ProductPriceText.Text = "";
            this.ProductPriceText.TextChanged += new System.EventHandler(this.ProductPriceText_TextChanged);
            // 
            // ProductMaxText
            // 
            this.ProductMaxText.Location = new System.Drawing.Point(192, 567);
            this.ProductMaxText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductMaxText.Name = "ProductMaxText";
            this.ProductMaxText.Size = new System.Drawing.Size(187, 49);
            this.ProductMaxText.TabIndex = 24;
            this.ProductMaxText.Text = "";
            this.ProductMaxText.TextChanged += new System.EventHandler(this.ProductMaxText_TextChanged);
            // 
            // ProductInvText
            // 
            this.ProductInvText.Location = new System.Drawing.Point(192, 402);
            this.ProductInvText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductInvText.Name = "ProductInvText";
            this.ProductInvText.Size = new System.Drawing.Size(187, 49);
            this.ProductInvText.TabIndex = 23;
            this.ProductInvText.Text = "";
            this.ProductInvText.TextChanged += new System.EventHandler(this.ProductInvText_TextChanged);
            // 
            // ProductMinText
            // 
            this.ProductMinText.Location = new System.Drawing.Point(192, 641);
            this.ProductMinText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductMinText.Name = "ProductMinText";
            this.ProductMinText.Size = new System.Drawing.Size(187, 49);
            this.ProductMinText.TabIndex = 22;
            this.ProductMinText.Text = "";
            this.ProductMinText.TextChanged += new System.EventHandler(this.ProductMinText_TextChanged);
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(192, 316);
            this.ProductNameText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(187, 49);
            this.ProductNameText.TabIndex = 21;
            this.ProductNameText.Text = "";
            this.ProductNameText.TextChanged += new System.EventHandler(this.ProductNameText_TextChanged);
            // 
            // ProductIDText
            // 
            this.ProductIDText.Location = new System.Drawing.Point(192, 228);
            this.ProductIDText.Margin = new System.Windows.Forms.Padding(2);
            this.ProductIDText.Name = "ProductIDText";
            this.ProductIDText.Size = new System.Drawing.Size(187, 49);
            this.ProductIDText.TabIndex = 20;
            this.ProductIDText.Text = "";
            this.ProductIDText.TextChanged += new System.EventHandler(this.ProductIDText_TextChanged);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 922);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allPartsGroupBox);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).EndInit();
            this.allPartsGroupBox.ResumeLayout(false);
            this.allPartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView associatedPartsTable;
        private System.Windows.Forms.GroupBox allPartsGroupBox;
        private System.Windows.Forms.DataGridView allPartsTable;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.RichTextBox ProductPriceText;
        private System.Windows.Forms.RichTextBox ProductMaxText;
        private System.Windows.Forms.RichTextBox ProductInvText;
        private System.Windows.Forms.RichTextBox ProductMinText;
        private System.Windows.Forms.RichTextBox ProductNameText;
        private System.Windows.Forms.RichTextBox ProductIDText;
    }
}