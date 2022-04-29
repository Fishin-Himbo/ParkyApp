using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkyAPI.Migrations
{
    public partial class InitialMigration_AddNationalParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalParkName = table.Column<string>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    CreatedDtim = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: false),
                    ModifiedDtim = table.Column<DateTime>(nullable: false),
                    ModifiedUser = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalParks");
        }
    }
}
