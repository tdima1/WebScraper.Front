using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebScraper.Models;
using WebScraper.WEB.Models;

namespace WebScraper.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;
      private string actionResult = "";

      private string baseUrl = "http://localhost:5000/api/";

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public IActionResult Index()
      {
         return View();
      }

      public async Task<IActionResult> ListProducts()
      {
         HttpClient client = new HttpClient();
         HttpResponseMessage response = await client.GetAsync(baseUrl + "product");
         string actionResult = await response.Content.ReadAsStringAsync();

         List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(actionResult);

         return View(productList);
      }

      public async Task<IActionResult> Details(int id, string name)
      {
         HttpClient client = new HttpClient();
         HttpResponseMessage response = await client.GetAsync(baseUrl + "product" + $"/{id}");
         string actionResult = await response.Content.ReadAsStringAsync();

         var prices = JsonConvert.DeserializeObject<List<Price>>(actionResult);

         return View(new Product() { Id = id, Name = name, Prices = prices});
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
