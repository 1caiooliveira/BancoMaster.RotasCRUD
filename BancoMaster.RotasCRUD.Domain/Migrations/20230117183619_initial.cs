using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoMaster.RotasCRUD.Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "Locais",
                columns: new[] { "Id", "Ativo", "DataCadastro", "Nome" },
                values: new object[,]
                {
                    { new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"), true, new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1362), "GRU" },
                    { new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"), true, new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1380), "BRC" },
                    { new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"), true, new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1383), "ORL" },
                    { new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"), true, new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1386), "SCL" },
                    { new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"), true, new DateTime(2023, 1, 17, 15, 36, 19, 583, DateTimeKind.Local).AddTicks(1390), "CDG" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locais");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
