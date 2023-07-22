using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class VendorController : Controller
{
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
        List<Vendor> vendors = Vendor.GetAll();
        return View(vendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(IFormCollection collection)
    {
        Vendor.AddVendor(collection["vendorName"], collection["description"]);
        return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorName}/orders")]
    public ActionResult Show(string vendorName)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("VendorName", vendorName);
        List<Order> orders = Vendor.Find(vendorName).Get();
        model.Add("Orders", orders);
        return View(model);
    }

    [HttpPost("/vendors/{vendorName}/orders")]
    public ActionResult Show(IFormCollection collection)
    {
        string vendorName = collection["vendorName"];
        string title = collection["title"];
        string description = collection["description"];
        int price = int.Parse(collection["price"]);
        string date = collection["date"];
        Vendor.Find(vendorName).Add(title, description, date, price);

        Dictionary<string, object> model = new Dictionary<string, object>();
        List<Order> orders = Vendor.Find(vendorName).Get();
        model.Add("VendorName", vendorName);
        model.Add("Orders", orders);
        return View(model);
    }
}