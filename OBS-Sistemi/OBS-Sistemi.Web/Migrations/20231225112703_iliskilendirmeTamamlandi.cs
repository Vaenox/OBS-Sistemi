using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

#nullable disable

namespace OBS_Sistemi.Web.Migrations
{
    /// <inheritdoc />
    public partial class iliskilendirmeTamamlandi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DersAcmaID",
                table: "tb_OgretimElemani",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DersAlmaID",
                table: "tb_Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MufredatID",
                table: "tb_DersAcma",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Sinav_DersAcmaID",
                table: "tb_Sinav",
                column: "DersAcmaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Sinav_DerslikID",
                table: "tb_Sinav",
                column: "DerslikID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Sinav_OgrElmID",
                table: "tb_Sinav",
                column: "OgrElmID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_OgretimElemani_BolumID",
                table: "tb_OgretimElemani",
                column: "BolumID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_OgretimElemani_DersAcmaID",
                table: "tb_OgretimElemani",
                column: "DersAcmaID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_OgretimElemani_KullaniciID",
                table: "tb_OgretimElemani",
                column: "KullaniciID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ogrenciler_DersAlmaID",
                table: "tb_Ogrenciler",
                column: "DersAlmaID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ogrenciler_KullaniciID",
                table: "tb_Ogrenciler",
                column: "KullaniciID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Mufredat_BolumID",
                table: "tb_Mufredat",
                column: "BolumID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Mufredat_DersID",
                table: "tb_Mufredat",
                column: "DersID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_DersProgrami_DersAcmaID",
                table: "tb_DersProgrami",
                column: "DersAcmaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_DersProgrami_DerslikID",
                table: "tb_DersProgrami",
                column: "DerslikID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_DersAlma_DersAcmaID",
                table: "tb_DersAlma",
                column: "DersAcmaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_DersAcma_MufredatID",
                table: "tb_DersAcma",
                column: "MufredatID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Degerlendirme_OgrenciID",
                table: "tb_Degerlendirme",
                column: "OgrenciID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Degerlendirme_SinavID",
                table: "tb_Degerlendirme",
                column: "SinavID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Danismanlik_OgrElmID",
                table: "tb_Danismanlik",
                column: "OgrElmID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Danismanlik_OgrenciID",
                table: "tb_Danismanlik",
                column: "OgrenciID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Danismanlik_tb_Ogrenciler_OgrenciID",
                table: "tb_Danismanlik",
                column: "OgrenciID",
                principalTable: "tb_Ogrenciler",
                principalColumn: "OgrenciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Danismanlik_tb_OgretimElemani_OgrElmID",
                table: "tb_Danismanlik",
                column: "OgrElmID",
                principalTable: "tb_OgretimElemani",
                principalColumn: "OgrElmID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Degerlendirme_tb_Ogrenciler_OgrenciID",
                table: "tb_Degerlendirme",
                column: "OgrenciID",
                principalTable: "tb_Ogrenciler",
                principalColumn: "OgrenciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Degerlendirme_tb_Sinav_SinavID",
                table: "tb_Degerlendirme",
                column: "SinavID",
                principalTable: "tb_Sinav",
                principalColumn: "SinavID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_DersAcma_tb_Mufredat_MufredatID",
                table: "tb_DersAcma",
                column: "MufredatID",
                principalTable: "tb_Mufredat",
                principalColumn: "MufredatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_DersAlma_tb_DersAcma_DersAcmaID",
                table: "tb_DersAlma",
                column: "DersAcmaID",
                principalTable: "tb_DersAcma",
                principalColumn: "DersAcmaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_DersProgrami_tb_DersAcma_DersAcmaID",
                table: "tb_DersProgrami",
                column: "DersAcmaID",
                principalTable: "tb_DersAcma",
                principalColumn: "DersAcmaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_DersProgrami_tb_Derslik_DerslikID",
                table: "tb_DersProgrami",
                column: "DerslikID",
                principalTable: "tb_Derslik",
                principalColumn: "DerslikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Mufredat_tb_Bolumler_BolumID",
                table: "tb_Mufredat",
                column: "BolumID",
                principalTable: "tb_Bolumler",
                principalColumn: "BolumID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Mufredat_tb_DersHavuzu_DersID",
                table: "tb_Mufredat",
                column: "DersID",
                principalTable: "tb_DersHavuzu",
                principalColumn: "DersID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Ogrenciler_tb_DersAlma_DersAlmaID",
                table: "tb_Ogrenciler",
                column: "DersAlmaID",
                principalTable: "tb_DersAlma",
                principalColumn: "DersAlmaID",
                
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Ogrenciler_tb_Kullanicilar_KullaniciID",
                table: "tb_Ogrenciler",
                column: "KullaniciID",
                principalTable: "tb_Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_OgretimElemani_tb_Bolumler_BolumID",
                table: "tb_OgretimElemani",
                column: "BolumID",
                principalTable: "tb_Bolumler",
                principalColumn: "BolumID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_OgretimElemani_tb_DersAcma_DersAcmaID",
                table: "tb_OgretimElemani",
                column: "DersAcmaID",
                principalTable: "tb_DersAcma",
                principalColumn: "DersAcmaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_OgretimElemani_tb_Kullanicilar_KullaniciID",
                table: "tb_OgretimElemani",
                column: "KullaniciID",
                principalTable: "tb_Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Sinav_tb_DersAcma_DersAcmaID",
                table: "tb_Sinav",
                column: "DersAcmaID",
                principalTable: "tb_DersAcma",
                principalColumn: "DersAcmaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Sinav_tb_Derslik_DerslikID",
                table: "tb_Sinav",
                column: "DerslikID",
                principalTable: "tb_Derslik",
                principalColumn: "DerslikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Sinav_tb_OgretimElemani_OgrElmID",
                table: "tb_Sinav",
                column: "OgrElmID",
                principalTable: "tb_OgretimElemani",
                principalColumn: "OgrElmID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Danismanlik_tb_Ogrenciler_OgrenciID",
                table: "tb_Danismanlik");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Danismanlik_tb_OgretimElemani_OgrElmID",
                table: "tb_Danismanlik");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Degerlendirme_tb_Ogrenciler_OgrenciID",
                table: "tb_Degerlendirme");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Degerlendirme_tb_Sinav_SinavID",
                table: "tb_Degerlendirme");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_DersAcma_tb_Mufredat_MufredatID",
                table: "tb_DersAcma");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_DersAlma_tb_DersAcma_DersAcmaID",
                table: "tb_DersAlma");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_DersProgrami_tb_DersAcma_DersAcmaID",
                table: "tb_DersProgrami");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_DersProgrami_tb_Derslik_DerslikID",
                table: "tb_DersProgrami");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Mufredat_tb_Bolumler_BolumID",
                table: "tb_Mufredat");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Mufredat_tb_DersHavuzu_DersID",
                table: "tb_Mufredat");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Ogrenciler_tb_DersAlma_DersAlmaID",
                table: "tb_Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Ogrenciler_tb_Kullanicilar_KullaniciID",
                table: "tb_Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_OgretimElemani_tb_Bolumler_BolumID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_OgretimElemani_tb_DersAcma_DersAcmaID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_OgretimElemani_tb_Kullanicilar_KullaniciID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Sinav_tb_DersAcma_DersAcmaID",
                table: "tb_Sinav");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Sinav_tb_Derslik_DerslikID",
                table: "tb_Sinav");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Sinav_tb_OgretimElemani_OgrElmID",
                table: "tb_Sinav");

            migrationBuilder.DropIndex(
                name: "IX_tb_Sinav_DersAcmaID",
                table: "tb_Sinav");

            migrationBuilder.DropIndex(
                name: "IX_tb_Sinav_DerslikID",
                table: "tb_Sinav");

            migrationBuilder.DropIndex(
                name: "IX_tb_Sinav_OgrElmID",
                table: "tb_Sinav");

            migrationBuilder.DropIndex(
                name: "IX_tb_OgretimElemani_BolumID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropIndex(
                name: "IX_tb_OgretimElemani_DersAcmaID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropIndex(
                name: "IX_tb_OgretimElemani_KullaniciID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropIndex(
                name: "IX_tb_Ogrenciler_DersAlmaID",
                table: "tb_Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_tb_Ogrenciler_KullaniciID",
                table: "tb_Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_tb_Mufredat_BolumID",
                table: "tb_Mufredat");

            migrationBuilder.DropIndex(
                name: "IX_tb_Mufredat_DersID",
                table: "tb_Mufredat");

            migrationBuilder.DropIndex(
                name: "IX_tb_DersProgrami_DersAcmaID",
                table: "tb_DersProgrami");

            migrationBuilder.DropIndex(
                name: "IX_tb_DersProgrami_DerslikID",
                table: "tb_DersProgrami");

            migrationBuilder.DropIndex(
                name: "IX_tb_DersAlma_DersAcmaID",
                table: "tb_DersAlma");

            migrationBuilder.DropIndex(
                name: "IX_tb_DersAcma_MufredatID",
                table: "tb_DersAcma");

            migrationBuilder.DropIndex(
                name: "IX_tb_Degerlendirme_OgrenciID",
                table: "tb_Degerlendirme");

            migrationBuilder.DropIndex(
                name: "IX_tb_Degerlendirme_SinavID",
                table: "tb_Degerlendirme");

            migrationBuilder.DropIndex(
                name: "IX_tb_Danismanlik_OgrElmID",
                table: "tb_Danismanlik");

            migrationBuilder.DropIndex(
                name: "IX_tb_Danismanlik_OgrenciID",
                table: "tb_Danismanlik");

            migrationBuilder.DropColumn(
                name: "DersAcmaID",
                table: "tb_OgretimElemani");

            migrationBuilder.DropColumn(
                name: "DersAlmaID",
                table: "tb_Ogrenciler");

            migrationBuilder.DropColumn(
                name: "MufredatID",
                table: "tb_DersAcma");
        }
    }
}
