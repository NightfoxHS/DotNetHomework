using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Homework6
{
    enum Operation { Add, Remove, Modify }
    public delegate bool QueryFunc_P(float x);
    public delegate bool QueryFunc_T(DateTime t);

    public class OrderService
    {
        private readonly List<Order> orders = new List<Order>();
        private readonly List<Customer> customers = new List<Customer>();
        private readonly List<Goods> goodses = new List<Goods>();

        public OrderService()
        {

        }

        public void CreateCustomer(string name, string addr)
        {
            if (name.All(x=>x==' '))
                throw new ArgumentNullException("名字为空");
            Customer customer = new Customer(name, addr);
            if (!customers.Contains(customer))
            {
                customers.Add(customer);
            }
            else
                throw new ApplicationException("用户已存在");
        }

        public void CreateGoods(string type, float price)
        {
            if (type.All(x => x == ' '))
                throw new ArgumentNullException("货物类型为空");
            if (price <= 0)
                throw new ArgumentOutOfRangeException("价格不能为0或负数");
            Goods goods = new Goods(type, price);
            if (!goodses.Contains(goods))
            {
                goodses.Add(goods);
            }
            else
                throw new ApplicationException("已存在该货物");
        }

        public void CreateOrder(Customer customer)
        {
            Order order = new Order(customer, DateTime.Now);
            if (!orders.Contains(order))
            {
                orders.Add(order);
            }
            else
                throw new ApplicationException("已存在该订单");
        }

        public void RemoveCustomer(int index)
        {
            if (index < customers.Count && index >= 0)
            {
                customers.RemoveAt(index);
            }
            else
                throw new ArgumentOutOfRangeException("客户中无此项。");
        }

        public void RemoveGoods(int index)
        {
            if (index < goodses.Count && index >= 0)
            {
                goodses.RemoveAt(index);
            }
            else
                throw new ArgumentOutOfRangeException("货物中无此项。");
        }

        public void RemoveOrder(int index)
        {
            if (index < orders.Count && index >= 0)
            {
                orders.RemoveAt(index);
            }
            else
                throw new ArgumentOutOfRangeException("订单中无此项。");
        }

        public void ModifyGoods(int index, string type, float price)
        {
            if (price <= 0)
                throw new ArgumentOutOfRangeException("价格不能为0或负数");
            if (index < goodses.Count && index >= 0)
            {
                goodses[index].Type = type;
                goodses[index].Price = price;
            }
            else
                throw new ArgumentOutOfRangeException("货物中无此项。");
        }

        public void ModifyCustomer(int index, string name, string addr)
        {
            if (name.All(x => x == ' '))
                throw new ArgumentNullException("名字为空");
            if (index < customers.Count && index >= 0)
            {
                customers[index].Name = name;
                customers[index].Addr = addr;
            }
            else
                throw new ArgumentOutOfRangeException("用户中无此项。");
        }

        public void DisplayCustomers()
        {
            foreach (Customer c in customers)
                Console.WriteLine($"[{customers.IndexOf(c)}]{c}");
        }

        public void DisplayGoodses()
        {
            foreach (Goods g in goodses)
                Console.WriteLine($"[{goodses.IndexOf(g)}]{g}");
        }

        public void DisplayOrders()
        {
            foreach (Order o in orders)
                Console.WriteLine($"[{orders.IndexOf(o)}]{o}");
        }

        public void DisplayDetailOfOrder(int index)
        {
            if (index < orders.Count && index >= 0)
            {
                Console.WriteLine(orders[index]);
                orders[index].DisplayOrderDetail();
            }
            else
                throw new IndexOutOfRangeException("订单中无此项。");
        }

        public void DisplayOrders(IEnumerable<Order> orders)
        {
            if (orders != null)
            {
                foreach (Order o in orders)
                {
                    Console.WriteLine(o);
                    o.DisplayOrderDetail();
                }
            }
            else
                throw new ApplicationException("无此查询结果！");
        }

        public IEnumerable<Order> QueryByName(string name)
        {

            var query = from o in orders
                        where o.customer.Name == name
                        select o;
            return query;

        }

        public IEnumerable<Order> QueryByOrderTime(DateTime time)
        {
            var query = from o in orders
                        where o.OrderTime == time
                        select o;
            return query;
        }

        public IEnumerable<Order> QueryByID(int ID)
        {
            var query = from o in orders
                        where o.ID == ID
                        select o;
            return query;
        }

        public IEnumerable<Order> QueryByCertainPrice(QueryFunc_P f)
        {
            var query = from o in orders
                        where f(o.TotalPrice) == true
                        select o;
            return query;
        }

        public IEnumerable<Order> QueryByCertainTime(QueryFunc_T f)
        {
            var query = from o in orders
                        where f(o.OrderTime) == true
                        select o;
            return query;
        }

        public IEnumerable<Order> OrderByID(IEnumerable<Order> orders)
        {
            var query = from o in orders
                        orderby o.ID
                        select o;
            return query;
        }

        public IEnumerable<Order> OrderByTime(IEnumerable<Order> orders)
        {
            var query = from o in orders
                        orderby o.OrderTime
                        select o;
            return query;
        }

        public IEnumerable<Order> OrderByPrice(IEnumerable<Order> orders)
        {
            var query = from o in orders
                        orderby o.TotalPrice
                        select o;
            return query;
        }

        public Customer GetCustomer(int i)
        {
            if (i < customers.Count && i >= 0)
            {
                return customers[i];
            }
            else
                return null;
        }

        public Order GetOrder(int i)
        {
            if (i < orders.Count && i >= 0)
            {
                return orders[i];
            }
            else
                return null;
        }

        public Goods GetGoods(int i)
        {
            if (i < goodses.Count && i >= 0)
            {
                return goodses[i];
            }
            else
                return null;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public void ExportOrders(string path)
        {
            Order[] orders = this.orders.ToArray();
            XmlSerializer xs = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xs.Serialize(fs, orders);
            }
        }

        public void ImportOrders(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                    throw new NullReferenceException("导入订单为空");
                Order[] orders = (Order[])xs.Deserialize(fs);
            }
            orders.ToList<Order>().ForEach(x => this.orders.Add(x));
        }
    }
}
