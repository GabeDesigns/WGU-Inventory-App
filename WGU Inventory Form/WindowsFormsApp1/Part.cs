namespace WindowsFormsApp1
{
    public abstract class Part
    {

        //setting variables
        private int partID;
        private string partName;
        private double partPrice;
        private int inStock;
        private int PartQtyMin;
        private int PartQtyMax;

        // 3rd party or in house
        private string classification;

        //addInfo contains machine or company name depending on classification.
        private string addInfo;

        public string getClassification()
        {
            return classification;
        }

        public void setClassification(string value)
        {
            classification = value;
        }

        public string getAddInfo()
        {
            return addInfo;
        }

        public void setAddInfo(string value)
        {
            addInfo = value;
        }

        public int getPartID()
        {
            return partID;
        }

        public void setPartID(int value)
        {
            partID = value;
        }

        public string getPartName()
        {
            return partName;
        }

        public void setName(string value)
        {
            partName = value;
        }

        public double getPartPrice()
        {
            return partPrice;
        }

        public void setpartPrice(double value)
        {
            partPrice = value;
        }

        public int getInStock()
        {
            return inStock;
        }

        public void setInStock(int value)
        {
            inStock = value;
        }

        public int getPartQtyMin()
        {
            return PartQtyMin;
        }

        public void setPartQtyMin(int value)
        {
            PartQtyMin = value;
        }

        public int getMax()
        {
            return PartQtyMax;
        }

        public void setPartQtyMax(int value)
        {
            PartQtyMax = value;
        }
    }
}
