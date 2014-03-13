using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CalCount.Models
{
    public class CaloriesDataContext : DbContext
    {
        public DbSet<calcount> Meals {get; set;}
        public DbSet<sidedishs> Sides { get; set; }
    }
}