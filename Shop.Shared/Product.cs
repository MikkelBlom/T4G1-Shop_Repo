namespace Shop.Shared;

public class Product
{
    private string productID { public get; private set; }
    private string productName { public get; private set; }
    private double productPrice { public get; private set; }

    public Product(string productID, string productName, double productPrice)
    {
        this.productID = productID;
        this.productName = productName;
        this.productPrice = productPrice;
    }
}
