using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CowTracker.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_221 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNum = table.Column<int>(type: "int", nullable: false),
                    TagColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    Pen = table.Column<int>(type: "int", nullable: false),
                    ImplantDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextImplantDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Implant_length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calf", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calf");
        }
    }
}
