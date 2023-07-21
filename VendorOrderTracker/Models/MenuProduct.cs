namespace VendorOrderTracker.Models;

public class MenuProduct
{
    private Dictionary<string, MenuOption> _options = new Dictionary<string, MenuOption>();

    public bool Add(string optionName, int cost, int deal, string[] varieties)
    {
        if (_options.ContainsKey(optionName))
            return false;
        MenuOption option = new MenuOption(cost, deal, varieties);
        _options.Add(optionName, option);
        return true;
    }

    public bool Update(string optionName, Dictionary<string, object> mods)
    {
        if (!_options.ContainsKey(optionName))
            return false;

        if (mods.ContainsKey("cost"))
            _options[optionName].Cost = mods["cost"];
        if (mods.ContainsKey("deal"))
            _options[optionName].Deal = mods["deal"];
        if (mods.ContainsKey("varieties"))
        {
            string[] current = _options[optionName].Varieties;
        }
    }

    public bool Delete(string optionName)
    {}
}