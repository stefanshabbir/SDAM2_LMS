﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDAM2_LMS.Models.Data;

#nullable disable

namespace SDAM2_LMS.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20250120025112_EnsurePersistence")]
    partial class EnsurePersistence
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("SDAM2_LMS.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonalID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountTypeID");

                    b.HasIndex("PersonalID")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.AccountType", b =>
                {
                    b.Property<int>("AccountTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountTypeID");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.PrimitiveCollection<string>("Authors")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.PrimitiveCollection<string>("Genres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.PrimitiveCollection<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.Borrowing", b =>
                {
                    b.Property<int>("BorrowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.HasKey("BorrowID");

                    b.HasIndex("AccountID");

                    b.HasIndex("BookID");

                    b.ToTable("Borrowings");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.PersonalID_Info", b =>
                {
                    b.Property<int>("PersonalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonalID");

                    b.ToTable("PersonalIDs");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.Account", b =>
                {
                    b.HasOne("SDAM2_LMS.Models.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDAM2_LMS.Models.PersonalID_Info", "PersonalID_Info")
                        .WithOne("Account")
                        .HasForeignKey("SDAM2_LMS.Models.Account", "PersonalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");

                    b.Navigation("PersonalID_Info");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.Borrowing", b =>
                {
                    b.HasOne("SDAM2_LMS.Models.Account", "Account")
                        .WithMany("Borrowings")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDAM2_LMS.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.Account", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("SDAM2_LMS.Models.PersonalID_Info", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}