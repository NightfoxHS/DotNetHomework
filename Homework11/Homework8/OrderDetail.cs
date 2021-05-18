using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Homework8
{
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GoodsId { get; set; }
        [ForeignKey("GoodsId")]
        public Goods Goods { get; set; }
        public int Num { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }

        public long OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public OrderDetail(Order ord,string type,int num,float price)
        {
            Order = ord;
            OrderId = ord.Id;
            Goods = new Goods(type, price);
            GoodsId = Goods.Id;
            Type = Goods.Type;
            Price = Goods.Price;
            Num = num;
        }

        public OrderDetail(Order ord, Goods goods,int num)
        {
            Order = ord;
            OrderId = ord.Id;
            Goods = goods;
            GoodsId = Goods.Id;
            Type = Goods.Type;
            Price = Goods.Price;
            Num = num;
        }

        public OrderDetail()
        {

        }

        public override string ToString()
        {
            return "Type:" + Goods.Type + " Price" + Goods.Price + " Num:" + Num;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
        }

        public override int GetHashCode()
        {
            return -1930756903 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
        }
    }
}
