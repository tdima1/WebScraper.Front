using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebScraper.WEB.Models
{
   public class Price
   {
      public int PriceId { get; set; }
      public int OldPrice { get; set; }
      public int NewPrice { get; set; }
      public int ProductId { get; set; }
      public DateTime Date { get; set; }
      public int PriceDifferenceInValue { get; set; }
      public double PriceDifferenceInPercentage { get; set; }
   }
}
