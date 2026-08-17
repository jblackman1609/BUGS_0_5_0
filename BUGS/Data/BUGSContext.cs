using System.Configuration;
using System.IO;
using BUGS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BUGS.Data
{
    public class BUGSContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }
        
        public BUGSContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite($"Data Source=BUGS"));
        }
    }
}