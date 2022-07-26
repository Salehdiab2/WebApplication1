﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ArrayContext))]
    partial class ArrayContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.ArraySort.ArrayPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ArrayPosition");
                });

            modelBuilder.Entity("WebApplication1.ArraySort.SortedArray", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("preSorted_position")
                        .HasColumnType("int");

                    b.Property<int>("sorted_position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SortedArray");
                });
#pragma warning restore 612, 618
        }
    }
}