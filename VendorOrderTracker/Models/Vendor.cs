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
    }

    public void Add(string title, string description, string date, int price)
    {
        _orders.Add(new Order(Name, title, description, date, price));
    }

    public List<Order> Get()
    {
        return _orders;
    }

    public Order Get(int id)
    {
        if (id < 0 || id > _orders.Count - 1)
            return null;
        return _orders[id];
    }

    public static void AddVendor(string name, string description)
    {
        _vendors.Add(new Vendor(name, description));
    }

    public static Vendor Find(string name)
    {
        return _vendors.Find(v => v.Name == name);
    }

    public static List<Vendor> GetAll()
    {
        return _vendors;
    }

    public static void Clear()
    {
        _vendors.Clear();
    }
}