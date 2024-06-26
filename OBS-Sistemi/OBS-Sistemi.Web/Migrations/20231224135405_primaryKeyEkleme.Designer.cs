﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OBS_Sistemi.Web.Data;

#nullable disable

namespace OBS_Sistemi.Web.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20231224135405_primaryKeyEkleme")]
    partial class primaryKeyEkleme
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Bolum", b =>
                {
                    b.Property<int>("BolumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BolumID"));

                    b.Property<string>("BolumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenimDili")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretimTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BolumID");

                    b.ToTable("tb_Bolumler");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Danismanlik", b =>
                {
                    b.Property<int>("DanismanlikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DanismanlikID"));

                    b.Property<int>("OgrElmID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("DanismanlikID");

                    b.ToTable("tb_Danismanlik");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Degerlendirme", b =>
                {
                    b.Property<int>("DegerlendirmeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DegerlendirmeID"));

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.Property<int>("SinavID")
                        .HasColumnType("int");

                    b.Property<double>("SinavNotu")
                        .HasColumnType("float");

                    b.HasKey("DegerlendirmeID");

                    b.ToTable("tb_Degerlendirme");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.DersAcma", b =>
                {
                    b.Property<int>("DersAcmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersAcmaID"));

                    b.Property<string>("AkademikDonem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AkademikYil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kontenjan")
                        .HasColumnType("int");

                    b.Property<int>("MufreatID")
                        .HasColumnType("int");

                    b.Property<int>("OgrElmID")
                        .HasColumnType("int");

                    b.HasKey("DersAcmaID");

                    b.ToTable("tb_DersAcma");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.DersAlma", b =>
                {
                    b.Property<int>("DersAlmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersAlmaID"));

                    b.Property<int>("DersAcmaID")
                        .HasColumnType("int");

                    b.Property<string>("Durum")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("DersAlmaID");

                    b.ToTable("tb_DersAlma");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.DersHavuzu", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersID"));

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersDili")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersSeviyesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ECTS")
                        .HasColumnType("int");

                    b.Property<double>("Kredi")
                        .HasColumnType("float");

                    b.Property<int>("Teorik")
                        .HasColumnType("int");

                    b.Property<int>("Uygulama")
                        .HasColumnType("int");

                    b.HasKey("DersID");

                    b.ToTable("tb_DersHavuzu");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.DersProgrami", b =>
                {
                    b.Property<int>("DersPrgID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersPrgID"));

                    b.Property<int>("DersAcmaID")
                        .HasColumnType("int");

                    b.Property<string>("DersGunu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersSaati")
                        .HasColumnType("int");

                    b.Property<int>("DerslikID")
                        .HasColumnType("int");

                    b.HasKey("DersPrgID");

                    b.ToTable("tb_DersProgrami");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Derslik", b =>
                {
                    b.Property<int>("DerslikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DerslikID"));

                    b.Property<string>("DerslikAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DerslikTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kapasite")
                        .HasColumnType("int");

                    b.HasKey("DerslikID");

                    b.ToTable("tb_Derslik");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"));

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciID");

                    b.ToTable("tb_Kullanicilar");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Mufredat", b =>
                {
                    b.Property<int>("MufredatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MufredatID"));

                    b.Property<string>("AkademikDonem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AkademikYil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BolumID")
                        .HasColumnType("int");

                    b.Property<int>("DersDonemi")
                        .HasColumnType("int");

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.HasKey("MufredatID");

                    b.ToTable("tb_Mufredat");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciID"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AyrilmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("BolumID")
                        .HasColumnType("int");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("OgrenciNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKimlikNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciID");

                    b.ToTable("tb_Ogrenciler");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.OgretimElemani", b =>
                {
                    b.Property<int>("OgrElmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrElmID"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BolumID")
                        .HasColumnType("int");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("KurumSicilNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCKimlikNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrElmID");

                    b.ToTable("tb_OgretimElemani");
                });

            modelBuilder.Entity("OBS_Sistemi.Web.Models.Sinav", b =>
                {
                    b.Property<int>("SinavID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinavID"));

                    b.Property<int>("DersAcmaID")
                        .HasColumnType("int");

                    b.Property<int>("DerslikID")
                        .HasColumnType("int");

                    b.Property<int>("EtkiOrani")
                        .HasColumnType("int");

                    b.Property<int>("OgrElmID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SinavSaati")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SinavTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SinavTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinavID");

                    b.ToTable("tb_Sinav");
                });
#pragma warning restore 612, 618
        }
    }
}
