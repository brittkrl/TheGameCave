using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGameCave.Lib.DTO
{
    public class ProductBasicDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string ProductType { get; set; }
    }
}
