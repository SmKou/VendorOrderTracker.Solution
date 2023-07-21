namespace VendorOrderTracker.Models;

public class Order
{
    public string Title { get; }
    public string Description { get; }
    public float Price { get; set; }
    public string Date { get; }

    private Dictionary<string, MenuItem> _items = new Dictionary<string, MenuItem>();

    public Order(string vendorName)
    {
        DateTime now = DateTime.Now;
        Date = now.ToString("yyyy'-'MM'-'dd");
        string timeId = now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        Title = vendorName + timeId;
    }

    public void AddItem(MenuItem item)
    {
        string key = $"{item.Option}"
    }
}