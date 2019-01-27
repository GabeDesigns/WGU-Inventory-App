using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WGUInventory
{
    public class Inventory
    {
        public static List<Product> products = new List<Product>();
        public static List<Part> allParts = new List<Part>();
        public static int partCount = 0;
        public static int productCount = 0;
        
        //Tables
        private static DataTable allPartsTable = new DataTable();
        private static DataTable allProductsTable = new DataTable();


        public static DataTable getAllPartsDataTable()
        {
            //If column does not exist, add column.
            if (!allPartsTable.Columns.Contains("Part #")) {

                allPartsTable.Columns.Add("Part #", typeof(int));
            }

            if (!allPartsTable.Columns.Contains("Part Name")) {

                allPartsTable.Columns.Add("Part Name", typeof(string));
            }

            if (!allPartsTable.Columns.Contains("Part Price")) {

                allPartsTable.Columns.Add("Part Price", typeof(double));
            }

            if (!allPartsTable.Columns.Contains("Qty. In Stock")) {

                allPartsTable.Columns.Add("Qty. In Stock", typeof(int));
            }


            return allPartsTable;

        }

        public static DataTable getProductsTable()
        {
            //If column does not exist, add column.
            if (!allProductsTable.Columns.Contains("Product ID")) {

                allProductsTable.Columns.Add("Product ID", typeof(int));
            }

            if (!allProductsTable.Columns.Contains("Product Name")) {

                allProductsTable.Columns.Add("Product Name", typeof(string));
            }

            if (!allProductsTable.Columns.Contains("Product Price")) {

                allProductsTable.Columns.Add("Product Price", typeof(double));
            }

            if (!allProductsTable.Columns.Contains("Qty. In Stock")) {

                allProductsTable.Columns.Add("Qty. In Stock", typeof(int));
            }

            return allProductsTable;

        }

        //Adds product to products ArrayList.
        public static void addProduct(Product product)
        {
            product.setProductID(productCount);
            products.Add(product);

            allProductsTable.Rows.Add(
                product.getProductID(),
                product.getProductName(),
                product.getProductPrice(),
                product.getInStock()
                );

            productCount++;
        }

        //Removes product if the element at index is not null, then returns true.
        public static bool removeProduct(int searchedProductID)
        {
            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].getProductID() == searchedProductID)
                {
                    allProductsTable.Rows[products[i].getProductID()].Delete();
                    products.Remove(products[i]);
                    return true;
                }

            }
            return false;
        }

        //Returns product being searched based on product ID.
        public static Product lookupProduct(int productID)
        {
            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].getProductID() == productID)
                {

                    return products[i];
                }
            }
            return null;
        }

        //Product at index is updated.
        public static void updateProduct(int index, Product product)
        {
            allProductsTable.Rows[index][0] = product.getProductID();
            allProductsTable.Rows[index][1] = product.getProductName();
            allProductsTable.Rows[index][2] = product.getProductPrice();
            allProductsTable.Rows[index][3] = product.getInStock();

            products[index] = product;
        }

        //Adds part to allParts ArrayList.
        public static void addPart(Part part)
        {

            part.setPartID(partCount);
            allParts.Add(part);

            allPartsTable.Rows.Add(
                part.getPartID(),
                part.getPartName(),
                part.getPartPrice(),
                part.getInStock()
                );

            partCount++;
        }

        //If allParts arrayList contains part, part is deleted.
        public static bool deletePart(Part part)
        {

            if (allParts.Contains(part) == false)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < allPartsTable.Rows.Count; i++)
                {
                    if (allPartsTable.Rows[i][0].ToString() == part.getPartID().ToString())
                    {
                        allPartsTable.Rows[i].Delete();
                    }
                }
                allParts.Remove(part);
                return true;
            }
        }

        //Returns part based on part ID
        public static Part lookupPart(int searchedPartID)
        {
            for (int i = 0; i < allParts.Count(); i++)
            {
                if (allParts[i].getPartID() == searchedPartID)
                {

                    return allParts[i];

                }
            }
            return null;
        }

        //Sets item at index to part.
        public static void updatePart(int index, Part part)
        {
            allPartsTable.Rows[index][0] = part.getPartID();
            allPartsTable.Rows[index][1] = part.getPartName();
            allPartsTable.Rows[index][2] = part.getPartPrice();
            allPartsTable.Rows[index][3] = part.getInStock();

            allParts[index] = part;
        }
    }
}
