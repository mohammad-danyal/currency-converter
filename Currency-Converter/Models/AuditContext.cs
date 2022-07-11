using currency_converter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Currency_Converter.Models
{
    public class AuditContext : DbContext
    {
        public DbSet<CurrencyModel> Currency { get; set; }
        public DbSet<AuditModel> Audit { get; set; }

        public string DbPath { get; }

        public AuditContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "audit.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }
    }
}