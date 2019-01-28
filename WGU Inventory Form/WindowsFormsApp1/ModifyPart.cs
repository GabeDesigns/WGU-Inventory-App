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
    public partial class ModifyPart : Form
    {
        public int part;
        public bool errorFound;

        public ModifyPart(int selectedRow)
        {
            InitializeComponent();
            PartIDText.Text = selectedRow.ToString();

            part = selectedRow;

        }

        private void PartIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartNameText.Text) || int.TryParse(PartNameText.Text, out int n))
            {
                PartNameText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void PartInvText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartInvText.Text) || !(int.TryParse(PartInvText.Text, out int n)))
            {
                PartInvText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void PartPriceText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartPriceText.Text) || !(double.TryParse(PartPriceText.Text, out double n)))
            {
                PartPriceText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void PartMaxText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartMaxText.Text) || !(int.TryParse(PartMaxText.Text, out int n)))
            {
                PartMaxText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void PartMinText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartMinText.Text) || !(int.TryParse(PartMinText.Text, out int n)))
            {
                PartMinText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MachineIDText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MachineIDText.Text) ||
          (inHouse.Checked && !(int.TryParse(MachineIDText.Text, out int n))) ||
          (outsource.Checked && int.TryParse(MachineIDText.Text, out int s)))
            {

                MachineIDText.BackColor = Color.Red;
                errorFound = true;

                if (inHouse.Checked)
                {
                    MessageBox.Show("Machine ID requires numbers only");
                }
                else if (outsource.Checked)
                {
                    MessageBox.Show("Company Name requires values, letters only");
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            InHouse inhouse;
            Outsourced outsourced;
            if(errorFound == false)
            {
                if (inHouse.Checked)
                {
                    inhouse = new InHouse();
                    inhouse.setPartID(part);
                    inhouse.setName(PartNameText.Text.ToString());
                    inhouse.setPartPrice(Convert.ToDouble(PartPriceText.Text));
                    inhouse.setInStock(Convert.ToInt32(PartInvText.Text));
                    inhouse.setPartQtyMin(Convert.ToInt32(PartMinText.Text));
                    inhouse.setPartQtyMax(Convert.ToInt32(PartMaxText.Text));
                    inhouse.setMachineID(Convert.ToInt32(MachineIDText.Text));

                    Inventory.updatePart(part, inhouse);
                }

                else if (outsource.Checked)
                {
                    outsourced = new Outsourced();
                    outsourced.setPartID(part);
                    outsourced.setName(PartNameText.Text.ToString());
                    outsourced.setPartPrice(Convert.ToDouble(PartPriceText.Text));
                    outsourced.setInStock(Convert.ToInt32(PartInvText.Text));
                    outsourced.setPartQtyMin(Convert.ToInt32(PartMinText.Text));
                    outsourced.setPartQtyMax(Convert.ToInt32(PartMaxText.Text));
                    outsourced.setCompanyName(MachineIDText.Text);

                    Inventory.updatePart(part, outsourced);
                }
            }
            
            this.Hide();
            welcome.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
        }

        private void inHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MachineIDText.Text) || !(int.TryParse(MachineIDText.Text, out int n)))
            {
                MachineIDText.BackColor = Color.Red;
                errorFound = true;
            }
        }

        private void outsource_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";

            if (string.IsNullOrWhiteSpace(MachineIDText.Text) || !(int.TryParse(MachineIDText.Text, out int n)))
            {
                MachineIDText.BackColor = Color.Red;
                errorFound = true;
            }
            else
            {
                errorFound = false;
            }
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            PartNameText.Text = Inventory.allParts[part].getPartName();
            PartInvText.Text = Inventory.allParts[part].getInStock().ToString();
            PartPriceText.Text = Inventory.allParts[part].getPartPrice().ToString();
            PartMaxText.Text = Inventory.allParts[part].getPartQtyMax().ToString();
            PartMinText.Text = Inventory.allParts[part].getPartQtyMin().ToString();
            MachineIDText.Text = Inventory.allParts[part].getClassification();

            if (Inventory.allParts[part].getClassification() == "inhouse")
            {
                inHouse.Checked = true;
            }
            else
            {
                outsource.Checked = true;
            }

        }
    }
}
