﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wasteInventoryManagementSystem.Data;

#nullable disable

namespace wasteInventoryManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20240327184346_AddAllTableToDBContext")]
    partial class AddAllTableToDBContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteBuying", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeightAndPriceId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("WeightAndPriceId");

                    b.ToTable("wasteBuyings");
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteDonation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeightAndPriceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WeightAndPriceId");

                    b.ToTable("wasteDonations");
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteSelling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeightAndPriceId")
                        .HasColumnType("int");

                    b.Property<string>("WholesaleCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WholesaleContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("WeightAndPriceId");

                    b.ToTable("wasteSellings");
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WeightAndPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AluminumCansPrice")
                        .HasColumnType("float");

                    b.Property<double>("AluminumCansWeight")
                        .HasColumnType("float");

                    b.Property<double>("CardboardPrice")
                        .HasColumnType("float");

                    b.Property<double>("CardboardWeight")
                        .HasColumnType("float");

                    b.Property<double>("GlassBottlesPrice")
                        .HasColumnType("float");

                    b.Property<double>("GlassBottlesWeight")
                        .HasColumnType("float");

                    b.Property<double>("MetalsPrice")
                        .HasColumnType("float");

                    b.Property<double>("MetalsWeight")
                        .HasColumnType("float");

                    b.Property<double>("PlasticPrice")
                        .HasColumnType("float");

                    b.Property<double>("PlasticWeight")
                        .HasColumnType("float");

                    b.Property<double>("TotalSalePrice")
                        .HasColumnType("float");

                    b.Property<double>("Totalweight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WeightAndPrice");
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteBuying", b =>
                {
                    b.HasOne("wasteInventoryManagementSystem.Models.WeightAndPrice", "WeightAndPrice")
                        .WithMany()
                        .HasForeignKey("WeightAndPriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeightAndPrice");
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteDonation", b =>
                {
                    b.HasOne("wasteInventoryManagementSystem.Models.WeightAndPrice", "WeightAndPrice")
                        .WithMany()
                        .HasForeignKey("WeightAndPriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeightAndPrice");
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteSelling", b =>
                {
                    b.HasOne("wasteInventoryManagementSystem.Models.WeightAndPrice", "WeightAndPrice")
                        .WithMany()
                        .HasForeignKey("WeightAndPriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeightAndPrice");
                });
#pragma warning restore 612, 618
        }
    }
}