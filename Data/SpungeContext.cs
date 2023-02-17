using Microsoft.EntityFrameworkCore;
using Spunges.Models;

namespace Spunges.Data
{
    public class SpungeContext : DbContext
    {
        public SpungeContext(DbContextOptions<SpungeContext> options)
            : base(options)
        {
        }

        public DbSet<Spunge> Spunge{ get; set; }
    }
}