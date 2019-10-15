using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameCave.Lib.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
