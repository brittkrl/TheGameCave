using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.DTO;
using TheGameCave.WebAPI.Models;
using TheGameCave.WebAPI.Repositories.Base;

namespace TheGameCave.WebAPI.Repositories
{
    public class ProductRepository : RepositoryMapping<Product>
    {
        public ProductRepository(TheGameCaveContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<List<Product>> GetAllInclusive()
        {
            return await GetAll()
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .ToListAsync();
        }

        public async Task<List<ProductBasicDto>> ListBasic()
        {
            return await _context.Products
                .ProjectTo<ProductBasicDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ProductDetail> GetDetailById(int id)
        {
            return _mapper.Map<ProductDetail>(
                await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .FirstOrDefaultAsync(b => b.Id == id));
        }
    }
}
