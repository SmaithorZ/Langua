using Langua.Models;
using Microsoft.EntityFrameworkCore;

namespace Langua.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       public DbSet<Text> Texts { get; set; }
    }
}
