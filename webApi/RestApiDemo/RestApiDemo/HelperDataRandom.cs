using RestApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo
{
  public static class HelperDataRandom
  {
    private static Random _random = new Random();

    public static decimal GetRandomOrderTotal()
    {
      return _random.Next(50, 2000);
    }

    internal static string GetRandom(IList<string> items)
    {
      return items[_random.Next(items.Count)];
    }
    internal static readonly List<string> States = new List<string>()
    {
      "AL",
      "AK",
      "AZ",
      "AR",
      "CA",
      "CO",
      "CT",
      "DE",
      "FL",
      "GA",
      "HI",
      "ID",
      "IL",
      "IN",
      "IA",
      "KS",
      "KY",
      "LA",
      "ME",
      "MD",
      "MA",
      "MI",
      "MN",
      "MS",
      "MO",
      "MT",
      "NE",
      "NV",
      "NH",
      "NJ",
      "NM",
      "NY",
      "NC",
      "ND",
      "OH",
      "OK",
      "OR",
      "PA",
      "RI",
      "SC",
      "SD",
      "TN",
      "TX",
      "UT",
      "VT",
      "VA",
      "WA",
      "WV",
      "WI",
      "WY"
    };
    private static readonly List<string> FirstNames = new List<string>()
  {
    "Maryjo",
"Shaun",
"Maricela",
"Timothy",
"Noma",
"Season",
"Francesco",
"Sharilyn",
"Dorthea",
"Essie",
"Remona",
"Tanner",
"Jamison",
"Jospeh",
"Susan",
"Alexandria",
"Renay",
"Florene",
"Olene",
"Deandrea",
"Gwendolyn",
"Isabelle",
"Crystal",
"Dorla",
"Pamella",
"Celine",
"Ina",
"Neta",
"Tam",
"Jermaine",
"Karisa",
"Dyan",
"Salvatore",
"Mireya",
"Maryanne",
"Lyla",
"Cassi",
"Nereida",
"Thomasena",
"Eartha",
"Kitty",
"Renita",
"Ike",
"Hershel",
"Federico",
"Gertrud",
"Elvis",
"Alessandra",
"Shirlene",
"Tanja",
  };
    private static readonly List<string> ORDER_STATUS = new List<string>
    {
      "Incomplete",
      "Pending",
      "Shipped",
      "Partially Shipped  ",
      "Refunded",
      "Cancelled",
      "Declined",
      "Awaiting Payment",
      "Awaiting Pickup",
      "Awaiting Shipment",
      "Completed",
      "Awaiting Fulfillment",
      "Manual Verification Required",
      "Disputed",
      "Partially Refunded",
    };

    internal static string GetRandomOrderStatus()
    {
      return GetRandom(ORDER_STATUS);
    }

    internal static DateTime? GetRandomClosedDate(DateTime ordered)
    {
      var now = DateTime.Now;
      var minProcessingTime = TimeSpan.FromDays(5);
      var timePassed = now - ordered;
      if (timePassed < minProcessingTime)
      {
        return null;
      }

      return ordered.AddHours(_random.Next(20, 240));
    }

    internal static DateTime GetRandomOrderedDate()
    {
      var end = DateTime.Now.AddDays(-1);
      var start = end.AddDays(-150);
      var deltaTimeSpan = end - start;
      var randomTimeSpan = new TimeSpan(0, _random.Next(0, (int)deltaTimeSpan.TotalMinutes), 0);
      return start + randomTimeSpan;
    }

    private static readonly List<string> LastNames = new List<string>()
    {
      "Summerfield",
      "Auerbach",
      "Woomer",
      "Nevins",
      "Neu",
      "Vance",
      "Folsom",
      "Oberholtzer",
      "Sartin",
      "Kendig",
      "Durrett",
      "Hirth",
      "Hester",
      "Moreira",
      "Bragan",
      "Lacombe",
      "Yule",
      "Wigger ",
      "Vanderford",
      "Kisner",
      "Onan",
      "Quinteros",
      "Royse",
      "Legree",
      "Degroat",
      "Weddell",
      "Bains",
      "Drolet",
      "Cataldo",
      "Casas",
      "Shurtleff",
      "Parkes",
      "Skillern",
      "Scoggin",
      "Hoelscher",
      "Devries",
      "Klar",
      "Threadgill",
      "Addario",
      "Lankford",
      "Schwartz",
      "Rafael",
      "Niven",
      "Lyttle",
      "Boykins",
      "Burgess",
      "Wideman",
      "Bernhardt",
      "Zeiger",
      "Marion"
    };

    internal static string GenerateCustomerName()
    {
      var first = GetRandom(FirstNames);
      var seccond = GetRandom(LastNames);
      return first + " " + seccond;
    }

    internal static string MakeEmail(string name)
    {
      return $"{name.ToLower()}_@mail.com";
    }
    public static Customer GetRandomCustomer(ApplicationDbContext ctx)
    {
      var randomId = _random.Next(1, ctx.Customers.Take(50).Count());
      return ctx.Customers.First(c => c.Id == randomId);
    }
  }
}
