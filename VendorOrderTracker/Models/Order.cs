namespace VendorOrderTracker.Models;

public class Order
{
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }
    public string Date { get; }
    private string _identifier { get; set; }

    public Order(string vendorName, string title, string description, string date, int price)
    {
        Title = title;
        Description = description;
        Price = price;
        Date = date;

        DateTime now = DateTime.Now;
        string timeId = now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        string vendor = String.Join("_", vendorName.ToLower().Split(" "));
        _identifier = vendor + timeId;
    }
}