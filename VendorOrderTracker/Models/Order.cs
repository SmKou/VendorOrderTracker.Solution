namespace VendorOrderTracker.Models;

public class Order
{
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }
    public string Date { get; }

    public Order(string vendorName, string description, string date, int price)
    {
        Description = description;
        Price = price;
        Date = date;

        DateTime now = DateTime.Now;
        string timeId = now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        string vendor = String.Join("_", vendorName.ToLower().Split(" "));
        Title = vendor + timeId;
    }
}