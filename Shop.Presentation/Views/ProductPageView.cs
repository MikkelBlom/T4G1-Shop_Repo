using Avalonia.Controls;
using Shop.Shared;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Shop.Presentation;

public partial class ProductPageView : UserControl
{
    public ObservableCollection<ProductPageCardView> ProductCollection { get; set; } = new();

    public ProductPageView()
    {
        InitializeComponent();
    }

    public ProductPageView(Product[] products) : this()
    {
        foreach (Product p in products)
        {
            ProductCollection.Add(CreateCard(p));
        }

        DataContext = this;
    }

    private ProductPageCardView CreateCard(Product product)
    {
        return new ProductPageCardView(product.productID, product.productName, product.productPrice);
    }
}