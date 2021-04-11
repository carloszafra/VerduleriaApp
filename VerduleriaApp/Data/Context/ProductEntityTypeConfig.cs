using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Models;

namespace VerduleriaApp.Data.Context
{
    public class ProductEntityTypeConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id).HasName("PK_Products");

            builder.HasIndex(t => t.Name).HasDatabaseName("Idx_Name");

            builder.Property(t => t.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            builder.Property(t => t.Description).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.Type).IsRequired();

            builder.HasData(
                new Product 
                { 
                    Id = 1,
                    Name = "Tomates",
                    Description = "Tomates Frescos",
                    Type = "fruta",
                    Img = "https://images.app.goo.gl/2eWj98yqJfpHnH5B7",
                    Price = 100,
                    Stock = 200,
                },
                new Product
                {
                    Id = 2,
                    Name = "Fresas",
                    Description = "Fresas ideales para batidos y ensaladas de frutas",
                    Type = "fruta",
                    Img = "https://images.app.goo.gl/jmrrXLpTCAeRpDCNA",
                    Price = 150,
                    Stock = 250,
                },
                new Product
                {
                    Id = 3,
                    Name = "Naranjas",
                    Description = "Ideales para jugos",
                    Type = "fruta",
                    Img = "https://images.app.goo.gl/XwLsj8CW3nyMEQNM9",
                    Price = 90,
                    Stock = 300,
                },
                new Product
                {
                    Id = 4,
                    Name = "Cebollas",
                    Description = "Buenas para ensaladas",
                    Type = "vegetal",
                    Img = "https://images.app.goo.gl/QxwFnaTZqapADkdE7",
                    Price = 100,
                    Stock = 200,
                },
                new Product
                {
                    Id = 5,
                    Name = "Lechuga",
                    Description = "Frescas recien traidas del campo",
                    Type = "vegetal",
                    Img = "https://images.app.goo.gl/9ZuU2n4K1treJwU98",
                    Price = 100,
                    Stock = 200,
                }
              );
                
        }
    }
}
