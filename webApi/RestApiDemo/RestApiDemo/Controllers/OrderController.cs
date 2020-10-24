using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestApiDemo.Models;

namespace RestApiDemo.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class OrderController : ControllerBase
  {
    private readonly ApplicationDbContext _context;

    private readonly ILogger<WeatherForecastController> _logger;

    public OrderController(ILogger<WeatherForecastController> logger, ApplicationDbContext ctx)
    {
      _logger = logger;
      _context = ctx;
    }

    [HttpGet("{pageIndex:int}/{pageSize:int}")]
    public IActionResult GetOrders(int pageIndex, int pageSize)
    {
      var data = _context.Orders.Include(x => x.Customer).OrderByDescending(x => x.Ordered);
      var page = new PaginatedResponse<Order>(data, pageIndex, pageSize);
      var totalPages = Math.Ceiling((double)data.Count() / pageSize);
      var response = new
      {
        Page = page,
        TotalPages = totalPages
      };
      return Ok(response);
    }

    [HttpGet("byCustomer/{id}")]
    public IActionResult ByCustomer(int id)
    {
      var orders = _context.Orders.Include(x => x.Customer)
       .Where(x => x.Customer.Id == id).ToList();
      return Ok(orders);
    }

    [HttpGet("getOrder/{id}")]
    public Order GetOrder(int id)
    {
      return _context.Orders.Include(x => x.Customer).FirstOrDefault(o => o.Id == id);
    }

    [HttpPost]
    public IActionResult Save([FromBody] Order order)
    {
      if (order == null)
      {
        return BadRequest();
      }

      _context.Orders.Add(order);
      _context.SaveChanges();
      return CreatedAtRoute("GetOrder", new { id = order.Id }, order);
    }

    [HttpPut]
    public IActionResult Edit(int id, [FromBody] Order order)
    {
      if (order == null || id != order.Id)
      {
        return BadRequest();
      }

      var existingOrder = _context.Orders.FirstOrDefault(x => x.Id == id);

      if (existingOrder == null)
      {
        return NotFound();
      }
      existingOrder.Customer = order.Customer;
      existingOrder.Total = order.Total;
      existingOrder.Ordered = order.Ordered;
      existingOrder.Closed = order.Closed;

      _context.SaveChanges();
      return new NoContentResult();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var existingOrder = _context.Orders.FirstOrDefault(x => x.Id == id);
      if (existingOrder == null)
      {
        return NotFound();
      }
      _context.Orders.Remove(existingOrder);
      _context.SaveChanges();
      return new NoContentResult();
    }
  }
}
