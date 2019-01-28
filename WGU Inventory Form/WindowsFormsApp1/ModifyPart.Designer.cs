namespace WindowsFormsApp1
{
    partial class ModifyPart
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
            this.OutSourceRadio = new System.Windows.Forms.RadioButton();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PartMinText = new System.Windows.Forms.RichTextBox();
            this.MachineIDText = new System.Windows.Forms.RichTextBox();
            this.PartMaxText = new System.Windows.Forms.RichTextBox();
            this.PartPriceText = new System.Windows.Forms.RichTextBox();
            this.PartNameText = new System.Windows.Forms.RichTextBox();
            this.PartInvText = new System.Windows.Forms.RichTextBox();
            this.PartIDText = new System.Windows.Forms.RichTextBox();
            this.outsource = new System.Windows.Forms.RadioButton();
            this.inHouse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OutSourceRadio
            // 
            this.OutSourceRadio.AutoSize = true;
            this.OutSourceRadio.Location = new System.Drawing.Point(392, -70);
            this.OutSourceRadio.Margin = new System.Windows.Forms.Padding(2);
            this.OutSourceRadio.Name = "OutSourceRadio";
            this.OutSourceRadio.Size = new System.Drawing.Size(97, 24);
            this.OutSourceRadio.TabIndex = 35;
            this.OutSourceRadio.TabStop = true;
            this.OutSourceRadio.Text = "3rd Party";
            this.OutSourceRadio.UseVisualStyleBackColor = true;
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(204, -70);
            this.InHouseRadio.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(99, 24);
            this.InHouseRadio.TabIndex = 34;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(494, 621);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 37);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(157, 621);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 37);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Submit";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 427);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 34);
            this.label7.TabIndex = 31;
            this.label7.Text = "Part Min Qty";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 34);
            this.label6.TabIndex = 30;
            this.label6.Text = "Machine ID";
            this.label6.UseCompatibleTextRendering = true;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 34);
            this.label5.TabIndex = 29;
            this.label5.Text = "Part Max Qty";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Part Price";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Part Inv #";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Part Name";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Part ID";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // PartMinText
            // 
            this.PartMinText.Location = new System.Drawing.Point(621, 418);
            this.PartMinText.Margin = new System.Windows.Forms.Padding(2);
            this.PartMinText.Name = "PartMinText";
            this.PartMinText.Size = new System.Drawing.Size(195, 42);
            this.PartMinText.TabIndex = 24;
            this.PartMinText.Text = "";
            this.PartMinText.TextChanged += new System.EventHandler(this.PartMinText_TextChanged);
            // 
            // MachineIDText
            // 
            this.MachineIDText.Location = new System.Drawing.Point(189, 484);
            this.MachineIDText.Margin = new System.Windows.Forms.Padding(2);
            this.MachineIDText.Name = "MachineIDText";
            this.MachineIDText.Size = new System.Drawing.Size(195, 42);
            this.MachineIDText.TabIndex = 23;
            this.MachineIDText.Text = "";
            this.MachineIDText.TextChanged += new System.EventHandler(this.MachineIDText_TextChanged);
            // 
            // PartMaxText
            // 
            this.PartMaxText.Location = new System.Drawing.Point(189, 418);
            this.PartMaxText.Margin = new System.Windows.Forms.Padding(2);
            this.PartMaxText.Name = "PartMaxText";
            this.PartMaxText.Size = new System.Drawing.Size(195, 42);
            this.PartMaxText.TabIndex = 22;
            this.PartMaxText.Text = "";
            this.PartMaxText.TextChanged += new System.EventHandler(this.PartMaxText_TextChanged);
            // 
            // PartPriceText
            // 
            this.PartPriceText.Location = new System.Drawing.Point(189, 349);
            this.PartPriceText.Margin = new System.Windows.Forms.Padding(2);
            this.PartPriceText.Name = "PartPriceText";
            this.PartPriceText.Size = new System.Drawing.Size(195, 42);
            this.PartPriceText.TabIndex = 21;
            this.PartPriceText.Text = "";
            this.PartPriceText.TextChanged += new System.EventHandler(this.PartPriceText_TextChanged);
            // 
            // PartNameText
            // 
            this.PartNameText.Location = new System.Drawing.Point(189, 201);
            this.PartNameText.Margin = new System.Windows.Forms.Padding(2);
            this.PartNameText.Name = "PartNameText";
            this.PartNameText.Size = new System.Drawing.Size(195, 42);
            this.PartNameText.TabIndex = 20;
            this.PartNameText.Text = "";
            this.PartNameText.TextChanged += new System.EventHandler(this.PartNameText_TextChanged);
            // 
            // PartInvText
            // 
            this.PartInvText.Location = new System.Drawing.Point(189, 276);
            this.PartInvText.Margin = new System.Windows.Forms.Padding(2);
            this.PartInvText.Name = "PartInvText";
            this.PartInvText.Size = new System.Drawing.Size(195, 42);
            this.PartInvText.TabIndex = 19;
            this.PartInvText.Text = "";
            this.PartInvText.TextChanged += new System.EventHandler(this.PartInvText_TextChanged);
            // 
            // PartIDText
            // 
            this.PartIDText.Location = new System.Drawing.Point(189, 122);
            this.PartIDText.Margin = new System.Windows.Forms.Padding(2);
            this.PartIDText.Name = "PartIDText";
            this.PartIDText.Size = new System.Drawing.Size(195, 42);
            this.PartIDText.TabIndex = 18;
            this.PartIDText.Text = "";
            this.PartIDText.TextChanged += new System.EventHandler(this.PartIDText_TextChanged);
            // 
            // outsource
            // 
            this.outsource.AutoSize = true;
            this.outsource.Location = new System.Drawing.Point(473, 42);
            this.outsource.Margin = new System.Windows.Forms.Padding(2);
            this.outsource.Name = "outsource";
            this.outsource.Size = new System.Drawing.Size(97, 24);
            this.outsource.TabIndex = 37;
            this.outsource.TabStop = true;
            this.outsource.Text = "3rd Party";
            this.outsource.UseVisualStyleBackColor = true;
            this.outsource.CheckedChanged += new System.EventHandler(this.outsource_CheckedChanged);
            // 
            // inHouse
            // 
            this.inHouse.AutoSize = true;
            this.inHouse.Location = new System.Drawing.Point(285, 42);
            this.inHouse.Margin = new System.Windows.Forms.Padding(2);
            this.inHouse.Name = "inHouse";
            this.inHouse.Size = new System.Drawing.Size(99, 24);
            this.inHouse.TabIndex = 36;
            this.inHouse.TabStop = true;
            this.inHouse.Text = "In House";
            this.inHouse.UseVisualStyleBackColor = true;
            this.inHouse.CheckedChanged += new System.EventHandler(this.inHouse_CheckedChanged);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 728);
            this.Controls.Add(this.outsource);
            this.Controls.Add(this.inHouse);
            this.Controls.Add(this.OutSourceRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartMinText);
            this.Controls.Add(this.MachineIDText);
            this.Controls.Add(this.PartMaxText);
            this.Controls.Add(this.PartPriceText);
            this.Controls.Add(this.PartNameText);
            this.Controls.Add(this.PartInvText);
            this.Controls.Add(this.PartIDText);
            this.Name = "ModifyPart";
            this.Text = "Modify Form";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OutSourceRadio;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PartMinText;
        private System.Windows.Forms.RichTextBox MachineIDText;
        private System.Windows.Forms.RichTextBox PartMaxText;
        private System.Windows.Forms.RichTextBox PartPriceText;
        private System.Windows.Forms.RichTextBox PartNameText;
        private System.Windows.Forms.RichTextBox PartInvText;
        private System.Windows.Forms.RichTextBox PartIDText;
        private System.Windows.Forms.RadioButton outsource;
        private System.Windows.Forms.RadioButton inHouse;
    }
}