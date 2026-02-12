namespace Shop.Shared;

public class Product
{
    private string productID;
    private string productName;
    private double productPrice;

    public Product(string productID, string productName, double productPrice)
    {
        this.productID = productID;
        this.productName = productName;
        this.productPrice = productPrice;
    }
}