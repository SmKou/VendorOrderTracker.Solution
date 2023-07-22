using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests;

[TestClass]
public class VendorTests : IDisposable
{
    [TestMethod]
    public void VendorConstructor_CreateVendorObject_Void()
    {
        string name = "Susie";
        string description = "cafe";

        Vendor test = new Vendor(name, description);

        Assert.AreEqual(typeof(Vendor), test.GetType());
        Assert.AreEqual(name, test.Name);
        Assert.AreEqual(description, test.Description);
    }

    [TestMethod]
    public void AddandGet_AddOrderToOrdersWithData_Void()
    {
        string name = "Susie";
        string description = "cafe";
        string orderName = "donuts";
        string orderDescription = "booth";
        string date = "2023-7-24";
        int price = 1;
        int id = 0;

        Vendor test = new Vendor(name, description);
        test.Add(orderName, orderDescription, date, price);
        Order result = test.Get(id);

        Assert.AreEqual(1, test.Get().Count);
        Assert.AreEqual(orderDescription, result.Description);
    }

    [TestMethod]
    public void Get_ReturnListOfOrdersForVendor_OrderList()
    {
        string name = "Susie";
        string description = "cafe";
        string orderName = "donuts";
        string orderDescription = "booth";
        string date = "2023-7-24";
        int price = 1;

        Vendor test = new Vendor(name, description);
        test.Add(orderName, orderDescription, date, price);
        List<Order> expected = new List<Order>
        {
            test.Get(0)
        };
        List<Order> result = test.Get();

        CollectionAssert.AreEqual(expected, result);
        Assert.AreEqual(1, result.Count);
    }

    public void Dispose()
    {
        Vendor.Clear();
    }

    [TestMethod]
    public void AddVendor_CreateAndAddVendorToVendors_Void()
    {
        string name = "Susie";
        string description = "cafe";
        Vendor.AddVendor(name, description);

        Assert.AreEqual(1, Vector.GetAll().Count);
        Assert.AreEqual(name, Vector.Find(1).Name);
        Assert.AreEqual(description, Vector.Find(1).Description);
    }

    [TestMethod]
    public void Find_ReturnVendorFoundWithName_Vendor()
    {
        string name = "Susie";
        string description = "cafe";
        Vendor test = new Vendor(name, description);
        Vendor result = Vendor.Find(name);

        Assert.AreEqual(test.Name, result.Name);
        Assert.AreEqual(test.Description, result.Description);
    }

    [TestMethod]
    public void GetAll_ReturnListOfVendors_VendorList()
    {
        string name = "Susie";
        string description = "cafe";
        
        Vendor test = new Vendor(name, description);
        List<Vendor> expected = new List<Vendor> { test };

        List<Vendor> result = Vendor.GetAll();

        CollectionAssert.AreEqual(expected, result);
    }
}