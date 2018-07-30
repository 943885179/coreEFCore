using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class DB : DbContext
    {
        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder
             .UseSqlServer(@"Server=WEIXIAO\WEIXIAOSERVER;database=migrationtest;User ID=sa;Password=123456;Trusted_Connection=false;");
    }

}