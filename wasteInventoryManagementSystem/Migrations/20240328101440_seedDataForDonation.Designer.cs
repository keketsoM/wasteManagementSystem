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
    [Migration("20240328101440_seedDataForDonation")]
    partial class seedDataForDonation
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

                    b.HasKey("id");

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

                    b.HasKey("Id");

                    b.ToTable("wasteDonations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessName = "keke shop",
                            ContactNumber = "0658775412",
                            ContactPerson = "kk",
                            Date = new DateTime(2024, 3, 28, 12, 14, 39, 878, DateTimeKind.Local).AddTicks(2143)
                        },
                        new
                        {
                            Id = 2,
                            BusinessName = "L shop",
                            ContactNumber = "0658777862",
                            ContactPerson = "ks",
                            Date = new DateTime(2024, 3, 28, 12, 14, 39, 878, DateTimeKind.Local).AddTicks(2158)
                        },
                        new
                        {
                            Id = 3,
                            BusinessName = "M shop",
                            ContactNumber = "0846775412",
                            ContactPerson = "kl",
                            Date = new DateTime(2024, 3, 28, 12, 14, 39, 878, DateTimeKind.Local).AddTicks(2159)
                        });
                });

            modelBuilder.Entity("wasteInventoryManagementSystem.Models.WasteSelling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("WholesaleCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WholesaleContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("wasteSellings");
                });
#pragma warning restore 612, 618
        }
    }
}