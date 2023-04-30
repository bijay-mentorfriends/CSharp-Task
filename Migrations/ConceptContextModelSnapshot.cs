﻿// <auto-generated />
using InternTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InternTask.Migrations
{
    [DbContext(typeof(ConceptContext))]
    partial class ConceptContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InternTask.Entities.Concept", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Composition")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Concepts");
                });
#pragma warning restore 612, 618
        }
    }
}