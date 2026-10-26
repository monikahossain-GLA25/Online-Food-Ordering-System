using Online_Food_Ordering_System.Models;


using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Online_Food_Ordering_System.Data
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Food> foods => Set<Food>();
        public DbSet<Order> orders => Set<Order>();
    }
}
