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
    public partial class AddPart : Form
    {
        public bool errorFound;

        public AddPart()
        {
            InitializeComponent();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MachineIDText.Text) ||
                (InHouseRadio.Checked && !(int.TryParse(MachineIDText.Text, out int n))))
            {
                errorFound = true;
                MachineIDText.BackColor = Color.Red;
            }
        }

        private void OutSourceRadio_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";
            if (string.IsNullOrWhiteSpace(MachineIDText.Text) || int.TryParse(nameTextBox.Text, out int s))
            {
                errorFound = true;
                MachineIDText.BackColor = Color.Red;               
            }
        }

        private void PartIDText_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(PartIDText.Text) || int.TryParse(PartIDText.Text, out int n))
            {
                errorFound = true;
                PartIDText.BackColor = Color.Red;

                MessageBox.Show("Please use only integers in ID field");
            }
        }

        private void PartNameText_TextChanged(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(PartNameText.Text) || int.TryParse(PartNameText.Text, out int n))
            {
                errorFound = true;
                PartNameText.BackColor = Color.Red;
                MessageBox.Show("Error, name cannot be empty or contain integers");
                SaveBtn.Enabled = false;
            }
        
           
        }

        private void PartInvText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartInvText.Text) || !(int.TryParse(PartInvText.Text, out int n)))
            {
                errorFound = true;
                PartInvText.BackColor = Color.Red;

                MessageBox.Show("Please review your input");
            }
        }

        private void PartPriceText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartPriceText.Text) || !(double.TryParse(PartPriceText.Text, out double n)))
            {
                errorFound = true;
                PartPriceText.BackColor = Color.Red;
            }
        }

        private void PartMaxText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartMaxText.Text) || !(int.TryParse(PartMaxText.Text, out int n)))
            {
                errorFound = true;
                PartMaxText.BackColor = Color.Red;
            }
        }

        private void MachineIDText_TextChanged(object sender, EventArgs e)
        {
            //In house parts only accept integer machine ids.
            if (string.IsNullOrWhiteSpace(MachineIDText.Text) ||
                (InHouseRadio.Checked && !(int.TryParse(MachineIDText.Text, out int n))) ||
                (OutSourceRadio.Checked && int.TryParse(MachineIDText.Text, out int s)))
            {
                errorFound = true;
                MachineIDText.BackColor = Color.Red;

                if (InHouseRadio.Checked)
                {
                   MessageBox.Show("Machine ID requires numbers only");
                }
            }
        }

        private void PartMinText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartMinText.Text) || !(int.TryParse(PartMinText.Text, out int n)))
            {
                errorFound = true;
                PartMinText.BackColor = Color.Red;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();

            InHouse inHouse;
            Outsourced outsourced;

           if(Convert.ToInt32(PartMaxText.Text) < Convert.ToInt32(PartMinText.Text))
            {
                MessageBox.Show("Your Min Qty is greater than the Max Qty value");
            }
           else
            {
                if (errorFound == true)
                {
                    SaveBtn.Enabled = false;
                    MessageBox.Show("Please go back and review your input" + e);
                }

                if (InHouseRadio.Checked)
                {
                    inHouse = new InHouse();

                    inHouse.setPartID(Convert.ToInt16(PartIDText.Text));
                    inHouse.setName(PartNameText.Text);
                    inHouse.setPartPrice(Convert.ToDouble(PartPriceText.Text));
                    inHouse.setInStock(Convert.ToInt32(PartInvText.Text));
                    inHouse.setPartQtyMin(Convert.ToInt32(PartMinText.Text));
                    inHouse.setPartQtyMax(Convert.ToInt32(PartMaxText.Text));
                    inHouse.setMachineID(Convert.ToInt32(MachineIDText.Text));

                    Inventory.addPart(inHouse);
                }

                else if (OutSourceRadio.Checked)
                {
                    outsourced = new Outsourced();

                    outsourced.setPartID(Convert.ToInt16(PartIDText.Text));
                    outsourced.setName(PartNameText.Text.ToString());
                    outsourced.setPartPrice(Convert.ToDouble(PartPriceText.Text));
                    outsourced.setInStock(Convert.ToInt32(PartInvText.Text));
                    outsourced.setPartQtyMin(Convert.ToInt32(PartMinText.Text));
                    outsourced.setPartQtyMax(Convert.ToInt32(PartMaxText.Text));
                    outsourced.setCompanyName(MachineIDText.Text);

                    Inventory.addPart(outsourced);
                }

                this.Hide();

                welcome.ShowDialog();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.Show();
        }
    }
}
