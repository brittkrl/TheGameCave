using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.Lib.Models;

namespace TheGameCave.WebAPI.Data
{
    public class TheGameCaveContext : DbContext
    {
        public TheGameCaveContext(DbContextOptions<TheGameCaveContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
