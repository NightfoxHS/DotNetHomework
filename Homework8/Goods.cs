using System;
using System.Collections.Generic;

namespace Homework8
{
    public class Goods
    {
        public string Type { get; set; }
        public float Price { get; set; }

        public Goods(string type,float price)
        {
            Type = type;
            Price = price;
        }
        public override string ToString()
        {
            return "Type:" + Type + " Price:" + Price;
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   Type == goods.Type &&
                   Price == goods.Price;
        }

        public override int GetHashCode()
        {
            int hashCode = 1466063423;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
