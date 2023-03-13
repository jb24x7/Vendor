using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
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
      Orders newOrder = new Orders("test Title", "test Description", 99, new DateTime(2025, 1, 1));
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }
  }
}
