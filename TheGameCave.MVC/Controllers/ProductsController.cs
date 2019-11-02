using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TheGameCave.Lib.DTO;

namespace TheGameCave.MVC.Controllers
{
    public class ProductsController : Controller
    {
        string baseuri = "https://localhost:5001/api/products"; 
        public IActionResult Index() 
        { 
            string uri = $"{baseuri}/basic"; 
            return View(GetApiResult<List<ProductBasicDto>>(uri)); 
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