using Microsoft.EntityFrameworkCore;
using FirstApp.API.Models;
namespace FirstApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> values { get; set; }
    }
}