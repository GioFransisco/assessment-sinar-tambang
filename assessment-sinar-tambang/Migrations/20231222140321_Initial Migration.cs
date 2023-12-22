using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assessment_sinar_tambang.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dosen",
                columns: table => new
                {
                    Nip = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nama_Dosen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dosen", x => x.Nip);
                });

            migrationBuilder.CreateTable(
                name: "matakuliah",
                columns: table => new
                {
                    Kode_MK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nama_MK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKS = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matakuliah", x => x.Kode_MK);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dosen");

            migrationBuilder.DropTable(
                name: "matakuliah");
        }
    }
}
