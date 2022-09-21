using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatShigavkp.Migrations
{
    public partial class Candidates1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Company_NamecompanyId",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Industry_NameindustryId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Jobtitle_NamejobtitleId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Company_Ind_NameindustryId",
                table: "Company",
                column: "Ind_NameindustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_Company_NamecompanyId",
                table: "Candidate",
                column: "Company_NamecompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_Industry_NameindustryId",
                table: "Candidate",
                column: "Industry_NameindustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_Jobtitle_NamejobtitleId",
                table: "Candidate",
                column: "Jobtitle_NamejobtitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_Company_NamecompanyId",
                table: "Candidate",
                column: "Company_NamecompanyId",
                principalTable: "Company",
                principalColumn: "companyId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Candidate_Industry_Industry_NameindustryId",
            //    table: "Candidate",
            //    column: "Industry_NameindustryId",
            //    principalTable: "Industry",
            //    principalColumn: "industryId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Candidate_Jobtitle_Jobtitle_NamejobtitleId",
            //    table: "Candidate",
            //    column: "Jobtitle_NamejobtitleId",
            //    principalTable: "Jobtitle",
            //    principalColumn: "jobtitleId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Company_Industry_Ind_NameindustryId",
            //    table: "Company",
            //    column: "Ind_NameindustryId",
            //    principalTable: "Industry",
            //    principalColumn: "industryId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_Company_NamecompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_Industry_NameindustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Jobtitle_Jobtitle_NamejobtitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_Ind_NameindustryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_Ind_NameindustryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_Company_NamecompanyId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_Industry_NameindustryId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_Jobtitle_NamejobtitleId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Ind_NameindustryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Company_NamecompanyId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Industry_NameindustryId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Jobtitle_NamejobtitleId",
                table: "Candidate");

            migrationBuilder.AlterColumn<int>(
                name: "mobileNumber",
                table: "Candidate",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
