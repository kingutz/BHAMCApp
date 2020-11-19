using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BHAMCApp.Migrations
{
    public partial class BH003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "F15_24MAMA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    IDNumber = table.Column<uint>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Q1 = table.Column<int>(nullable: false),
                    Q1_1 = table.Column<uint>(nullable: true),
                    Q2 = table.Column<int>(nullable: false),
                    Q2_1 = table.Column<string>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    Q4 = table.Column<int>(nullable: false),
                    Q4_1 = table.Column<uint>(nullable: true),
                    Q4_2 = table.Column<uint>(nullable: true),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: false),
                    Q6_1 = table.Column<string>(nullable: true),
                    Q7 = table.Column<int>(nullable: false),
                    Q8 = table.Column<int>(nullable: false),
                    Q9 = table.Column<int>(nullable: false),
                    Q10 = table.Column<int>(nullable: false),
                    Q10_1 = table.Column<string>(nullable: true),
                    Q11 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F15_24MAMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "F28_44MAMA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    IDNumber = table.Column<uint>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    DateKuzaliwa = table.Column<DateTime>(nullable: true),
                    UmriMama = table.Column<uint>(nullable: true),
                    Q1 = table.Column<int>(nullable: false),
                    Q2 = table.Column<int>(nullable: false),
                    Q3 = table.Column<int>(nullable: false),
                    Q4 = table.Column<int>(nullable: false),
                    Q5 = table.Column<int>(nullable: false),
                    Q5_1 = table.Column<uint>(nullable: true),
                    Q6 = table.Column<int>(nullable: false),
                    Q7 = table.Column<int>(nullable: false),
                    Q7_1 = table.Column<uint>(nullable: true),
                    Q7_2 = table.Column<uint>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q9 = table.Column<int>(nullable: false),
                    Q10 = table.Column<int>(nullable: false),
                    Q10_1 = table.Column<string>(nullable: true),
                    Q11 = table.Column<int>(nullable: false),
                    Q12 = table.Column<int>(nullable: false),
                    Q13 = table.Column<int>(nullable: false),
                    Q13_1 = table.Column<string>(nullable: true),
                    Q13_2 = table.Column<uint>(nullable: true),
                    Q13_3 = table.Column<string>(nullable: true),
                    Q14_1 = table.Column<int>(nullable: false),
                    Q14_2 = table.Column<int>(nullable: false),
                    Q14_3 = table.Column<int>(nullable: false),
                    Q14_4 = table.Column<int>(nullable: false),
                    Q14_5 = table.Column<int>(nullable: false),
                    Q14_6 = table.Column<int>(nullable: false),
                    Q15 = table.Column<int>(nullable: false),
                    Q15_1 = table.Column<string>(nullable: true),
                    Q16 = table.Column<int>(nullable: false),
                    Q17 = table.Column<string>(nullable: true),
                    Q18 = table.Column<string>(nullable: true),
                    Q19_1 = table.Column<string>(nullable: true),
                    Q19_2 = table.Column<string>(nullable: true),
                    Q19_3 = table.Column<string>(nullable: true),
                    Q20 = table.Column<uint>(nullable: true),
                    Q21 = table.Column<uint>(nullable: true),
                    Q22 = table.Column<string>(nullable: true),
                    Q23 = table.Column<uint>(nullable: true),
                    Q24 = table.Column<uint>(nullable: true),
                    Q25 = table.Column<int>(nullable: false),
                    Q26 = table.Column<int>(nullable: false),
                    Q27 = table.Column<int>(nullable: false),
                    Q28 = table.Column<int>(nullable: false),
                    Q29 = table.Column<uint>(nullable: true),
                    Q30 = table.Column<uint>(nullable: true),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    ManagementFT = table.Column<string>(nullable: true),
                    DateVisit32 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F28_44MAMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "F48MAMA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    IDNumber = table.Column<uint>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    MiakaMoshi = table.Column<uint>(nullable: true),
                    DateKuzaliwa = table.Column<DateTime>(nullable: true),
                    UmriMama = table.Column<uint>(nullable: true),
                    Q1 = table.Column<uint>(nullable: true),
                    Q2 = table.Column<int>(nullable: false),
                    Q2_1 = table.Column<string>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    Q3_1 = table.Column<string>(nullable: true),
                    Q4 = table.Column<int>(nullable: false),
                    Q4_1 = table.Column<string>(nullable: true),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<uint>(nullable: true),
                    Q7 = table.Column<uint>(nullable: true),
                    Q8 = table.Column<uint>(nullable: true),
                    Q8_1 = table.Column<uint>(nullable: true),
                    Q8_2 = table.Column<uint>(nullable: true),
                    Q9 = table.Column<int>(nullable: false),
                    Q9_1 = table.Column<string>(nullable: true),
                    Q10 = table.Column<int>(nullable: false),
                    Q11 = table.Column<int>(nullable: false),
                    Q11_1 = table.Column<string>(nullable: true),
                    Q12 = table.Column<int>(nullable: false),
                    Q13 = table.Column<int>(nullable: false),
                    Q13_1 = table.Column<uint>(nullable: true),
                    Q13_2 = table.Column<uint>(nullable: true),
                    Q13_3 = table.Column<uint>(nullable: true),
                    Q14 = table.Column<uint>(nullable: true),
                    Q15 = table.Column<int>(nullable: false),
                    Q16 = table.Column<int>(nullable: false),
                    Q16_1 = table.Column<uint>(nullable: true),
                    Q17 = table.Column<int>(nullable: false),
                    Q17_1 = table.Column<uint>(nullable: true),
                    Q18 = table.Column<int>(nullable: false),
                    Q19 = table.Column<int>(nullable: false),
                    Q19_1 = table.Column<uint>(nullable: true),
                    Q19_2 = table.Column<uint>(nullable: true),
                    Q20 = table.Column<uint>(nullable: true),
                    Q20_1 = table.Column<string>(nullable: true),
                    Q20_2 = table.Column<int>(nullable: false),
                    Q20_2_1 = table.Column<uint>(nullable: true),
                    Q20_3 = table.Column<int>(nullable: false),
                    Q20_3_1 = table.Column<int>(nullable: false),
                    Q21 = table.Column<uint>(nullable: true),
                    Q22 = table.Column<int>(nullable: false),
                    Q22_1 = table.Column<uint>(nullable: true),
                    Q23 = table.Column<int>(nullable: false),
                    Q24 = table.Column<int>(nullable: false),
                    Q25 = table.Column<int>(nullable: false),
                    Q25_1 = table.Column<uint>(nullable: true),
                    Q26 = table.Column<int>(nullable: false),
                    Q27 = table.Column<uint>(nullable: true),
                    Q27_1 = table.Column<uint>(nullable: true),
                    Q27_2 = table.Column<uint>(nullable: true),
                    Q27_3 = table.Column<int>(nullable: false),
                    Q28 = table.Column<int>(nullable: false),
                    Q28_1 = table.Column<string>(nullable: true),
                    Q29 = table.Column<string>(nullable: true),
                    Q30 = table.Column<string>(nullable: true),
                    Q31 = table.Column<int>(nullable: false),
                    Q31_1 = table.Column<int>(nullable: false),
                    Q31_2 = table.Column<int>(nullable: false),
                    Q31_3 = table.Column<int>(nullable: false),
                    Q31_4 = table.Column<int>(nullable: false),
                    Q31_5 = table.Column<int>(nullable: false),
                    Q32 = table.Column<int>(nullable: false),
                    Q32_1 = table.Column<int>(nullable: false),
                    Q32_2 = table.Column<int>(nullable: false),
                    Q32_3 = table.Column<int>(nullable: false),
                    Q32_4 = table.Column<int>(nullable: false),
                    Q32_5 = table.Column<int>(nullable: false),
                    Q32_6 = table.Column<int>(nullable: false),
                    Q33 = table.Column<int>(nullable: false),
                    Q33_1 = table.Column<string>(nullable: true),
                    Q34 = table.Column<uint>(nullable: true),
                    Q35_1 = table.Column<string>(nullable: true),
                    Q35_2 = table.Column<string>(nullable: true),
                    Q35_3 = table.Column<string>(nullable: true),
                    Q36 = table.Column<uint>(nullable: true),
                    Q37 = table.Column<uint>(nullable: true),
                    Q38 = table.Column<uint>(nullable: true),
                    Q39 = table.Column<uint>(nullable: true),
                    Q40 = table.Column<string>(nullable: true),
                    Q41 = table.Column<uint>(nullable: true),
                    Q42 = table.Column<int>(nullable: false),
                    Q43 = table.Column<int>(nullable: false),
                    Q44 = table.Column<int>(nullable: false),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    ManagementFT = table.Column<string>(nullable: true),
                    DateVisit52 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F48MAMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FKMMAMA",
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
                    Q3 = table.Column<int>(nullable: false),
                    Q3_1 = table.Column<string>(nullable: true),
                    Q4 = table.Column<int>(nullable: false),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: false),
                    Q7 = table.Column<int>(nullable: false),
                    Q7_1 = table.Column<string>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q9 = table.Column<int>(nullable: false),
                    Q10 = table.Column<int>(nullable: false),
                    Q11 = table.Column<int>(nullable: false),
                    Q11_1 = table.Column<string>(nullable: true),
                    Q13 = table.Column<string>(nullable: true),
                    Q14 = table.Column<uint>(nullable: true),
                    Q15 = table.Column<uint>(nullable: true),
                    Q16 = table.Column<uint>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FKMMAMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FTISAMAMA",
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
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: false),
                    Q6_1 = table.Column<string>(nullable: true),
                    Q7 = table.Column<int>(nullable: false),
                    Q7_1 = table.Column<string>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q9 = table.Column<string>(nullable: true),
                    Q10 = table.Column<int>(nullable: false),
                    Q11 = table.Column<int>(nullable: false),
                    Q12 = table.Column<int>(nullable: false),
                    Q12_1 = table.Column<string>(nullable: true),
                    Q13 = table.Column<string>(nullable: true),
                    Q14 = table.Column<uint>(nullable: true),
                    Q15 = table.Column<int>(nullable: false),
                    Q16 = table.Column<int>(nullable: false),
                    Q17 = table.Column<int>(nullable: false),
                    Q18 = table.Column<int>(nullable: false),
                    Q19 = table.Column<int>(nullable: false),
                    Q20 = table.Column<int>(nullable: false),
                    Q21 = table.Column<int>(nullable: false),
                    Q22 = table.Column<int>(nullable: false),
                    Q23 = table.Column<int>(nullable: false),
                    Q24 = table.Column<int>(nullable: false),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    ManagementFT = table.Column<string>(nullable: true),
                    DateVisit12 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTISAMAMA", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "F15_24MAMA");

            migrationBuilder.DropTable(
                name: "F28_44MAMA");

            migrationBuilder.DropTable(
                name: "F48MAMA");

            migrationBuilder.DropTable(
                name: "FKMMAMA");

            migrationBuilder.DropTable(
                name: "FTISAMAMA");
        }
    }
}
