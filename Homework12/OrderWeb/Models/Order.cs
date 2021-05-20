using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace OrderWeb.Models
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
        public string Name { get=>(Customer!=null)?Customer.Name:"";}

        /*
         * public float TotalPrice
        {
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
                            sum += db.Goodses.Where(g => g.Id == p.GoodsId).FirstOrDefault().Price * p.Num;
                        }
                    }
                }
                return sum;
            }
        }
        */
    }
}