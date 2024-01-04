using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyDoBo.Migrations
{
    /// <inheritdoc />
    public partial class TaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KieuMau",
                columns: table => new
                {
                    idkieumau = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    tenmau = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuMau", x => x.idkieumau);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    idsp = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    masp = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    namesp = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    idkieumau = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    gia = table.Column<int>(type: "INTEGER", nullable: false),
                    sale = table.Column<int>(type: "INTEGER", nullable: false),
                    hethang = table.Column<bool>(type: "INTEGER", nullable: false),
                    loaivai = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    anhdaidien = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.idsp);
                    table.UniqueConstraint("AK_SanPham_masp", x => x.masp);
                    table.ForeignKey(
                        name: "FK_SanPham_KieuMau_idkieumau",
                        column: x => x.idkieumau,
                        principalTable: "KieuMau",
                        principalColumn: "idkieumau",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    idanh = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    masp = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    mau = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    path = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    maanh = table.Column<string>(type: "TEXT", maxLength: 7, nullable: false),
                    hethang = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.idanh);
                    table.UniqueConstraint("AK_Anh_maanh", x => x.maanh);
                    table.ForeignKey(
                        name: "FK_Anh_SanPham_masp",
                        column: x => x.masp,
                        principalTable: "SanPham",
                        principalColumn: "masp");
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    idsize = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    masize = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    maanh = table.Column<string>(type: "TEXT", maxLength: 7, nullable: true),
                    masp = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    size = table.Column<string>(type: "TEXT", maxLength: 4, nullable: false),
                    soluong = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.idsize);
                    table.ForeignKey(
                        name: "FK_Size_Anh_maanh",
                        column: x => x.maanh,
                        principalTable: "Anh",
                        principalColumn: "maanh");
                    table.ForeignKey(
                        name: "FK_Size_SanPham_masp",
                        column: x => x.masp,
                        principalTable: "SanPham",
                        principalColumn: "masp");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anh_maanh",
                table: "Anh",
                column: "maanh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Anh_masp",
                table: "Anh",
                column: "masp");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_idkieumau",
                table: "SanPham",
                column: "idkieumau");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_masp",
                table: "SanPham",
                column: "masp");

            migrationBuilder.CreateIndex(
                name: "IX_Size_maanh",
                table: "Size",
                column: "maanh");

            migrationBuilder.CreateIndex(
                name: "IX_Size_masize",
                table: "Size",
                column: "masize",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Size_masp",
                table: "Size",
                column: "masp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KieuMau");
        }
    }
}
