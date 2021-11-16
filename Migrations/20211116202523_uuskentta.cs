using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tietokantatesti.Migrations
{
    public partial class uuskentta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PVM",
                table: "Tietueet",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PVM",
                table: "Tietueet");
        }
    }
}
