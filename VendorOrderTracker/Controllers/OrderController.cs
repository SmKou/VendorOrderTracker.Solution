using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class OrderController : Controller
{
    [HttpGet("/vendors/{vendorName}/orders/new")]
    public ActionResult New(string vendorName)
    {
        Vendor vendor = Vendor.Find(vendorName);
        return View(vendor);
    }
}