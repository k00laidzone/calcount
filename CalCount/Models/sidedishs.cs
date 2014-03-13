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
        public string name { get; set; }
        public int calories { get; set; }
    }
}