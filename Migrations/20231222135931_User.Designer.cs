﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Farcas_Gherghelas.Data;

#nullable disable

namespace Proiect_Farcas_Gherghelas.Migrations
{
    [DbContext(typeof(Proiect_Farcas_GherghelasContext))]
    [Migration("20231222135931_User")]
    partial class User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Inchiriere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Magazin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PartieID");

                    b.ToTable("Inchiriere");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Partie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Partie");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Inaltime")
                        .HasColumnType("int");

                    b.Property<int?>("InchiriereID")
                        .HasColumnType("int");

                    b.Property<int>("Marime")
                        .HasColumnType("int");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipProdus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("InchiriereID");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Programare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataOra")
                        .HasColumnType("datetime2");

                    b.Property<string>("InchiriereID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InchiriereID1")
                        .HasColumnType("int");

                    b.Property<int>("NrOre")
                        .HasColumnType("int");

                    b.Property<int?>("ProdusID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("InchiriereID1");

                    b.HasIndex("ProdusID");

                    b.HasIndex("UserID");

                    b.ToTable("Programare");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Inchiriere", b =>
                {
                    b.HasOne("Proiect_Farcas_Gherghelas.Models.Partie", "Partie")
                        .WithMany()
                        .HasForeignKey("PartieID");

                    b.Navigation("Partie");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Produs", b =>
                {
                    b.HasOne("Proiect_Farcas_Gherghelas.Models.Inchiriere", "Inchiriere")
                        .WithMany()
                        .HasForeignKey("InchiriereID");

                    b.Navigation("Inchiriere");
                });

            modelBuilder.Entity("Proiect_Farcas_Gherghelas.Models.Programare", b =>
                {
                    b.HasOne("Proiect_Farcas_Gherghelas.Models.Inchiriere", "Inchiriere")
                        .WithMany()
                        .HasForeignKey("InchiriereID1");

                    b.HasOne("Proiect_Farcas_Gherghelas.Models.Produs", "Produs")
                        .WithMany()
                        .HasForeignKey("ProdusID");

                    b.HasOne("Proiect_Farcas_Gherghelas.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Inchiriere");

                    b.Navigation("Produs");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
