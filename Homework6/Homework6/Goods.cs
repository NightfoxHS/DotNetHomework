using System;

namespace Homework6
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
            return HashCode.Combine(Type, Price);
        }
    }
}
