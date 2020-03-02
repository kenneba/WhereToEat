using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhereToEat.Models;

namespace WhereToEat.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet <User> Users{get; set;}
        public DbSet <Restaurants> Restaurants {get;set;}
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
    {
    }
    }

}
