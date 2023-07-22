using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class OrderController : Controller
{
    [HttpGet("/vendors/{vendorName}/orders")]
    public ActionResult Index(string vendorName)
    {
        return View();
    }

    [HttpGet("/vendors/{vendorName}/orders/new")]
    public ActionResult New(string vendorName)
    {
        return View();
    }

    [HttpPost("/vendors/{vendorName}/orders")]
    public ActionResult Create(string vendorName)
    {
        return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorName}/orders/{orderId}")]
    public ActionResult Show(string vendorName, int orderId)
    {
        return View();
    }
}