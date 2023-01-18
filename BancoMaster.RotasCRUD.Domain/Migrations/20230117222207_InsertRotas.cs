using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoMaster.RotasCRUD.Domain.Migrations
{
    public partial class InsertRotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Rotas",
                type: "Decimal(10,2)",
                maxLength: 9,
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

            migrationBuilder.InsertData(
                table: "Rotas",
                columns: new[] { "Id", "Ativo", "DataCadastro", "LocalDestinoId", "LocalOrigemId", "Valor" },
                values: new object[,]
                {
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee2"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7774), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"), 20m },
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee3"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7768), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"), 5m },
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee4"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7758), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"), 56m },
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee5"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7735), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"), 20m },
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee6"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7729), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"), 75m },
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee7"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7722), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"), 5m },
                    { new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee8"), true, new DateTime(2023, 1, 17, 19, 22, 5, 123, DateTimeKind.Local).AddTicks(7693), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"), new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"), 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee2"));

            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee3"));

            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee4"));

            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee5"));

            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee6"));

            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee7"));

            migrationBuilder.DeleteData(
                table: "Rotas",
                keyColumn: "Id",
                keyValue: new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee8"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Rotas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)",
                oldMaxLength: 9,
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1378));
        }
    }
}
