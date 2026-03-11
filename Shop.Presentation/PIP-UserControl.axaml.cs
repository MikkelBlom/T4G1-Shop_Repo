using Avalonia.Controls;

namespace Shop.Presentation;

public partial class PIP_UserControl : UserControl
{
    private string ID { get; set; }
    public string Title { get; set; }
    public string Price { get; set; }
    
    public PIP_UserControl()
    {
        ID = "";
        Title = "";
        Price = "";
        InitializeComponent();
    }
    public PIP_UserControl(string id, string title, double price) : this()
    {
        ID = id;
        Title = title;
        Price = price.ToString("F2") + " DKK";

        DataContext = this;
    }
}