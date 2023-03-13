//     [TestMethod]
//     public void GetOrderTitle_ReturnsOrderTitle_String()
//     {
//       string title = "test Title";
//       string description = "test Description";
//       int price = 99;
//       DateTime date = new DateTime(2025, 1, 1);
//       Orders newOrder = new Orders(title, description, price, date);
//       string titleResult = newOrder.Title;
//       Assert.AreEqual(title, titleResult);
//     }

//     [TestMethod]
//     public void GetOrderDescription_ReturnsOrderDescription_String()
//     {
//       string title = "test Title";
//       string description = "test Description";
//       int price = 99;
//       DateTime date = new DateTime(2025, 1, 1);
//       Orders newOrder = new Orders(title, description, price, date);
//       string descriptionResult = newOrder.Description;
//       Assert.AreEqual(description, descriptionResult);
//     }

//     [TestMethod]
//     public void GetOrderPrice_ReturnsOrderPrice_String()
//     {
//       string title = "test Title";
//       string description = "test Description";
//       int price = 99;
//       DateTime date = new DateTime(2025, 1, 1);
//       Orders newOrder = new Orders(title, description, price, date);
//       float priceResult = newOrder.Price;
//       Assert.AreEqual(price, priceResult);
//     }


//     [TestMethod]
//     public void GetOrderDate_ReturnsOrderDate_DateTime()
//     {
//       string title = "test Title";
//       string description = "test Description";
//       int price = 99;
//       DateTime date = new DateTime(2023, 3, 12);
//       Orders newOrder = new Orders(title, description, price, date);
//       DateTime dateResult = newOrder.Date;
//       Assert.AreEqual(date, dateResult);
//     }

//     [TestMethod]
//     public void GetId_ReturnsVendorId_Int()
//     {
//       string title = "test Title";
//       string description = "test Description";
//       int price = 99;
//       DateTime date = new DateTime(2025, 1, 1);
//       Orders newOrder1 = new Orders(title, description, price, date);
//       Orders newOrder2 = new Orders(title, description, price, date);
//       int idResult = newOrder2.Id;
//       Assert.AreEqual(2, idResult);
//     }


//     [TestMethod]
//     public void GetAll_ReturnsOrders_OrdersList()
//     {
//       string title1 = "test1 Title";
//       string description1 = "test1 Description";
//       int price1 = 99;
//       DateTime date1 = new DateTime(2023, 3, 12);
//       string title2 = "test2 Title";
//       string description2 = "test2 Description";
//       int price2 = 101;
//       DateTime date2 = new DateTime(2023, 3, 12);
//       Orders newOrder1 = new Orders(title1, description1, price1, date1);
//       Orders newOrder2 = new Orders(title2, description2, price2, date2);
//       List<Orders> newOrdersList = new List<Orders> { newOrder1, newOrder2 };
//       List<Orders> result = Orders.GetAll();
//       CollectionAssert.AreEqual(newOrdersList, result);
//     }

//   }

// }