﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CayLapBu.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("CayLapBu.Models.TXTLopHoc", b =>
                {
                    b.Property<int?>("MaLopHoc")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenLophoc")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaLopHoc");

                    b.ToTable("TXTLopHoc");
                });

            modelBuilder.Entity("CayLapBu.Models.TXTSinhVien", b =>
                {
                    b.Property<int?>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MaSV")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSV")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("TXTSinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
