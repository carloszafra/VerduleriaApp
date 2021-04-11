using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Models;

namespace VerduleriaApp.Data.Context
{
    public class ConceptEntityTypeConfig : IEntityTypeConfiguration<Concept>
    {
        public void Configure(EntityTypeBuilder<Concept> builder)
        {
            builder.ToTable("Concepts");
            builder.HasKey(c => c.Id).HasName("PK_Concepts");

            builder.Property(c => c.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();

            builder.HasOne(c => c.Product).WithMany(p => p.Concepts)
                .HasForeignKey(c => c.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Concept_Product");

            builder.HasOne(c => c.Sale).WithMany(s => s.Concepts)
                .HasForeignKey(c => c.IdSale)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Concept_Sale");

        }
    }
}
