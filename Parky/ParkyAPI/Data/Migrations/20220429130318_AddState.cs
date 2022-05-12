using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkyAPI.Migrations
{
    public partial class AddState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalParks",
                table: "NationalParks");

            migrationBuilder.RenameTable(
                name: "NationalParks",
                newName: "NationalPark");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalPark",
                table: "NationalPark",
                column: "NationalParkId");

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: false),
                    CreatedDtim = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    CreatedUser = table.Column<string>(nullable: false, defaultValue: Environment.UserName),
                    ModifiedDtim = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    ModifiedUser = table.Column<DateTime>(nullable: false, defaultValue: Environment.UserName)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalPark",
                table: "NationalPark");

            migrationBuilder.RenameTable(
                name: "NationalPark",
                newName: "NationalParks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalParks",
                table: "NationalParks",
                column: "NationalParkId");
        }
    }
}
