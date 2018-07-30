using Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkCore
{
    public class EFDbContext:DbContext
    {//add-migration init
        //update-database init
        public DbSet<User> Customers { get; set; }
        private const string DbConnectionString = "Host=WEIXIAO\\WEIXIAOSERVER;Port=5432;Database=eflab;Username=sa;Password=12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WEIXIAO\WEIXIAOSERVER;database=migrationtest;User ID=sa;Password=123456;Trusted_Connection=false;");
            //optionsBuilder.UseNpgsql(DbConnectionString);
        }
    }
}
