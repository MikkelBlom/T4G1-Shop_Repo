namespace Shop.Shared;

public class Product
{
    private string productID;
    private string productName;
    private double productPrice;
    private string productCategory;

    public Product(string productID, string productName, double productPrice, string productCategory)
    {
        this.productID = productID;
        this.productName = productName;
        this.productPrice = productPrice;
        this.productCategory = productCategory;
    }
}