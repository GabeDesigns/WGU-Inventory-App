using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //Inhouse class is a subclass of part.
    public class InHouse : Part
    {

        //Property
        private int machineID;

        public InHouse()
        {
            this.setClassification("inhouse");
        }

        //Getter and setter
        public int setMachineID()
        {
            return machineID;
        }

        public void setMachineID(int value)
        {
            machineID = value;
            this.setAddInfo(value.ToString());
        }
    }
}
