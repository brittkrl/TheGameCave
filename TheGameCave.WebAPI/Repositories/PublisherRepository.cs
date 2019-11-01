using Microsoft.EntityFrameworkCore;
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

        public async Task<Publisher> Update(Publisher publisher)
        {
            try
            {
                _context.Entry(publisher).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublisherExists(publisher.Id))
                {
                    return null;
                }

                throw;
            }
            return publisher;
        }

        public async Task<Publisher> Add(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();
            return publisher;
        }

        public async Task<Publisher> Delete(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return null;
            }

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
            return publisher;
        }

        private bool PublisherExists(int id)
        {
            return _context.Publishers.Any(p => p.Id == id);
        }
    }
}
