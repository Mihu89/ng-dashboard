using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo
{
  public class PaginatedResponse<T>
  {
    public int Total { get; set; }
    public IEnumerable<T> Data { get; set; }

    public PaginatedResponse(IEnumerable<T> data, int pageIndex, int pageSize)
    {
      Data = data.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
      Total = data.Count();
    }
  }
}
