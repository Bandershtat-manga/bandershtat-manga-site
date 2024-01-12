using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcess.Migrations
{
    public partial class DeleteLol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "60140d84-3866-4232-9dbd-e22b11da1d13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Client",
                column: "ConcurrencyStamp",
                value: "bead7039-484f-4552-aedb-96a581bf3514");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Меха");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Наукова фантастика");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Кіберпанк");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Стімпанк");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Апокаліпсис");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Постапокаліпсикс");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Фентезі");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Хоррор");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Готика");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Вестерн");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Пригоди");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Школа");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Бойовик");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Детектив");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Драма");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Історія");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Комедія");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Романтика");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Хентай");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Лолікон");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Меха");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Наукова фантастика");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Кіберпанк");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Стімпанк");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Апокаліпсис");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Постапокаліпсикс");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Фентезі");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Хоррор");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Готика");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Вестерн");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Пригоди");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Школа");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Бойовик");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Детектив");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Драма");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Історія");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Комедія");

            migrationBuilder.UpdateData(
                table: "Ganrs",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Романтика");

            migrationBuilder.InsertData(
                table: "Ganrs",
                columns: new[] { "Id", "Name" },
                values: new object[] { 33, "Хентай" });
        }
    }
}
