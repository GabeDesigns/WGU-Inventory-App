using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WGUInventory
{
    public class Product
    {
       //Variables
        private List<Part> associatedParts = new List<Part>();
        private int productID;
        private string productName;
        private double productPrice;
        private int inStock;
        private int productQtyMin;
        private int productQtyMax;

        private DataTable partsinProductTable = new DataTable();

        public bool isAssocPartsEmpty()
        {
            if (!associatedParts.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable getPartsinProductTable()
        {
            //Checks and adds columns
            if (!partsinProductTable.Columns.Contains("Part #"))  {

                partsinProductTable.Columns.Add("Part #", typeof(int));
            }

            if (!partsinProductTable.Columns.Contains("Part Name")) {

                partsinProductTable.Columns.Add("Part Name", typeof(string));
            }

            if (!partsinProductTable.Columns.Contains("Part Price")) {

                partsinProductTable.Columns.Add("Part Price", typeof(double));
            }

            if (!partsinProductTable.Columns.Contains("Qty. In Stock"))  {

                partsinProductTable.Columns.Add("Qty. In Stock", typeof(int));
            }

            return partsinProductTable;
        }

        public int getProductID()
        {
            return productID;
        }

        public void setProductID(int value)
        {
            productID = value;
        }

        public string getProductName()
        {
            return productName;
        }

        public void setProductName(string value)
        {
            productName = value;
        }

        public double getProductPrice()
        {
            return productPrice;
        }

        public void setProductPrice(double value)
        {
            productPrice = value;
        }

        public int getInStock()
        {
            return inStock;
        }

        public void setInStock(int value)
        {
            inStock = value;
        }

        public int getProductQtyMin()
        {
            return productQtyMin;
        }

        public void setProductQtyMin(int value)
        {
            productQtyMin = value;
        }

        public int getProductQtyMax()
        {
            return productQtyMax;
        }

        public void setProductQtyMax(int value)
        {
            productQtyMax = value;
        }


        public void addPart(Part part)
        {
            partsinProductTable.Rows.Add(
                part.getPartID(),
                part.getPartName(),
                part.getPartPrice(),
                part.getInStock()
                );

            associatedParts.Add(part);
        }

        public bool removePart(int searchedPartID)
        {
            for (int i = 0; i < partsinProductTable.Rows.Count; i++)
            {
                if (partsinProductTable.Rows[i][0].ToString() == searchedPartID.ToString())
                {
                    partsinProductTable.Rows[i].Delete();
                }
            }

            for (int i = 0; i < associatedParts.Count(); i++)
            {
                if (associatedParts[i].getPartID() == searchedPartID)
                {
                    associatedParts.Remove(associatedParts[i]);
                    return true;
                }
            }
            return false;
        }

        //Search based on id
        public Part lookupAssociatedPart(int searchedPartID)
        {
            for (int i = 0; i < associatedParts.Count(); i++)
            {
                if (associatedParts[i].getPartID() == searchedPartID)
                {
                    return associatedParts[i];
                }
            }
            return null;
        }
    }
}