namespace Shop.Shared;

public class Product
{
    public string productID { get; private set; }
    public string productName { get; private set; }
    public double productPrice { get; private set; }
    public string productCategory { get; private set; }

    public Product(string productID, string productName, double productPrice, string productCategory)
    {
        this.productID = productID;
        this.productName = productName;
        this.productPrice = productPrice;
        this.productCategory = productCategory;
    }
}