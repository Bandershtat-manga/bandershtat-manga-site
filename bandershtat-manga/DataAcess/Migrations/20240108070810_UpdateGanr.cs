using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcess.Migrations
{
    public partial class UpdateGanr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideosGanr");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "f5c79715-b3ec-4c50-953f-f7a5a478761d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Client",
                column: "ConcurrencyStamp",
                value: "11737f17-a935-4c84-819b-be91586b2b70");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideosGanr",
                columns: table => new
                {
                    VideosId = table.Column<int>(type: "int", nullable: false),
                    GanrId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideosGanr", x => new { x.VideosId, x.GanrId });
                    table.ForeignKey(
                        name: "FK_VideosGanr_Ganrs_GanrId",
                        column: x => x.GanrId,
                        principalTable: "Ganrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideosGanr_Videoses_VideosId",
                        column: x => x.VideosId,
                        principalTable: "Videoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "48b828e6-097c-4138-8ab2-d7b75ac4ca5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Client",
                column: "ConcurrencyStamp",
                value: "fa595ab7-3009-440f-8978-7d2c10713888");

            migrationBuilder.CreateIndex(
                name: "IX_VideosGanr_GanrId",
                table: "VideosGanr",
                column: "GanrId");
        }
    }
}
