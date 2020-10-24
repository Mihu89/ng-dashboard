using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Models
{
  public class Order
  {
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public decimal Total { get; set; }
    public DateTime? Ordered { get; set; }
    public DateTime? Closed { get; set; }
    public string Status { get; set; }
  }
}
