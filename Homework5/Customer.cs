using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Customer
    {
        public string Name { get; set; }
        public string Addr { get; set; }

        public Customer(string name,string addr)
        {
            Name = name;
            Addr = addr;
        }

        public override string ToString()
        {
            return "Name:" + Name + " Addr" + Addr;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name &&
                   Addr == customer.Addr;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Addr);
        }
    }
}
