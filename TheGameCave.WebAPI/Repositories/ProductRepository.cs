using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.Models;

namespace TheGameCave.WebAPI.Repositories
{
    public class ProductRepository
    {
        private TheGameCaveContext _context;

        public ProductRepository(TheGameCaveContext context)
        {
            _context = context;
        }

        public List<Product> List()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }
    }
}
