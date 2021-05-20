using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace OrderWeb.Models
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
    }
}