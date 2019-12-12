using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheGameCave.Lib.Models;
using TheGameCave.WebAPI.Repositories;

namespace TheGameCave.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerCrudBase<Product, ProductRepository>
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public ProductsController(ProductRepository productRepository, IHostingEnvironment hostingEnvironment) : base(productRepository)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return Ok(await repository.GetAllInclusive());
        }

        [HttpGet]
        [Route("Detail/{id}")]
        public async Task<IActionResult> GetProductDetail(int id)
        {
            return Ok(await repository.GetDetailById(id));
        }

        [HttpGet]
        [Route("Basic")]
        public async Task<IActionResult> GetProductsBasic()
        {
            return Ok(await repository.ListBasic());
        }

        [HttpGet]
        [Route("GameImageByName/{filename}")]
        public IActionResult GetGameImageByFileName(string filename)
        {
            var pathOfImage = Path.Combine(_hostingEnvironment.WebRootPath, "images", filename);
            return PhysicalFile(pathOfImage, "image/jpeg");
        }

        [HttpGet]
        [Route("ImageByName/{filename}")]
        public IActionResult GetImageByFileName(string filename)
        {
            var pathOfImage = Path.Combine(_hostingEnvironment.WebRootPath, "images/icons", filename);
            return PhysicalFile(pathOfImage, "image/png");
        }

        [HttpPost]
        [Route("Image")]
        public async Task<IActionResult> Image(IFormFile formFile)
        {
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", formFile.FileName);

            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }

            return Ok(new { count = 1, formFile.Length });

        }
    }
}