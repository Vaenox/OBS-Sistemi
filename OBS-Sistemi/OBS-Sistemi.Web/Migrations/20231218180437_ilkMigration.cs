using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBS_Sistemi.Web.Migrations
{
    /// <inheritdoc />
    public partial class ilkMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Bolumler",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretimTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenimDili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Bolumler", x => x.BolumID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Danismanlik",
                columns: table => new
                {
                    DanismanlikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrElmID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Danismanlik", x => x.DanismanlikID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Degerlendirme",
                columns: table => new
                {
                    DegerlendirmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinavID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false),
                    SinavNotu = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Degerlendirme", x => x.DegerlendirmeID);
                });

            migrationBuilder.CreateTable(
                name: "tb_DersAcma",
                columns: table => new
                {
                    DersAcmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkademikYil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AkademikDonem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MufreatID = table.Column<int>(type: "int", nullable: false),
                    Kontenjan = table.Column<int>(type: "int", nullable: false),
                    OgrElmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DersAcma", x => x.DersAcmaID);
                });

            migrationBuilder.CreateTable(
                name: "tb_DersAlma",
                columns: table => new
                {
                    DersAlmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAcmaID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DersAlma", x => x.DersAlmaID);
                });

            migrationBuilder.CreateTable(
                name: "tb_DersHavuzu",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersDili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersSeviyesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teorik = table.Column<int>(type: "int", nullable: false),
                    Uygulama = table.Column<int>(type: "int", nullable: false),
                    Kredi = table.Column<double>(type: "float", nullable: false),
                    ECTS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DersHavuzu", x => x.DersID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Derslik",
                columns: table => new
                {
                    DerslikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DerslikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DerslikTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Derslik", x => x.DerslikID);
                });

            migrationBuilder.CreateTable(
                name: "tb_DersProgrami",
                columns: table => new
                {
                    DersPrgID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAcmaID = table.Column<int>(type: "int", nullable: false),
                    DerslikID = table.Column<int>(type: "int", nullable: false),
                    DersGunu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersSaati = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DersProgrami", x => x.DersPrgID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciTuru = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Kullanicilar", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Mufredat",
                columns: table => new
                {
                    MufredatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: false),
                    DersID = table.Column<int>(type: "int", nullable: false),
                    AkademikYil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AkademikDonem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersDonemi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Mufredat", x => x.MufredatID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Ogrenciler",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AyrilmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Ogrenciler", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "tb_OgretimElemani",
                columns: table => new
                {
                    OgrElmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: false),
                    KurumSicilNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OgretimElemani", x => x.OgrElmID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Sinav",
                columns: table => new
                {
                    SinavID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAcmaID = table.Column<int>(type: "int", nullable: false),
                    SinavTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtkiOrani = table.Column<int>(type: "int", nullable: false),
                    SinavTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SinavSaati = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DerslikID = table.Column<int>(type: "int", nullable: false),
                    OgrElmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Sinav", x => x.SinavID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Bolumler");

            migrationBuilder.DropTable(
                name: "tb_Danismanlik");

            migrationBuilder.DropTable(
                name: "tb_Degerlendirme");

            migrationBuilder.DropTable(
                name: "tb_DersAcma");

            migrationBuilder.DropTable(
                name: "tb_DersAlma");

            migrationBuilder.DropTable(
                name: "tb_DersHavuzu");

            migrationBuilder.DropTable(
                name: "tb_Derslik");

            migrationBuilder.DropTable(
                name: "tb_DersProgrami");

            migrationBuilder.DropTable(
                name: "tb_Kullanicilar");

            migrationBuilder.DropTable(
                name: "tb_Mufredat");

            migrationBuilder.DropTable(
                name: "tb_Ogrenciler");

            migrationBuilder.DropTable(
                name: "tb_OgretimElemani");

            migrationBuilder.DropTable(
                name: "tb_Sinav");
        }
    }
}
