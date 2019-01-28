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
    public partial class AddProduct : Form
    {
        //Using Product class
        Product product = new Product();

        //error handling
        public bool errorFound;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            allParts_Table.DataSource = Inventory.getAllPartsTable();
            associatedPartsTable.DataSource = product.getPartsinProductTable();
        }

        private void ProductNameText_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(ProductNameText.Text) || int.TryParse(ProductNameText.Text, out int n)) //Turns textbox salmon if empty or if integer.
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
            if (string.IsNullOrWhiteSpace(ProductMaxText.Text) || !(int.TryParse(ProductMaxText.Text, out int n)))
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

        private void allParts_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void associatedPartsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text) || !(int.TryParse(searchTextBox.Text, out int n)))
            {
                MessageBox.Show("Please enter part ID to search");
            }
           
            try
            {
                int partID = Convert.ToInt32(searchTextBox.Text);

                if (Inventory.lookupPart(partID) == null)
                {
                    MessageBox.Show("Sorry, couldn't find the part " + e);
                }
                else
                {
                    allParts_Table.Rows[Inventory.lookupPart(partID).getPartID()].Selected = true;
                }
            }
            catch
            {
                MessageBox.Show("Search Failed: " + e);
            }
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int part = Convert.ToInt32(allParts_Table.Rows[allParts_Table.CurrentCell.RowIndex].Cells[0].Value);
            product.addPart(Inventory.lookupPart(part));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();

            if(errorFound == false)
            {
                if (Convert.ToInt32(ProductMaxText.Text) < Convert.ToInt32(ProductMinText.Text))
                {

                    MessageBox.Show("Your max Qty. value is greater than your min Qty. " + e);

                }
                else if (product.isAssocPartsEmpty())
                {
                    MessageBox.Show("You need to add at least one part. " + e);
                }
                else
                {

                    product.setProductName(ProductNameText.Text);
                    product.setProductPrice(Convert.ToDouble(ProductPriceText.Text));
                    product.setInStock(Convert.ToInt32(ProductInvText.Text));
                    product.setProductQtyMin(Convert.ToInt32(ProductMinText.Text));
                    product.setProductQtyMax(Convert.ToInt32(ProductMaxText.Text));

                    Inventory.addProduct(product);

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
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this?","Delete", MessageBoxButtons.YesNoCancel);
                
            if(confirm == DialogResult.Yes)
            {
                int part = Convert.ToInt32(associatedPartsTable.Rows[associatedPartsTable.CurrentCell.RowIndex].Cells[0].Value);
                product.removePart(part);
            }
        }
    }
}
