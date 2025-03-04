﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiPayment.Models;

namespace WebApiPayment.Migrations
{
    [DbContext(typeof(PaymentDbContext))]
    [Migration("20201105143241_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiPayment.Models.Payment", b =>
                {
                    b.Property<string>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("cardOwnerName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("expirationDate")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("paymentId");

                    b.ToTable("payments");
                });
#pragma warning restore 612, 618
        }
    }
}
