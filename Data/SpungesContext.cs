using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spunges.Models;

namespace Spunges.Data
{
    public class SpungesContext : DbContext
    {
        public SpungesContext (DbContextOptions<SpungesContext> options)
            : base(options)
        {
        }

        public DbSet<Spunges.Models.Spunge> Spunge { get; set; }
    }
}
