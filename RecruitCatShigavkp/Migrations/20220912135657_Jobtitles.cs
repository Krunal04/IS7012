using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatShigavkp.Migrations
{
    public partial class Jobtitles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobtitle",
                columns: table => new
                {
                    jobtitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minSalary = table.Column<int>(type: "int", nullable: false),
                    maxSalary = table.Column<int>(type: "int", nullable: false),
                    deadLine = table.Column<DateTime>(type: "datetime2", nullable: true),
                    skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobtitle", x => x.jobtitleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobtitle");
        }
    }
}
