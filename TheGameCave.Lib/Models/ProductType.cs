using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheGameCave.Lib.Models
{
    public enum ProductType
    {
        [Display(Name = "Board game")]
        BoardGame,
        [Display(Name = "Card game")]
        CardGame,
    }
}
