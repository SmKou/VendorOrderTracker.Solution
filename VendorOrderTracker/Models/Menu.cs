namespace VendorOrderTracker.Models;

public static class Menu
{
    public static Dictionary<string, MenuItem> MenuItems = new Dictionary<string, MenuItem>();

    public bool Add(string product, string option, int cost, int deal, string[] varieties)
    {
        if (MenuItems.ContainsKey(product))
            
        MenuItem item = new MenuItem()
    }

    private bool Update(string product, string option, Dictionary<string, object> mods)
    {
        if (MenuItems[product].)
    }
}