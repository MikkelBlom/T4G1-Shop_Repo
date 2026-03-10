using Avalonia.Controls;

namespace Shop.Presentation;

public partial class ProductPageCardView : UserControl
{
    private string ID { get; set; }
    public string Title { get; set; }
    public string Price { get; set; }
    
    public ProductPageCardView()
    {
        ID = "";
        Title = "";
        Price = "";
        InitializeComponent();
    }

    public ProductPageCardView(string id, string title, double price) : this()
    {
        ID = id;
        Title = title;
        Price = price.ToString("F2") + " DKK";

        DataContext = this;
    }
}