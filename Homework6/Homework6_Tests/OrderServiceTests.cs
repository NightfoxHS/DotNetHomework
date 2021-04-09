using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.IO;

namespace Homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        static List<Order> orders = new List<Order>();
        static List<Customer> customers = new List<Customer>();
        static List<Goods> goodses = new List<Goods>();
        static OrderService os;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            customers.Add(new Customer("Ada", "42"));
            customers.Add(new Customer("Bob", "37"));
            goodses.Add(new Goods("Milk", 6));
            goodses.Add(new Goods("Bread", 3));
        }

        [TestInitialize]
        public void TestInitialize()
        {
            os = new OrderService();
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateCustomerTest1()
        {
            os.CreateCustomer("  ","42");
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void CreateCustomerTest2()
        {
            os.CreateCustomer("Ada", "42");
            os.CreateCustomer("Ada", "42");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateGoodsTest1()
        {
            os.CreateGoods("  ", 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void CreateGoodsTest2()
        {
            os.CreateGoods("Milk", 1);
            os.CreateGoods("Milk", 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateGoodsTest3()
        {
            os.CreateGoods("Milk", -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveCustomerTest()
        {
            os.CreateCustomer("Ada", "42");
            os.CreateCustomer("Bob", "37");
            os.RemoveCustomer(2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveGoodsTest()
        {
            os.CreateGoods("Milk", 1);
            os.CreateGoods("Bread", 1);
            os.RemoveGoods(2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveOrderTest()
        {
            os.CreateOrder(customers[0]);
            os.CreateOrder(customers[1]);
            os.RemoveOrder(2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ModifyGoodsTest1()
        {
            os.CreateGoods("Milk", 1);
            os.ModifyGoods(0, null, 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ModifyGoodsTest2()
        {
            os.CreateGoods("Milk", 1);
            os.ModifyGoods(1, "Bread", 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ModifyGoodsTest3()
        {
            os.CreateGoods("Milk", 1);
            os.ModifyGoods(0, "Bread", -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ModifyCustomerTest1()
        {
            os.CreateCustomer("Ada", "42");
            os.ModifyCustomer(0, null, "42");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ModifyCustomerTest2()
        {
            os.CreateCustomer("Ada", "42");
            os.ModifyCustomer(1, "Bob", "42");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DisplayDetailOfOrderTest()
        {
            os.CreateOrder(customers[0]);
            os.DisplayDetailOfOrder(1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DisplayOrdersTest1()
        {
            os.DisplayOrders(null);
        }

        [TestMethod()]
        public void OrderByPriceTest()
        {
            os.CreateOrder(customers[0]);
            os.CreateOrder(customers[1]);
            os.GetOrder(0).Add(goodses[0], 3);
            os.GetOrder(1).Add(goodses[0], 1);
            List<Order> expectedOrder = new List<Order>();
            expectedOrder.Add(os.GetOrder(1));
            expectedOrder.Add(os.GetOrder(0));
            List<Order> res = (List<Order>)os.OrderByPrice(os.GetOrders());
            CollectionAssert.AreEqual(res, expectedOrder);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void ImportOrdersTest()
        {
            File.Create("Orders.xml");
            os.ImportOrders("Orders.xml");
        }
    }
}