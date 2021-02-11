﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyExchange.Models;

namespace MoneyExchange.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210211153627_secondary")]
    partial class secondary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoneyExchange.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FromAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FromCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ToAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ToCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("History");
                });
#pragma warning restore 612, 618
        }
    }
}
