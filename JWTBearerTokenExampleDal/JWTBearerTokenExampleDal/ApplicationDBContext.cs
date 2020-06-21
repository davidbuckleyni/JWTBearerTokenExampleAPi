using System;
 
using System.Collections.Generic;
using System.Linq;
using JWTBearerTokenExample.Models;
using JWTBearerTokenExampleDal.Classes;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTBearerTokenExampleDal {
    public class ApplicationDBContext : IdentityDbContext<UserInfo> {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options) {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
 

        }

        public DbSet<StockItem> StockItems { get; set; }

     
    }
}
