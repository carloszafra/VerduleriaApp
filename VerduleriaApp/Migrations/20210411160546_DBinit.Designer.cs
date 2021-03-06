// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VerduleriaApp.Data.Context;

namespace VerduleriaApp.Migrations
{
    [DbContext(typeof(DBcontext))]
    [Migration("20210411160546_DBinit")]
    partial class DBinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("VerduleriaApp.Data.Models.Concept", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdSale")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Concepts");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdSale");

                    b.ToTable("Concepts");
                });

            modelBuilder.Entity("VerduleriaApp.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Img")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id")
                        .HasName("PK_Products");

                    b.HasIndex("Name")
                        .HasDatabaseName("Idx_Name");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("VerduleriaApp.Data.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id")
                        .HasName("PK_Sales");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("VerduleriaApp.Data.Models.Concept", b =>
                {
                    b.HasOne("VerduleriaApp.Data.Models.Product", "Product")
                        .WithMany("Concepts")
                        .HasForeignKey("IdProduct")
                        .HasConstraintName("FK_Concept_Product")
                        .IsRequired();

                    b.HasOne("VerduleriaApp.Data.Models.Sale", "Sale")
                        .WithMany("Concepts")
                        .HasForeignKey("IdSale")
                        .HasConstraintName("FK_Concept_Sale")
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("VerduleriaApp.Data.Models.Product", b =>
                {
                    b.Navigation("Concepts");
                });

            modelBuilder.Entity("VerduleriaApp.Data.Models.Sale", b =>
                {
                    b.Navigation("Concepts");
                });
#pragma warning restore 612, 618
        }
    }
}
