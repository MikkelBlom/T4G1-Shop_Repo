using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform;

namespace Shop.Presentation;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ReloadContent(new Object(), new RoutedEventArgs());
    }

    public void ReloadContent (Object sender, RoutedEventArgs e)
    {
        int itemCount = 30;

        string[] productNames =
        {
            "Tesla Model S",
            "Yogurt",
            "Svergie",
            "Troels Lund Poulsen",
            "Google Calandar",
            "Intet navn fundet",
            "Mount Everest",
            "Banan",
            "Mette Frederiksen",
            "iPhone 15",
            "Vatikanstaten",
            "Kvantecomputere",
            "Københavns Hovedbanegård",
            "Rødspætte",
            "Microsoft Excel",
            "Eiffeltårnet",
            "Grundloven",
            "Coca-Cola",
            "Mars",
            "H.C. Andersen",
            "Bitcoin",
            "Stegepande",
            "Grønland",
            "Champions League",
            "LEGO",
            "Vindmølle",
            "Nelson Mandela",
            "Panodil",
            "Østersøen",
            "Netflix",
            "Gaffel",
            "Pyramiderne i Giza",
            "Mælkevejen",
            "Novo Nordisk",
            "Tuba",
            "Kænguru",
            "Leonardo da Vinci",
            "Solbriller",
            "Berlinmuren",
            "Wifi-router",
            "Rugbrød",
            "NASA",
            "Vesterhavet",
            "Elon Musk",
            "Klorin",
            "Stethoscope",
            "Amazonasregnskoven",
            "Spotify",
            "Beton",
            "Albert Einstein",
            "Hundesnor",
            "Island",
            "Airbus A380",
            "Skakbræt",
            "Mariehøne",
            "Tsunami",
            "Ludwig van Beethoven",
            "Saltkværn",
            "FN",
            "Grand Canyon",
            "Bluetooth",
            "Cykelhjelm",
            "Madagascar",
            "Dronning Margrethe",
            "Kanyle",
            "Picasso",
            "Eskalator",
            "Gulvvarme",
            "Andromeda-galaksen",
            "Lidocain",
            "Aarhus Universitet",
            "Blyant",
            "NATO",
            "Solsikke",
            "Jernbaneskinne",
            "Kim Kardashian",
            "Sahara",
            "Opvaskemaskine",
            "Zlatan Ibrahimovic",
            "Kalksten",
            "USB-stik",
            "Færøerne",
            "Tandbørste",
            "Mozart",
            "Kanyle",
            "Sydney Opera House",
            "Atlanterhavet",
            "Hæftemaskine",
            "Skagen",
            "Tesla Powerwall",
            "Giraf",
            "William Shakespeare",
            "Mikrobølgeovn",
            "Tokyo",
            "Boremaskine",
            "Statue of Liberty",
            "Papirclips",
            "DNA-profil",
            "Toyota Corolla",
            "Paracetamol",
            "Himalaya",
            "Yoda (Star Wars)",
            "Kreditkort",
            "Vandmelon",
            "Jean-Luc Picard",
            "Kronborg Slot"
        };

        Shared.Product[] products = new Shared.Product[itemCount];

        Random rand = new Random();

        for (int i = 0; i < itemCount; i++)
        {
            string name = productNames[rand.Next(0, productNames.Length)];
            double price = rand.NextDouble() * 10000 + 100;

            products[i] = new Shared.Product("id", name, price, "catagory");
        }

        PageContainer.Content = new ProductPageView(products);
    }
}