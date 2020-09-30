using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebScraper.Models;

namespace WebScraper.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;
      private string actionResult = "";

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public async Task<IActionResult> Index()
      {
         //await GetStuff();
         return View();
      }

      private static async Task GetStuff()
      {
         HttpClient client = new HttpClient();
         HttpResponseMessage response = await client.GetAsync("https://localhost:44358/weatherforecast");

         string actionResult = await response.Content.ReadAsStringAsync();
      }

      public IActionResult Privacy()
      {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
