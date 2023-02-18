using Microsoft.EntityFrameworkCore;
using Soaps.Models;

namespace Soaps.Data
{
    public class SoapContext : DbContext
    {
        public SoapContext(DbContextOptions<SoapContext> options)
            : base(options)
        {
        }

        public DbSet<Soap> Soap { get; set; }
    }
}