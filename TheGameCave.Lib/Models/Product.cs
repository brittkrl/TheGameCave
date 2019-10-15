using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheGameCave.Lib.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        [MaxLength(250)]
        public string PhotoUrl { get; set; }

        [Display(Name = "Type")]
        public ProductType ProductType { get; set; }

        [Display(Name = "Playing time")]
        public string PlayingTime { get; set; }

        [Display(Name = "# of players")]
        public string NumberOfPlayers { get; set; }

        [Display(Name = "Minimum age")]
        public int MinimumAge { get; set; }

        public Language Language { get; set; }

        [ForeignKey(nameof(Category))]
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Publisher))]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
