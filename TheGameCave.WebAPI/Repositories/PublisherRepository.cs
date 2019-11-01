using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.Models;

namespace TheGameCave.WebAPI.Repositories
{
    public class PublisherRepository
    {
        private TheGameCaveContext _context;

        public PublisherRepository(TheGameCaveContext context)
        {
            _context = context;
        }

        public List<Publisher> List()
        {
            return _context.Publishers.ToList();
        }

        public Publisher GetById(int id)
        {
            return _context.Publishers.Find(id);
        }
    }
}
