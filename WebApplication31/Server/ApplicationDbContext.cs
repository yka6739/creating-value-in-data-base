using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.Shared.Entities;

namespace WebApplication31.Server
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OnlineProduct>().HasKey(x => new { x.Product_Id });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<OnlineProduct> OlineProduct { get; set; }
    }
}
