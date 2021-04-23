using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    public class OrderDetail
    {
        public Goods goods;
        public int Num { get; set; }
        public string Type { get => goods.Type; }
        public float Price { get => goods.Price; }

        public OrderDetail(string type,int num,float price)
        {
            try
            {
                goods = new Goods(type, price);
                Num = num;
            }
            catch(Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public OrderDetail(Goods goods,int num)
        {
            try
            {
                this.goods = goods;
                Num = num;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }

        public override string ToString()
        {
            return "Type:" + goods.Type + " Price" + goods.Price + " Num:" + Num;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   EqualityComparer<Goods>.Default.Equals(goods, detail.goods);
        }

        public override int GetHashCode()
        {
            return -1930756903 + EqualityComparer<Goods>.Default.GetHashCode(goods);
        }
    }
}
