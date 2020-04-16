using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        
        public DbSet<Restaurant> Restaurants { get; set; } //migrations entity framework feature

        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options) //OdeToFoodContext now can take connectionsoptions and provider options
            :base(options)//DbContext constructor
        {
            
        }
    }
}
