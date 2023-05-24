﻿// <auto-generated />
using System;
using FindMyRouteAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FindMyRouteAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230524131026_migracija")]
    partial class migracija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.DaniVoznje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Cetvrtak")
                        .HasColumnType("bit");

                    b.Property<bool>("Nedjelja")
                        .HasColumnType("bit");

                    b.Property<bool>("Petak")
                        .HasColumnType("bit");

                    b.Property<bool>("Ponedjeljak")
                        .HasColumnType("bit");

                    b.Property<bool>("Srijeda")
                        .HasColumnType("bit");

                    b.Property<bool>("Subota")
                        .HasColumnType("bit");

                    b.Property<bool>("Utorak")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DaniVoznje");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.KreditnaKartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BrojKartice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Korisnik_id")
                        .HasColumnType("int");

                    b.Property<string>("SigurnosniBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Korisnik_id");

                    b.ToTable("KreditnaKartica");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Kupovina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumKupovine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVoznje")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("Korisnik_id")
                        .HasColumnType("int");

                    b.Property<int?>("Linija_id")
                        .HasColumnType("int");

                    b.Property<int>("UkupnaCijena")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Korisnik_id");

                    b.HasIndex("Linija_id");

                    b.ToTable("Kupovina");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Linija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cijena")
                        .HasColumnType("int");

                    b.Property<int?>("DaniVoznje_id")
                        .HasColumnType("int");

                    b.Property<int>("DolazakMinute")
                        .HasColumnType("int");

                    b.Property<int>("DolazakSati")
                        .HasColumnType("int");

                    b.Property<string>("Grad1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kilometraza")
                        .HasColumnType("int");

                    b.Property<int>("PolazakMinute")
                        .HasColumnType("int");

                    b.Property<int>("PolazakSati")
                        .HasColumnType("int");

                    b.Property<string>("Presjedanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Prevoznik_id")
                        .HasColumnType("int");

                    b.Property<int>("Trajanje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DaniVoznje_id");

                    b.HasIndex("Prevoznik_id");

                    b.ToTable("Linija");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Prevoznik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prevoznik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAktiviran")
                        .HasColumnType("bit");

                    b.Property<string>("korisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Administrator", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Korisnik", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<int>("BrojKupljenihKarata")
                        .HasColumnType("int");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.RadnikFirme", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Pozicija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Prevoznik_id")
                        .HasColumnType("int");

                    b.Property<int>("RadniStaz")
                        .HasColumnType("int");

                    b.HasIndex("Prevoznik_id");

                    b.ToTable("RadnikFirme");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.KreditnaKartica", b =>
                {
                    b.HasOne("FindMyRouteAPI.Modul.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("Korisnik_id");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Kupovina", b =>
                {
                    b.HasOne("FindMyRouteAPI.Modul.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("Korisnik_id");

                    b.HasOne("FindMyRouteAPI.Modul.Models.Linija", "Linija")
                        .WithMany()
                        .HasForeignKey("Linija_id");

                    b.Navigation("Korisnik");

                    b.Navigation("Linija");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Linija", b =>
                {
                    b.HasOne("FindMyRouteAPI.Modul.Models.DaniVoznje", "DaniVoznje")
                        .WithMany()
                        .HasForeignKey("DaniVoznje_id");

                    b.HasOne("FindMyRouteAPI.Modul.Models.Prevoznik", "Prevoznik")
                        .WithMany()
                        .HasForeignKey("Prevoznik_id");

                    b.Navigation("DaniVoznje");

                    b.Navigation("Prevoznik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Administrator", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FindMyRouteAPI.Modul.Models.Administrator", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.Korisnik", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FindMyRouteAPI.Modul.Models.Korisnik", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FindMyRouteAPI.Modul.Models.RadnikFirme", b =>
                {
                    b.HasOne("FindMyRouteAPI.Modul.Models.Prevoznik", "Prevoznik")
                        .WithMany()
                        .HasForeignKey("Prevoznik_id");

                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FindMyRouteAPI.Modul.Models.RadnikFirme", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Prevoznik");
                });
#pragma warning restore 612, 618
        }
    }
}
