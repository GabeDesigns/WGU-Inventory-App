using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Outsourced : Part
    {
        //Property
        private string companyName;

        public Outsourced()
        {
            this.setClassification("outsourced");
        }

        //Getter and setter
        public string getCompanyName()
        {
            return companyName;
        }

        public void setCompanyName(string value)
        {
            companyName = value;
            this.setAddInfo(value);
        }
    }
}
