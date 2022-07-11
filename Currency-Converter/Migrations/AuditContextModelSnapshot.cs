﻿// <auto-generated />
using System;
using Currency_Converter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace currency_converter.Migrations
{
    [DbContext(typeof(AuditContext))]
    partial class AuditContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Currency_Converter.Models.AuditModel", b =>
                {
                    b.Property<int>("ConversionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ConversionDateTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("ConvertedValue")
                        .HasColumnType("REAL");

                    b.Property<string>("CurrencyConvertedTo")
                        .HasColumnType("TEXT");

                    b.Property<double>("GBPValue")
                        .HasColumnType("REAL");

                    b.HasKey("ConversionId");

                    b.ToTable("Audit");
                });

            modelBuilder.Entity("Currency_Converter.Models.CurrencyModel", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Multiplier")
                        .HasColumnType("REAL");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currency");

                    b.HasData(
                        new
                        {
                            CurrencyId = 1,
                            CurrencyName = "AUD",
                            Multiplier = 1.76
                        },
                        new
                        {
                            CurrencyId = 2,
                            CurrencyName = "EUR",
                            Multiplier = 1.1699999999999999
                        },
                        new
                        {
                            CurrencyId = 3,
                            CurrencyName = "USD",
                            Multiplier = 1.2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
