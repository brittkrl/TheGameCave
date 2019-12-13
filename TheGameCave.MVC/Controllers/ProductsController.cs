using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TheGameCave.Lib.DTO;
using TheGameCave.Lib.Models;
using TheGameCave.MVC.ViewModels;

namespace TheGameCave.MVC.Controllers
{
    public class ProductsController : Controller
    {
        string baseUri = "https://localhost:5001/api/products";
        public IActionResult Index()
        {
            string productUri = $"{baseUri}/basic";

            return View(GetApiResult<List<ProductBasicDto>>(productUri));
        }

        public IActionResult Detail(int id)
        {
            string productUri = $"{baseUri}/detail/{id}";
            return View(new ProductDetailViewModel
            {
                ProductDetail = GetApiResult<ProductDetail>(productUri)
            });
        }

        public IActionResult BoardGames()
        {
            string productUri = $"{baseUri}/basic";

            return View(GetApiResult<List<ProductBasicDto>>(productUri));
        }

        public IActionResult CardGames()
        {
            string productUri = $"{baseUri}/basic";

            return View(GetApiResult<List<ProductBasicDto>>(productUri));
        }

        public IActionResult DiceGames()
        {
            string productUri = $"{baseUri}/basic";

            return View(GetApiResult<List<ProductBasicDto>>(productUri));
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