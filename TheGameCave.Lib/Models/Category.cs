using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameCave.Lib.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
