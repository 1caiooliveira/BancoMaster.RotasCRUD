using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoMaster.RotasCRUD.Domain.Migrations
{
    public partial class InsertRotas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee2"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee3"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee4"),
                columns: new[] { "DataCadastro", "LocalDestinoId" },
                values: new object[] { new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3260), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15") });

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee5"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee6"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee7"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee8"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3114));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 118, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 118, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 118, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 118, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 118, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee2"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee3"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee4"),
                columns: new[] { "DataCadastro", "LocalDestinoId" },
                values: new object[] { new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7758), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16") });

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee5"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee6"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee7"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee8"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7693));
        }
    }
}
