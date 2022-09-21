using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatShigavkp.Migrations
{
    public partial class Candidates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Company_Industry_Ind_NameindustryId",
            //    table: "Company");

            //migrationBuilder.DropIndex(
            //    name: "IX_Company_Ind_NameindustryId",
            //    table: "Company");

            ////migrationBuilder.DropColumn(
            ////    name: "Ind_NameindustryId",
            ////    table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "industryId",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mobileNumber",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Company_industryId",
                table: "Company",
                column: "industryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_industryId",
                table: "Company",
                column: "industryId",
                principalTable: "Industry",
                principalColumn: "industryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_industryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_industryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "industryId",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "Ind_NameindustryId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "mobileNumber",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Company_Ind_NameindustryId",
            //    table: "Company",
            //    column: "Ind_NameindustryId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Company_Industry_Ind_NameindustryId",
            //    table: "Company",
            //    column: "Ind_NameindustryId",
            //    principalTable: "Industry",
            //    principalColumn: "industryId",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
