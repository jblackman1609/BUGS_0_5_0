using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BUGS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BUGS.Data
{
    public class BUGSContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Purchaser> Purchasers { get; set; }
        //private readonly IConfiguration _config;

        public BUGSContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BUGS2.db");            
            base.OnConfiguring(optionsBuilder.UseSqlite($"Data Source={dbPath}"));
        }
    }
}