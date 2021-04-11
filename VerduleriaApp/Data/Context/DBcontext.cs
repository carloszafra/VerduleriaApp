using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Models;

namespace VerduleriaApp.Data.Context
{
    public class DBcontext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Concept> Concept { get; set; }

        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {

        }

        public DBcontext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBcontext).Assembly);
        }
    }
}
