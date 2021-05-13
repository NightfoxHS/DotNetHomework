using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Goods> Goodses { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
