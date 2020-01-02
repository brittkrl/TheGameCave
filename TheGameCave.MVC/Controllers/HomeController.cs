using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TheGameCave.Lib.DTO;
using TheGameCave.MVC.Models;

namespace TheGameCave.MVC.Controllers
{
    public class HomeController : Controller
    {
        string baseUri = "https://localhost:5001/api/products";

        public IActionResult Index()
        {
            string productUri = $"{baseUri}/basic";

            return View(GetApiResult<List<ProductBasicDto>>(productUri));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Sale")]
        public IActionResult Sale()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private T GetApiResult<T>(string uri)
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(uri);
                return Task.Factory.StartNew(
                    () => JsonConvert.DeserializeObject<T>(response.Result)
                    ).Result;
            }
        }
    }
}
