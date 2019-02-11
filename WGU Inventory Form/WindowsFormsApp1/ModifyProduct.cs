using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModifyProduct : Form
    {
        public int product;
        public bool errorFound;

        public ModifyProduct(int selectedRow)
        {
            InitializeComponent();
            ProductIDText.Text = selectedRow.ToString();
            product = selectedRow;
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            allPartsTable.DataSource = Inventory.getAllPartsTable();

            associatedPartsTable.DataSource = Inventory.allProducts[product].getPartsinProductTable();

            ProductNameText.Text = Inventory.allProducts[product].getProductName();
            ProductInvText.Text = Inventory.allProducts[product].getInStock().ToString();
            ProductPriceText.Text = Inventory.allProducts[product].getProductPrice().ToString();
            ProductMaxText.Text = Inventory.allProducts[product].getProductQtyMax().ToString();
            ProductMinText.Text = Inventory.allProducts[product].getProductQtyMin().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void allPartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int part = Convert.ToInt32(searchTextBox.Text);

            if (Inventory.lookupPart(part) == null)
            {
                MessageBox.Show("Could not find searched part ID.", "Not Found");
            }
            else
            {
                allPartsTable.Rows[Inventory.lookupPart(part).getPartID()].Selected = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text) || !(int.TryParse(searchTextBox.Text, out int n)))
            {
                MessageBox.Show("No empty spaces or letters please");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int part = Convert.ToInt32(allPartsTable.Rows[allPartsTable.CurrentCell.RowIndex].Cells[0].Value);
            Inventory.allProducts[product].addPart(Inventory.lookupPart(part));
        }

        private void associatedPartsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int productMax;
            int productMin;

            Welcome welcome = new Welcome();

            if (errorFound == false)
            {
                productMax = Convert.ToInt32(ProductMaxText.Text);
                productMin = Convert.ToInt32(ProductMinText.Text);

                if (productMax < productMin)
                {
                    MessageBox.Show("Your min value is greater than your max value");
                }
                else if (Inventory.allProducts[product].isAssocPartsEmpty())
                {
                    MessageBox.Show("You must add at least one part");
                }
                else
                {
                    Inventory.allProducts[product].setProductName(ProductNameText.Text);
                    Inventory.allProducts[product].setProductPrice(
                        Convert.ToDouble(ProductPriceText.Text)
                    );
                    Inventory.allProducts[product].setInStock(
                        Convert.ToInt32(ProductInvText.Text)
                    );
                    Inventory.allProducts[product].setProductQtyMin(
                        Convert.ToInt32(ProductMinText.Text)
                    );
                    Inventory.allProducts[product].setProductQtyMax(
                        Convert.ToInt32(ProductMaxText.Text)
                    );

                    Inventory.updateProduct(product, Inventory.allProducts[product]);

                    this.Hide();
                    welcome.ShowDialog();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this part: " + Convert.ToInt32(associatedPartsTable.Rows[associatedPartsTable.CurrentCell.RowIndex].Cells[0].Value) + "?", "Delete", MessageBoxButtons.YesNoCancel);

            if (confirm == DialogResult.Yes)
            {
                int partSelected = Convert.ToInt32(associatedPartsTable.Rows[associatedPartsTable.CurrentCell.RowIndex].Cells[0].Value);
                Inventory.allProducts[product].removePart(partSelected);
            }
        }

        private void ProductIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNameText.Text) || int.TryParse(ProductNameText.Text, out int n))
            {
                ProductNameText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void ProductInvText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductInvText.Text) || !(int.TryParse(ProductInvText.Text, out int n)))
            {
                ProductInvText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void ProductPriceText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductPriceText.Text) || !(double.TryParse(ProductPriceText.Text, out double n)))
            {
                ProductPriceText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void ProductMaxText_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(ProductMaxText.Text) || !(int.TryParse(ProductMaxText.Text, out int n)))
            {
                ProductMaxText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void ProductMinText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductMinText.Text) || !(int.TryParse(ProductMinText.Text, out int n)))
            {
                ProductMinText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }
    }
}
