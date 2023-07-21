namespace VendorOrderTracker.Models;

public class Vendor
{
    public string Name { get; }
    public string Description { get; }
    private Dictionary<string, Order> _orders = new Dictionary<string, Order>();
}