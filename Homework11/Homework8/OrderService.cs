using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Data.Entity;

namespace Homework8
{
    public delegate bool QueryFunc_P(float x);
    public delegate bool QueryFunc_T(DateTime t);

    public class OrderService
    {
        private readonly List<Order> orders = new List<Order>();
        private readonly List<Customer> customers = new List<Customer>();
        private readonly List<Goods> goodses = new List<Goods>();
        public List<Order> Orders { get => orders; }
        public List<Customer> Customers { get => customers; }
        public List<Goods> Goodses { get => goodses; }

        public OrderService()
        {

        }

        public static void CreateCustomer(string name, string addr)
        {
            using(var db = new OrderContext())
            {
                Customer cus = new Customer(name, addr);
                db.Customers.Add(cus);
                db.SaveChanges();
            }
        }

        public static void CreateGoods(string type, float price)
        {
            using (var db = new OrderContext())
            {
                Goods goods = new Goods(type, price);
                db.Goodses.Add(goods);
                db.SaveChanges();
            }
        }

        public static void CreateOrder(Customer customer,DateTime time)
        {
            using (var db = new OrderContext())
            {
                Order order = new Order(customer, time);
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public static void RemoveCustomer(int id)
        {
            using (var db = new OrderContext())
            {
                var cus = db.Customers.Where(o => o.Id == id).FirstOrDefault();
                db.Customers.Remove(cus);
                db.SaveChanges();
            }
        }

        public static void RemoveGoods(int id)
        {
            using (var db = new OrderContext())
            {
                var goods = db.Goodses.Where(o => o.Id == id).FirstOrDefault();
                db.Goodses.Remove(goods);
                db.SaveChanges();
            }
        }

        public static void RemoveOrder(int id)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("OrderDetails").Where(o => o.Id == id).FirstOrDefault();
                db.Orders.Remove(order);
                db.SaveChanges();
            }
        }

        public static void ModifyGoods(int id, string type, float price)
        {
            using(var db = new OrderContext())
            {
                var goods = db.Goodses.Where(o => o.Id == id).FirstOrDefault();
                if (goods != null)
                {
                    goods.Type = type;
                    goods.Price = price;
                }
            }
        }

        public static void ModifyCustomer(int id, string name, string addr)
        {
            using (var db = new OrderContext())
            {
                var cus = db.Customers.Where(o => o.Id == id).FirstOrDefault();
                if (cus != null)
                {
                    cus.Name = name;
                    cus.Addr = addr;
                }
            }
        }

        public static IEnumerable<Order> QueryByName(string name)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            where o.Name == name
                            select o;
                return query;
            }

        }

        public static IEnumerable<Order> QueryByOrderTime(DateTime time)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            where o.OrderTime == time
                            select o;
                return query;
            }
        }

        public static IEnumerable<Order> QueryByID(double ID)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            where o.Id == ID
                            select o;
                return query;
            }
        }

        public static IEnumerable<Order> QueryByCertainPrice(QueryFunc_P f)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            where f(o.TotalPrice) == true
                            select o;
                return query;
            }
        }

        public static IEnumerable<Order> QueryByCertainTime(QueryFunc_T f)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            where f(o.OrderTime) == true
                            select o;
                return query;
            }
        }

        public static IEnumerable<Order> OrderByID(IEnumerable<Order> orders)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            orderby o.Id
                            select o;
                return query;
            }
        }

        public static IEnumerable<Order> OrderByTime(IEnumerable<Order> orders)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            orderby o.OrderTime
                            select o;
                return query;
            }
        }

        public static IEnumerable<Order> OrderByPrice(IEnumerable<Order> orders)
        {
            using (var db = new OrderContext())
            {
                var query = from o in db.Orders
                            orderby o.TotalPrice
                            select o;
                return query;
            }
        }

        public static Order GetOrder(double ID)
        {
            using(var db=new OrderContext())
            {
                var ord = db.Orders.Where(o => o.Id == ID).FirstOrDefault();
                if (ord != null)
                    return ord;
                else
                    return null;
            }
        }

        public static void ExportOrders(string path)
        {
            using (var db = new OrderContext()) 
            {
                Order[] orders = db.Orders.ToArray();
                XmlSerializer xs = new XmlSerializer(typeof(Order[]));
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    xs.Serialize(fs, orders);
                } 
            }
        }

        public static void ImportOrders(string path)
        {
            using (var db = new OrderContext())
            {
                XmlSerializer xs = new XmlSerializer(typeof(Order[]));
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    if (fs.Length == 0)
                        throw new NullReferenceException("导入订单为空");
                    Order[] orders = (Order[])xs.Deserialize(fs);
                    orders.ToList<Order>().ForEach(x => db.Orders.Add(x));
                }
                db.SaveChanges();
            }
        }
    }
}
