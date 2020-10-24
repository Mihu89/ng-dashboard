using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Models
{
  public class DataSeed
  {
    private readonly ApplicationDbContext _ctx;

    public DataSeed(ApplicationDbContext context)
    {
      _ctx = context;
    }
    private static List<string> USA_States = HelperDataRandom.States;

    public void SeedData(int nrCustomers, int nrOrders)
    {
      if (!_ctx.Customers.Any())
      {
        SeedCustomers(nrCustomers);
        _ctx.SaveChanges();
      }

      if (!_ctx.Orders.Any())
      {
        SeedOrders(nrOrders);
        _ctx.SaveChanges();
      }

      if (!_ctx.Servers.Any())
      {
        SeedServers();
        _ctx.SaveChanges();
      }

    }

    private void SeedServers()
    {
      throw new NotImplementedException();
    }

    private void SeedOrders(int nrOrders)
    {
      var orders = BuildOrders(nrOrders);
      foreach (var order in orders)
      {
        _ctx.Orders.Add(order);
      }
    }

    private List<Order> BuildOrders(int nrOrders)
    {
      var orders = new List<Order>();

      for (int i = 1; i < nrOrders + 1; i++)
      {
        var orderedDate = HelperDataRandom.GetRandomOrderedDate();
        orders.Add(new Order
        {
          Id = i,
          Customer = HelperDataRandom.GetRandomCustomer(_ctx),
          Total = HelperDataRandom.GetRandomOrderTotal(),
          Ordered = orderedDate,
          Closed = HelperDataRandom.GetRandomClosedDate(orderedDate),
          Status = HelperDataRandom.GetRandomOrderStatus()
        });
      }
      return orders;
    }

    private void SeedCustomers(int nrCustomers)
    {
      var customers = BuildCustomers(nrCustomers);
      foreach (var customer in customers)
      {
        _ctx.Customers.Add(customer);
      }
    }

    private List<Customer> BuildCustomers(int nrCustomers)
    {
      var customers = new List<Customer>();
      for (int i = 1; i < nrCustomers +1; i++)
      {
        var name = HelperDataRandom.GenerateCustomerName();
        customers.Add(new Customer
        {
          Id = i,
          Name = name,
          Email = HelperDataRandom.MakeEmail(name.Replace(' ', '_')),
          State = HelperDataRandom.GetRandom(USA_States)
        });
      }

      return customers;

    }
  }
}
