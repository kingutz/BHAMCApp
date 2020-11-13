using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BHAMCApp.Migrations
{
    public partial class FKB2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FKBABA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    IDNumber = table.Column<uint>(nullable: true),
                    Q1 = table.Column<int>(nullable: false),
                    Q1_1 = table.Column<uint>(nullable: true),
                    Q2 = table.Column<int>(nullable: false),
                    Q2_1 = table.Column<string>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    Q4 = table.Column<int>(nullable: false),
                    Q5 = table.Column<string>(nullable: true),
                    Q6 = table.Column<int>(nullable: false),
                    Q7 = table.Column<int>(nullable: false),
                    Q8 = table.Column<string>(nullable: true),
                    Q9 = table.Column<string>(nullable: true),
                    Q10_1 = table.Column<int>(nullable: false),
                    Q10_2 = table.Column<int>(nullable: false),
                    Q10_3 = table.Column<int>(nullable: false),
                    Q10_4 = table.Column<int>(nullable: false),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    ManagementFT = table.Column<string>(nullable: true),
                    DateFollowup = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FKBABA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FKBABA");
        }
    }
}
