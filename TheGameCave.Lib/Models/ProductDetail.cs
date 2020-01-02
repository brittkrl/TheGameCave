using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheGameCave.Lib.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PhotoUrl { get; set; }

        [Display(Name = "Type")]
        public string ProductType { get; set; }

        [Display(Name = "Playing time")]
        public string PlayingTime { get; set; }

        [Display(Name = "# of players")]
        public string NumberOfPlayers { get; set; }

        [Display(Name = "Minimum age")]
        public int MinimumAge { get; set; }
        public string Language { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public bool OnSale { get; set; }
    }
}
