using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        // This is our constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        // DbSet types
        public DbSet<Value> Values { get; set; }
        
    }
}