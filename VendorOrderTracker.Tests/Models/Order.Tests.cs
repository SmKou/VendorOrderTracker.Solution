using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests;

[TestClass]
public class OrderTests
{
    [TestMethod]
    public void OrderConstructor_CreateOrderObject_Void()
    {
        string vendor = "Susie Allen Cafe";
        string description = "order for spring festival booth";
        string date = "2023-7-24";
        int price = 30;

        string dateStamp = DateTime.Now.ToString("yyyy'-'MM'-'dd");
        string expected = "susie_allen_cafe";

        Order test = new Order(vendor, description, date, price);

        Assert.AreEqual(typeof(Order), test.GetType());
        Assert.AreEqual(description, test.Description);
        Assert.AreEqual(price, test.Price);
        Assert.AreEqual(date, test.Date);
        Assert.IsTrue(test.Title.Contains(expected));
        Assert.IsTrue(test.Title.Contains(dateStamp));
    }
}