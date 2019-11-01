using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.Models;

namespace TheGameCave.WebAPI.Repositories
{
    public class CategoryRepository
    {
        private TheGameCaveContext _context;

        public CategoryRepository(TheGameCaveContext context)
        {
            _context = context;
        }

        public List<Category> List()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
