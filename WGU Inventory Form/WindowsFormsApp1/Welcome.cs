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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void productGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            partsTable.DataSource = Inventory.getAllPartsTable();
            productsTable.DataSource = Inventory.getProductsTable();
        }

        private void searchPart_Click(object sender, EventArgs e)
        {
            int part = Convert.ToInt32(searchPartTextBox.Text);

            if(Inventory.lookupPart(part) == null)
            {
                MessageBox.Show("Could not find part: " + searchPartTextBox.Text);
            }
            else
            {
                partsTable.Rows[Inventory.lookupPart(part).getPartID()].Selected = true;
            }
        }

        private void searchPartTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchPartTextBox.Text) || !(int.TryParse(searchPartTextBox.Text, out int n)))
            {
                searchPart.Enabled = false;
                searchPartTextBox.BackColor = Color.Red;
            }
            else
            {
                searchPart.Enabled = true;
                searchPartTextBox.BackColor = Color.White;
            }
        }

        private void partsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart addPart = new AddPart();
            addPart.ShowDialog();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            if (Inventory.allParts.Count == 0)
            {
                MessageBox.Show("Sorry, there are no parts to edit.");
            }
            else
            {
                int part = Convert.ToInt32(partsTable.Rows[partsTable.CurrentCell.RowIndex].Cells[0].Value);
                ModifyPart modifyPart = new ModifyPart(part);
                modifyPart.ShowDialog();
            }
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if(Inventory.allParts.Count == 0)
            {
                MessageBox.Show("There are no parts to delete");
            }
            else
            {
                DialogResult confirmPart = MessageBox.Show("Are you sure you want to delete this part? " + partsTable.Rows[partsTable.CurrentCell.RowIndex].Cells[0].Value, "Delete", MessageBoxButtons.YesNoCancel);

                if (confirmPart == DialogResult.Yes)
                {
                    int part = Convert.ToInt32(partsTable.Rows[partsTable.CurrentCell.RowIndex].Cells[0].Value);
                    Inventory.deletePart(Inventory.lookupPart(part));
                }
            }
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            int product = Convert.ToInt32(searchProductTextBox.Text);

            if (Inventory.lookupProduct(product) == null)
            {
                MessageBox.Show("Could not find product: " + searchProductTextBox.Text);
            }
            else
            {
                productsTable.Rows[Inventory.lookupProduct(product).getProductID()].Selected = true;
            }
        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchProductTextBox.Text) || !(int.TryParse(searchProductTextBox.Text, out int n)))
            {
                searchProduct.Enabled = false;
                searchProductTextBox.BackColor = Color.Red;
            }
            else
            {
                searchProduct.Enabled = true;
                searchProductTextBox.BackColor = Color.White;
            }
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addproduct = new AddProduct();
            addproduct.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            if(Inventory.allProducts.Count == 0)
            {
                MessageBox.Show("No products to modify");
            }
            else
            {
                int product = Convert.ToInt32(productsTable.Rows[productsTable.CurrentCell.RowIndex].Cells[0].Value);
                ModifyProduct modifyProduct = new ModifyProduct(product);
                modifyProduct.ShowDialog();
                this.Hide();
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (Inventory.allProducts.Count == 0)
            {
                MessageBox.Show("There are no products to delete");
            }
            else
            {
                DialogResult confirmProduct = MessageBox.Show("Are you sure you want to delete this product? " + productsTable.Rows[productsTable.CurrentCell.RowIndex].Cells[0].Value, "Delete", MessageBoxButtons.YesNoCancel);

                if (confirmProduct == DialogResult.Yes)
                {
                    int product = Convert.ToInt32(productsTable.Rows[productsTable.CurrentCell.RowIndex].Cells[0].Value);
                    Inventory.removeProduct(product);
                }
            }
        }
    }
}
