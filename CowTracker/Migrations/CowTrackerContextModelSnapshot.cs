﻿// <auto-generated />
using System;
using CowTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CowTracker.Migrations
{
    [DbContext(typeof(CowTrackerContext))]
    partial class CowTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CowTracker.Calf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ImplantDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Implant_length")
                        .HasColumnType("int");

                    b.Property<DateTime>("NextImplantDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pen")
                        .HasColumnType("int");

                    b.Property<string>("TagColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TagNum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Calf");
                });

            modelBuilder.Entity("CowTracker.PenDB", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PenDB");
                });
#pragma warning restore 612, 618
        }
    }
}
