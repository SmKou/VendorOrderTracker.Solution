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
        string title = "Spring";
        string description = "order for booth";
        string date = "2023-7-24";
        int price = 30;

        Order test = new Order(vendor, title, description, date, price);

        Assert.AreEqual(typeof(Order), test.GetType());
        Assert.AreEqual(title, test.Title);
        Assert.AreEqual(description, test.Description);
        Assert.AreEqual(price, test.Price);
        Assert.AreEqual(date, test.Date);
    }
}