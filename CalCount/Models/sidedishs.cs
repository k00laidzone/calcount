using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalCount.Models
{
    public class sidedishs
    {
        [Required]
        public long Id { get; set; }

        [Required(ErrorMessage = "You Must Pick a Name"), Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "You Must Pick State the Calories."), Display(Name = "Calories.")]
        public int calories { get; set; }
    }
}