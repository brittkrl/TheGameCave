using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.Models;

namespace TheGameCave.WebAPI.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(TheGameCaveContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetAllInclusive()
        {
            return await GetAll()
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .ToListAsync();
        }

        public async Task<Product> GetDetailById(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
