using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBS_Sistemi.Web.Migrations
{
    /// <inheritdoc />
    public partial class primaryKeyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tb_Ogrenciler_BolumID",
                table: "tb_Ogrenciler",
                column: "BolumID");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Ogrenciler_tb_Bolumler_BolumID",
                table: "tb_Ogrenciler",
                column: "BolumID",
                principalTable: "tb_Bolumler",
                principalColumn: "BolumID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Ogrenciler_tb_Bolumler_BolumID",
                table: "tb_Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_tb_Ogrenciler_BolumID",
                table: "tb_Ogrenciler");
        }
    }
}
