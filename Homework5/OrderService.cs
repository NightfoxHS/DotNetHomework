using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5
{
    enum Operation { Add, Remove, Modify }
    delegate bool QueryFunc_P(float x);
    delegate bool QueryFunc_T(DateTime t);

    class OrderService
    {
        private readonly List<Order> orders = new List<Order>();
        private readonly List<Customer> customers = new List<Customer>();
        private readonly List<Goods> goodses = new List<Goods>();

        public OrderService()
        {

        }

        public void CreateCustomer(string name, string addr)
        {
            try
            {
                Customer customer = new Customer(name, addr);
                if (!customers.Contains(customer))
                {
                    customers.Add(customer);
                }
                else
                    Console.WriteLine("已存在该用户");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void CreateGoods(string type, float price)
        {
            try
            {
                Goods goods = new Goods(type, price);
                if (!goodses.Contains(goods))
                {
                    goodses.Add(goods);
                }
                else
                    Console.WriteLine("已存在该货物");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void CreateOrder(Customer customer)
        {
            try
            {
                Order order = new Order(customer, DateTime.Now);
                if (!orders.Contains(order))
                {
                    orders.Add(order);
                }
                else
                    Console.WriteLine("已存在该订单");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void RemoveCustomer(int index)
        {
            try
            {
                if (index < customers.Count && index >= 0)
                {
                    customers.RemoveAt(index);
                }
                else
                    Console.WriteLine("客户中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void RemoveGoods(int index)
        {
            try
            {
                if (index < goodses.Count && index >= 0)
                {
                    goodses.RemoveAt(index);
                }
                else
                    Console.WriteLine("货物中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void RemoveOrder(int index)
        {
            try
            {
                if (index < orders.Count && index >= 0)
                {
                    orders.RemoveAt(index);
                }
                else
                    Console.WriteLine("订单中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void ModifyGoods(int index, string type, float price)
        {
            try
            {
                if (index < goodses.Count && index >= 0)
                {
                    goodses[index].Type = type;
                    goodses[index].Price = price;
                }
                else
                    Console.WriteLine("货物中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void ModifyCustomer(int index, string name, string addr)
        {
            try
            {
                if (index < customers.Count && index >= 0)
                {
                    customers[index].Name = name;
                    customers[index].Addr = addr;
                }
                else
                    Console.WriteLine("用户中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
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
            try
            {
                if (index < orders.Count && index >= 0)
                {
                    Console.WriteLine(orders[index]);
                    orders[index].DisplayOrderDetail();
                }
                else
                    Console.WriteLine("订单中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void DisplayOrders(IEnumerable<Order> orders)
        {
            try
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
                    Console.WriteLine("无此查询结果！");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
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
    }
}
