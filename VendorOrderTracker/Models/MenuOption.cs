namespace VendorOrderTracker.Models;

public class MenuOption
{
    public int Cost { get; set; }
    public int Deal { get; set; }
    public string[] Varieties { get; set; }

    public MenuItem(int cost, int deal, string[] varieties)
    {
        Cost = cost;
        Deal = deal;

        for (int i = 0; i < varieties.Length; i++)
            if (varieties[i].Contains("_"))
                varieties[i] = String.Join(" ", varieties[i].Split("_"));
        Varieties = varieties;
    }

    public bool Update(string[] variety)
    {
        string[] temp = new string[Varieties.Length + variety.Length];
        Varieties.CopyTo(temp, 0);
        
    }

    public bool Delete()
}