namespace VendorOrderTracker.Models;

public class Vendor
{
    public string Name { get; }
    public string Description { get; }
    private List<Order> _orders { get; set; }

    private static List<Vendor> _vendors = new List<Vendor>();

    public Vendor(string name, string description)
    {
        Name = name;
        Description = description;
        _orders = new List<Order>();
        _vendors.Add(this);
    }

    public void Add(string description, int price)
    {
        _orders.Add(new Order(Name, description, price));
    }

    public void Add(Order order)
    {
        _orders.Add(order);
    }

    public Order Get(int id)
    {
        return _orders[id];
    }

    public static Vendor Find(string name)
    {
        return _vendors.Find(v => v.Name == name);
    }

    public static Vendor Find(int id)
    {
        return _vendors[id];
    }
}