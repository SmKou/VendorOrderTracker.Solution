namespace VendorOrderTracker.Models;

public class OrderItem
{
    public string Product { get; }
    public string Option { get; }
    public string Variety { get; }
    public int Quantity { get; set; }

    public MenuItem(string product, string option, string variety, int qty)
    {
        Product = product;
        Option = option;
        Variety = variety;
        Quantity = qty;
    }

    public int SubTotal()
    {
        int free = Quantity / (Menu.Deal(Option) + 1);
        return (Quantity - free) * Menu.Cost(Option); 
    }
}