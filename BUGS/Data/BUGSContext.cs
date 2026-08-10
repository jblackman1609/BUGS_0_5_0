using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BUGS.Data
{
    public class BUGSContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }

        public BUGSContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbPath = Path.Combine(dirPath, "BUGS.db");
            base.OnConfiguring(optionsBuilder.UseSqlite($"Data Source={dbPath}"));
        }
    }
}