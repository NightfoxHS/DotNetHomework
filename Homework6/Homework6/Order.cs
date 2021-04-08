using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Order
    {
        public Customer customer;
        private readonly int _ID;
        private readonly List<OrderDetail> orderDetails = new List<OrderDetail>();
        public int ID { get => _ID; }
        public DateTime OrderTime { get; }
        public float TotalPrice { get
            {
                float sum = 0;
                foreach(OrderDetail p in orderDetails)
                {
                    sum += p.goods.Price * p.Num;
                }
                return sum;
            }
        }

        public Order(Customer customer, DateTime orderTime)
        {
                this.customer = customer;
                this.OrderTime = orderTime;
                _ID = GetHashCode()%100000;
        }

        public Order()
        {

        }

        public void Add(Goods good,int num)
        {
            OrderDetail detail = new OrderDetail(good, num);
            if (!orderDetails.Contains(detail))
            {
                orderDetails.Add(detail);
            }
            else
            {
                Console.WriteLine("已有该种货物，请问需要将新的数量添加其上吗？(y/n)");
                bool flag = Console.ReadLine().ToLower() == "y" ? true : false;
                if (flag)
                    orderDetails[orderDetails.IndexOf(detail)].Num += detail.Num;
                else
                    Console.WriteLine("如果想要修改，请使用修改订单明细选项");
            }
        }

        public void Remove(int index)
        {
            try
            {
                if (index < orderDetails.Count && index >= 0)
                {
                    orderDetails.RemoveAt(index);
                }
                else
                    Console.WriteLine("订单明细中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }
        
        public void Modify(int index, int num)
        {
            try
            {
                if (index < orderDetails.Count && index >= 0)
                {
                    orderDetails[index].Num = num;
                }
                else
                    Console.WriteLine("订单明细中无此项。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public void DisplayOrderDetail()
        {
            Console.WriteLine(this);
            foreach (OrderDetail o in orderDetails)
                Console.WriteLine($"[{orderDetails.IndexOf(o)}]{o}");
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Customer>.Default.Equals(customer, order.customer) &&
                   OrderTime == order.OrderTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(customer, OrderTime);
        }

        public override string ToString()
        {
            return "ID:" + ID + " Customer:" + customer.Name + " OrderTime:" + OrderTime + " TotalPrice" + TotalPrice;
        }
    }
}
