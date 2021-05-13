using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Homework8
{
    public class Order
    {
        
        
        [Key]
        public double Id { get; set; }

        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string Name { get; set; }

        public float TotalPrice { get
            {
                float sum = 0;
                if (OrderDetails != null)
                {
                    foreach (OrderDetail p in OrderDetails)
                    {
                        sum += p.goods.Price * p.Num;
                    }
                }
                return sum;
            }
        }
        
        public Order(Customer customer, DateTime orderTime)
        {
            this.Customer = customer;
            this.CustomerId = customer.Id;
            this.OrderTime = orderTime;
            Id = Convert.ToDouble(orderTime.ToString("yyyyMMddHHmmss") + (customer.GetHashCode() % 10000).ToString());
        }

        public Order()
        {

        }

        public void Add(Goods good,int num)
        {
            using (var db = new OrderContext())
            {
                OrderDetail detail = new OrderDetail(good, num);
                detail.OrderId = this.Id;
                detail.Order = this;
                db.OrderDetails.Add(detail);
                db.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using(var db = new OrderContext())
            {
                var detail = db.OrderDetails.Where(o => o.OrderDetailId == id).FirstOrDefault();
                db.OrderDetails.Remove(detail);
                db.SaveChanges();
            }
        }
        
        public void Modify(int id, int num)
        {
           using(var db= new OrderContext())
            {
                var detail = db.OrderDetails.Where(o => o.OrderDetailId == id).FirstOrDefault();
                if (detail != null)
                {
                    detail.Num = num;
                    db.SaveChanges();
                }
            }
        }

        public override string ToString()
        {
            return "ID:" + Id + " Customer:" + Customer.Name + " OrderTime:" + OrderTime + " TotalPrice" + TotalPrice;
        }

    }
}
