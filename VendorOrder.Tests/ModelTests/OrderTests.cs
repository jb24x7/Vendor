using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {

    public void Dispose()
    {
      Orders.ClearAll();
    }

    [TestMethod]
    public void OrdersConstructor_CreatesInstanceOfOrder_Orders()
    {
      Orders newOrder = new Orders("test Title", "test Description", 99, new DateTime(2023, 3, 12));
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }

        [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2023, 3, 12);
      Orders newOrder = new Orders(title, description, price, date);
      string titleResult = newOrder.Title;
      Assert.AreEqual(title, titleResult);
    }

        [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2023, 3, 12);
      Orders newOrder = new Orders(title, description, price, date);
      string descriptionResult = newOrder.Description;
      Assert.AreEqual(description, descriptionResult);
    }
  }
}
