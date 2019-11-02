using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheGameCave.Lib.Models;
using TheGameCave.WebAPI.Repositories;

namespace TheGameCave.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerCrudBase<Category, CategoryRepository>
    {
        public CategoriesController(CategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}