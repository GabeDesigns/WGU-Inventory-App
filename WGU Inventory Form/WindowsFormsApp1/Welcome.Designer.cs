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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PartsAdd = new System.Windows.Forms.Button();
            this.PartsMend = new System.Windows.Forms.Button();
            this.PartsDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PartsSearchBox = new System.Windows.Forms.RichTextBox();
            this.PartsSearchBtn = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.ProductMend = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(16, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 31);
            label2.TabIndex = 0;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(30, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(122, 31);
            label3.TabIndex = 1;
            label3.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 20.1F);
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(93, 133);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PartsAdd);
            this.splitContainer1.Panel1.Controls.Add(this.PartsMend);
            this.splitContainer1.Panel1.Controls.Add(this.PartsDelete);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.PartsSearchBox);
            this.splitContainer1.Panel1.Controls.Add(this.PartsSearchBtn);
            this.splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductDelete);
            this.splitContainer1.Panel2.Controls.Add(this.ProductMend);
            this.splitContainer1.Panel2.Controls.Add(this.ProductAdd);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(label3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1312, 794);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.TabIndex = 1;
            // 
            // PartsAdd
            // 
            this.PartsAdd.Location = new System.Drawing.Point(59, 665);
            this.PartsAdd.Name = "PartsAdd";
            this.PartsAdd.Size = new System.Drawing.Size(113, 37);
            this.PartsAdd.TabIndex = 10;
            this.PartsAdd.Text = "Add";
            this.PartsAdd.UseVisualStyleBackColor = true;
            this.PartsAdd.Click += new System.EventHandler(this.PartsAdd_Click);
            // 
            // PartsMend
            // 
            this.PartsMend.Location = new System.Drawing.Point(258, 665);
            this.PartsMend.Name = "PartsMend";
            this.PartsMend.Size = new System.Drawing.Size(113, 37);
            this.PartsMend.TabIndex = 9;
            this.PartsMend.Text = "Mend";
            this.PartsMend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PartsMend.UseVisualStyleBackColor = true;
            this.PartsMend.Click += new System.EventHandler(this.PartsMend_Click);
            // 
            // PartsDelete
            // 
            this.PartsDelete.Location = new System.Drawing.Point(451, 665);
            this.PartsDelete.Name = "PartsDelete";
            this.PartsDelete.Size = new System.Drawing.Size(113, 37);
            this.PartsDelete.TabIndex = 8;
            this.PartsDelete.Text = "Delete";
            this.PartsDelete.UseVisualStyleBackColor = true;
            this.PartsDelete.Click += new System.EventHandler(this.PartsDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 414);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsSearchBox.Location = new System.Drawing.Point(377, 24);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PartsSearchBox.Size = new System.Drawing.Size(250, 43);
            this.PartsSearchBox.TabIndex = 2;
            this.PartsSearchBox.Text = "Search..";
            this.PartsSearchBox.TextChanged += new System.EventHandler(this.PartsSearchBox_TextChanged);
            // 
            // PartsSearchBtn
            // 
            this.PartsSearchBtn.Location = new System.Drawing.Point(275, 24);
            this.PartsSearchBtn.Name = "PartsSearchBtn";
            this.PartsSearchBtn.Size = new System.Drawing.Size(96, 43);
            this.PartsSearchBtn.TabIndex = 3;
            this.PartsSearchBtn.Text = "Search";
            this.PartsSearchBtn.UseVisualStyleBackColor = true;
            this.PartsSearchBtn.Click += new System.EventHandler(this.PartsSearchBtn_Click);
            // 
            // ProductDelete
            // 
            this.ProductDelete.Location = new System.Drawing.Point(458, 665);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(113, 37);
            this.ProductDelete.TabIndex = 9;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // ProductMend
            // 
            this.ProductMend.Location = new System.Drawing.Point(274, 665);
            this.ProductMend.Name = "ProductMend";
            this.ProductMend.Size = new System.Drawing.Size(113, 37);
            this.ProductMend.TabIndex = 8;
            this.ProductMend.Text = "Mend";
            this.ProductMend.UseVisualStyleBackColor = true;
            this.ProductMend.Click += new System.EventHandler(this.ProductMend_Click);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Location = new System.Drawing.Point(101, 665);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(113, 37);
            this.ProductAdd.TabIndex = 7;
            this.ProductAdd.Text = "Add";
            this.ProductAdd.UseVisualStyleBackColor = true;
            this.ProductAdd.Click += new System.EventHandler(this.ProductAdd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(36, 189);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(590, 414);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(376, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(250, 43);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Search..";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1506, 990);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1530, 1054);
            this.Name = "Welcome";
            this.Text = "WGU Inventory";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox PartsSearchBox;
        private System.Windows.Forms.Button PartsSearchBtn;
        private System.Windows.Forms.Button PartsAdd;
        private System.Windows.Forms.Button PartsMend;
        private System.Windows.Forms.Button PartsDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button ProductMend;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

