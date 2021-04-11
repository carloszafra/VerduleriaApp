using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Models;

namespace VerduleriaApp.Data.Context
{
    public class SaleEntityTypeConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");
            builder.HasKey(s => s.Id).HasName("PK_Sales");

            builder.Property(s => s.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        }
    }
}
