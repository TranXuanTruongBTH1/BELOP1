using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CayLapBu.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_TXTLopHoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TXTLopHoc",
                columns: table => new
                {
                    MaLopHoc = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenLophoc = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTLopHoc", x => x.MaLopHoc);
                });

            migrationBuilder.CreateTable(
                name: "TXTSinhVien",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenSV = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    MaSV = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTSinhVien", x => x.MaLop);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TXTLopHoc");

            migrationBuilder.DropTable(
                name: "TXTSinhVien");
        }
    }
}
