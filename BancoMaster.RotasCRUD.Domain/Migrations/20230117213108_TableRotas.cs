using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoMaster.RotasCRUD.Domain.Migrations
{
    public partial class TableRotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rotas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalOrigemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalDestinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rotas_Locais_LocalDestinoId",
                        column: x => x.LocalDestinoId,
                        principalTable: "Locais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rotas_Locais_LocalOrigemId",
                        column: x => x.LocalOrigemId,
                        principalTable: "Locais",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Rotas_LocalDestinoId",
                table: "Rotas",
                column: "LocalDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rotas_LocalOrigemId",
                table: "Rotas",
                column: "LocalOrigemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rotas");

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Locais",
                keyColumn: "Id",
                keyValue: new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                column: "DataCadastro",
                value: new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1390));
        }
    }
}
