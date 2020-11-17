using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BHAMCApp.Migrations
{
    public partial class BH002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FSMAMA",
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
                    Q2_1 = table.Column<uint>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    Q3_1 = table.Column<string>(nullable: true),
                    Q4 = table.Column<int>(nullable: false),
                    Q4_1 = table.Column<uint>(nullable: true),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: false),
                    Q6_1 = table.Column<string>(nullable: true),
                    Q7 = table.Column<uint>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q8_1 = table.Column<string>(nullable: true),
                    Q9 = table.Column<int>(nullable: false),
                    Q10 = table.Column<string>(nullable: true),
                    Q11 = table.Column<int>(nullable: false),
                    Q12 = table.Column<int>(nullable: false),
                    Q13 = table.Column<int>(nullable: false),
                    Q14 = table.Column<int>(nullable: false),
                    Q15 = table.Column<string>(nullable: true),
                    Q16 = table.Column<int>(nullable: false),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    Q17 = table.Column<string>(nullable: true),
                    ManagementFT = table.Column<string>(nullable: true),
                    DateVisit9 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FSMAMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FTMAMA",
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
                    Q2_1 = table.Column<uint>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    Q3_1 = table.Column<string>(nullable: true),
                    Q4 = table.Column<int>(nullable: false),
                    Q4_1 = table.Column<uint>(nullable: true),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: false),
                    Q6_1 = table.Column<string>(nullable: true),
                    Q7 = table.Column<uint>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q8_1 = table.Column<string>(nullable: true),
                    Q9 = table.Column<int>(nullable: false),
                    Q10 = table.Column<string>(nullable: true),
                    Q11 = table.Column<int>(nullable: false),
                    Q12 = table.Column<int>(nullable: false),
                    Q13 = table.Column<int>(nullable: false),
                    Q13_1 = table.Column<string>(nullable: true),
                    Q14 = table.Column<string>(nullable: true),
                    Q15 = table.Column<uint>(nullable: true),
                    Q16 = table.Column<uint>(nullable: true),
                    Q17 = table.Column<int>(nullable: false),
                    Q18 = table.Column<int>(nullable: false),
                    Q19 = table.Column<int>(nullable: false),
                    Q20 = table.Column<int>(nullable: false),
                    Q21 = table.Column<int>(nullable: false),
                    Q22 = table.Column<int>(nullable: false),
                    Q23 = table.Column<int>(nullable: false),
                    Q24 = table.Column<int>(nullable: false),
                    Q25 = table.Column<int>(nullable: false),
                    Q26 = table.Column<int>(nullable: false),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    ManagementFT = table.Column<string>(nullable: true),
                    DateVisit6 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTMAMA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FSMAMA");

            migrationBuilder.DropTable(
                name: "FTMAMA");
        }
    }
}
