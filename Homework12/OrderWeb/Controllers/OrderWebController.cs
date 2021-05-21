using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderWeb.Models;

namespace OrderWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderWebController : ControllerBase
    {
        private readonly OrderContext OrdDB;
        public OrderWebController(OrderContext context)
        {
            OrdDB = context;
        }

        // GET: api/order/{id}
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(string Id)
        {
            var order = OrdDB.Orders.FirstOrDefault(o => o.Id == Convert.ToInt64(Id));
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // GET: api/order/query?customerName={name}
        [HttpGet("query")]
        public ActionResult<List<Order>> GetOrders(string customerName)
        {
            var res = OrdDB.Orders.Include("Customer").Where(o => true);
            if (res != null)
            {
                var query = res.Where(o => o.Name == customerName);
                if (query != null)
                    return query.ToList();
                else
                    return NotFound();
            }
            else
                return NotFound();
        }

        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                OrdDB.Orders.Add(order);
                OrdDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(string id, Order order)
        {
            if (Convert.ToInt64(id) != order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrdDB.Entry(order).State = EntityState.Modified;
                OrdDB.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string id)
        {
            try
            {
                var order = OrdDB.Orders.FirstOrDefault(o => o.Id == Convert.ToInt64(id));
                if (order != null)
                {
                    OrdDB.Remove(order);
                    OrdDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }


    }
}