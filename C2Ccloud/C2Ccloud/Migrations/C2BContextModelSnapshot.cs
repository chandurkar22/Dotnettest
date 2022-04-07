﻿// <auto-generated />
using System;
using C2Bcloud;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C2Bcloud.Migrations
{
    [DbContext(typeof(C2BContext))]
    partial class C2BContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("C2Bcloud.BankDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ACnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CreditCard")
                        .HasColumnType("bit");

                    b.Property<bool>("DebitCard")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeesID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesID")
                        .IsUnique();

                    b.ToTable("BankDetails");
                });

            modelBuilder.Entity("C2Bcloud.Clients", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("C2Bcloud.Employees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("ClientsID")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientsID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("C2Bcloud.BankDetails", b =>
                {
                    b.HasOne("C2Bcloud.Employees", "Employees")
                        .WithOne("BankDetails")
                        .HasForeignKey("C2Bcloud.BankDetails", "EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("C2Bcloud.Employees", b =>
                {
                    b.HasOne("C2Bcloud.Clients", "Clients")
                        .WithMany("Employees")
                        .HasForeignKey("ClientsID");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("C2Bcloud.Clients", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("C2Bcloud.Employees", b =>
                {
                    b.Navigation("BankDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
