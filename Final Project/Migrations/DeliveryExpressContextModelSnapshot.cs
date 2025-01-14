﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeliveryExpress.Migrations
{
    [DbContext(typeof(DeliveryExpressContext))]
    partial class DeliveryExpressContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeliveryExpress.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<long?>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToAddr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("OrderTypeId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DeliveryExpress.Models.DeliveryExecutive", b =>
                {
                    b.Property<int>("ExecutiveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExecutiveId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ExecutiveName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<long?>("PhnNo")
                        .HasColumnType("bigint");

                    b.HasKey("ExecutiveId");

                    b.HasIndex("OrderTypeId");

                    b.ToTable("DeliveryExecutive");
                });

            modelBuilder.Entity("DeliveryExpress.Models.OrderList", b =>
                {
                    b.Property<int>("OrderTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderTypeId"));

                    b.Property<string>("OrderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderTypeId");

                    b.ToTable("OrderList");
                });

            modelBuilder.Entity("DeliveryExpress.Models.Customer", b =>
                {
                    b.HasOne("DeliveryExpress.Models.OrderList", "OrderList")
                        .WithMany()
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("DeliveryExpress.Models.DeliveryExecutive", b =>
                {
                    b.HasOne("DeliveryExpress.Models.OrderList", "OrderList")
                        .WithMany()
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderList");
                });
#pragma warning restore 612, 618
        }
    }
}
