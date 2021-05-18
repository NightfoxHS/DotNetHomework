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
        public long Id { get; set; }

        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string Name { get; set; }

        public float TotalPrice { 
            get
            {
                float sum = 0;
                using (var db = new OrderContext())
                {
                    var details = db.OrderDetails.Where(d => d.OrderId == Id).ToList();
                    if (details != null)
                    {
                        foreach (OrderDetail p in details)
                        {
                            sum += db.Goodses.Where(g=>g.Id==p.GoodsId).FirstOrDefault().Price * p.Num;
                        }
                    }
                }
                return sum;
            }
        }
        
        public Order(Customer customer, DateTime orderTime)
        {
            this.Customer = customer;
            this.CustomerId = customer.Id;
            this.Name = customer.Name;
            this.OrderTime = orderTime;
        }

        public Order()
        {

        }

        public void Add(Goods goods,int num)
        {
            using (var db = new OrderContext())
            {
                OrderDetail detail = new OrderDetail(this, goods, num);
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
                var detail = db.OrderDetails.Where(o => o.Id == id).FirstOrDefault();
                db.OrderDetails.Remove(detail);
                db.SaveChanges();
            }
        }
        
        public void Modify(int id, int num)
        {
           using(var db= new OrderContext())
            {
                var detail = db.OrderDetails.Where(o => o.Id == id).FirstOrDefault();
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
