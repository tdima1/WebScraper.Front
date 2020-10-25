using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebScraper.WEB.Models
{
   public class Product
   {
      public Product()
      {
         Prices = new List<Price>();
      }

      public int Id { get; set; }
      public string Name { get; set; }
      public List<Price> Prices { get; set; }
   }
}
