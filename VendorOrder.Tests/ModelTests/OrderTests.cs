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
      Orders order = new Orders("test Title", "test Description", 99, new DateTime(2023, 3, 12));
      Assert.AreEqual(typeof(Orders), order.GetType());
    }

        [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2023, 3, 12);
      Orders order = new Orders(title, description, price, date);
      string result = order.Title;
      Assert.AreEqual(title, result);
    }

        [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2023, 3, 12);
      Orders order = new Orders(title, description, price, date);
      string result = order.Description;
      Assert.AreEqual(description, result);
    }

        [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_String()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2023, 3, 12);
      Orders order = new Orders(title, description, price, date);
      float result = order.Price;
      Assert.AreEqual(price, result);
    }

        [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_DateTime()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2023, 3, 12);
      Orders order = new Orders(title, description, price, date);
      DateTime result = order.Date;
      Assert.AreEqual(date, result);
    }

        [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "test Title";
      string description = "test Description";
      int price = 99;
      DateTime date = new DateTime(2025, 1, 1);
      Orders order1 = new Orders(title, description, price, date);
      Orders order2 = new Orders(title, description, price, date);
      int result = order2.Id;
      Assert.AreEqual(2, result);
    }


    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      string title1 = "test1 Title";
      string description1 = "test1 Description";
      int price1 = 99;
      DateTime date1 = new DateTime(2023, 3, 12);
      string title2 = "test2 Title";
      string description2 = "test2 Description";
      int price2 = 101;
      DateTime date2 = new DateTime(2023, 3, 12);
      Orders order1 = new Orders(title1, description1, price1, date1);
      Orders order2 = new Orders(title2, description2, price2, date2);
      List<Orders> orderList = new List<Orders> { order1, order2 };
      List<Orders> result = Orders.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }
  }
}
