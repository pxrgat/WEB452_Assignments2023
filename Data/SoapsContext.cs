using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soaps.Models;

namespace Soaps.Data
{
    public class SoapsContext : DbContext
    {
        public SoapsContext (DbContextOptions<SoapsContext> options)
            : base(options)
        {
        }

        public DbSet<Soaps.Models.Soap> Soap { get; set; }
    }
}
