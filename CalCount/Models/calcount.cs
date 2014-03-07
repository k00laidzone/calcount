using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CalCount.Models
{
    public class calcount
    {
        [Required]
        public long Id { get; set; }

        [Required(ErrorMessage = "You Must Pick a Class."), Display(Name="Choose The Category.")]
        public string category { get; set; }

        [Required, StringLength(50), Display(Name="Your Name"), DataType(DataType.Text)]
        public string Name{ get; set; }
        [Required, DataType(DataType.Text)]
        public string Desc { get; set; }
        [Required, DataType(DataType.Text)]
        public int CaloriesCount { get; set; }

    }
}