using BookServiceWEBAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookServiceWEBAPI.Database
{
    public class MyContext : DbContext //inheriting dbcontext
    {
        private object config;

        public DbSet<Book>? Books { get; set; }


        //configure connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config["ConnectionString"]);
            base.OnConfiguring(optionsBuilder);
        }
    }
}