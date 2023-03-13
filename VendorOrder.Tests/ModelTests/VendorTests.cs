using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }



    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor vendor = new Vendor("test Vendor", "test Description");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "test Name";
      string description = "dest Description";
      Vendor vendor = new Vendor(name, description);
      string testName = vendor.Name;
      Assert.AreEqual(name, testName);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string name = "test Name";
      string description = "test Description";
      Vendor vendor = new Vendor(name, description);
      string testDescription = vendor.Description;
      Assert.AreEqual(description, testDescription);
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendorObject_VendorList()
    {
      string name1 = "first Name";
      string description1 = "first Description";
      string name2 = "second Name";
      string description2 = "second Description";
      Vendor vendor1 = new Vendor(name1, description1);
      Vendor vendor2 = new Vendor(name2, description2);
      List<Vendor> testList = new List<Vendor> { vendor1, vendor2 };
      List<Vendor> resultList = Vendor.GetAll();
      CollectionAssert.AreEqual(testList, resultList);
    }

        [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name1 = "first Name";
      string description1 = "first Description";
      string name2 = "second Name";
      string description2 = "second Description";
      Vendor vendor1 = new Vendor(name1, description1);
      Vendor vendor2 = new Vendor(name2, description2);
      int idResult = vendor1.Id;
      Assert.AreEqual(1, idResult);
    }

    [TestMethod]
    public void AddOrder_AssociatesAnOrdersObjectWithVendorObject_ItemList()
    {
      string orderTitle = "test Title";
      string orderDescription = "test Description";
      int orderPrice = 99;
      DateTime orderDate = new DateTime(2023, 3, 12);
      Orders newOrder = new Orders(orderTitle, orderDescription, orderPrice, orderDate);
      List<Orders> newOrdersList = new List<Orders> { newOrder };
      string vendorName = "test Name";
      string vendorDescription = "test Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
      List<Orders> result = newVendor.Orders;
      CollectionAssert.AreEqual(newOrdersList, result);
    }

  }
}