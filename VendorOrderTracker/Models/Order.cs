namespace VendorOrderTracker.Models;

public class Order
{
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }
    public string Date { get; }

    public Order(string vendorName, string description, int price)
    {
        
    }
}

/*
Description = description;
        Price = price;
        DateTime now = DateTime.Now;
        Date = now.ToString("yyyy'-'MM'-'dd");
        string timeId = now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        Title = vendorName + timeId;
*/