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
        //public DbSet<Purchaser> Purchasers { get; set; }
        private readonly IConfiguration? _config;

        public BUGSContext(IConfiguration config) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string connectionString = 
            Path.Combine(_config!.GetConnectionString("Default")!, dbPath, _config!.GetConnectionString("BUGS")!);

            base.OnConfiguring(optionsBuilder.UseSqlite(connectionString));
        }
    }
}