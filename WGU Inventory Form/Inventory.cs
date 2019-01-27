using System;

public class Inventory {
	
    ObservableList<Product> products = FXCollections.observableArrayList();
    ObservableList<Part> allParts = FXCollections.observableArrayList();
    int partIDCount = 0;
    int productIDCount = 0;
    bool alreadyExecuted = false;


    public static ObservableList<Part> getAllParts()
    {
        return allParts;
    }

    public static void addPart(Part part)
    {
        allParts.add(part);
    }

    public static void deletePart(Part part)
    {
        allParts.remove(part);
    }

    public static void updatePart(int index, Part part)
    {
        allParts.set(index, part);
    }

    public static int getPartIDCount()
    {
        partIDCount++;
        return partIDCount;
    }

    public static int cancelPartIDCount(int itemNumber)
    {
        for (Part p: getAllParts())
        {
            if (p.getPartID() == itemNumber) {
                return p;
            }

        }
        return null;

    }

    public static ObservableList<Product> getProducts()
    {
        return products;
    }

    public static void addProduct(Product product)
    {
        products.add(product);
    }

    public static void removeProduct(Product product)
    {
        products.remove(product);
    }

    public static int getProductIDCount()
    {
        productIDCount++;
        return productIDCount;

    }

    public static int cancelProductIDCount()
    {
        productIDCount--;
        return productIDCount;

    }

    public static Product lookupProduct(int itemNumber)
    {
        for (Product P: getProducts())
        {
            if (P.getProductID() == itemNumber)
            {
                return P;
            }
        }
        return null;
    }

    public static void updateProduct(int index, Product product)
    {
        products.set(index, product);
    }
}
