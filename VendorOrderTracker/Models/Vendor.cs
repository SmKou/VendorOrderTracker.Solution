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
    {}

    public void Add(Order order)
    {}

    public List<Order> Get()
    {}

    public Order Get(int id)
    {}

    public static Vendor Find(string name)
    {}

    public static Vendor Find(int id)
    {}

    public static List<Vendor> GetAll()
    {}

    public static void Clear()
    {
        _vendors.Clear();
    }
}