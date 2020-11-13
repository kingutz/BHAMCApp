using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BHAMCApp.Migrations
{
    public partial class MTK2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FKMAMA",
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
                    OthersQ1 = table.Column<string>(nullable: true),
                    Q2 = table.Column<int>(nullable: false),
                    Q3 = table.Column<int>(nullable: false),
                    Q4 = table.Column<int>(nullable: false),
                    ItajeQ4 = table.Column<string>(nullable: true),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: false),
                    Q7 = table.Column<int>(nullable: false),
                    Q8 = table.Column<int>(nullable: false),
                    Q9 = table.Column<string>(nullable: true),
                    Q10 = table.Column<uint>(nullable: true),
                    Q11 = table.Column<uint>(nullable: true),
                    Q12 = table.Column<uint>(nullable: true),
                    Q13 = table.Column<int>(nullable: false),
                    Q14 = table.Column<int>(nullable: false),
                    Q15 = table.Column<int>(nullable: false),
                    Q16 = table.Column<int>(nullable: false),
                    Q17 = table.Column<int>(nullable: false),
                    Q18 = table.Column<int>(nullable: false),
                    Q19 = table.Column<int>(nullable: false),
                    Q20 = table.Column<int>(nullable: false),
                    Q21 = table.Column<int>(nullable: false),
                    Q22 = table.Column<int>(nullable: false),
                    Q23 = table.Column<string>(nullable: true),
                    ProblemsDiagnosis = table.Column<string>(nullable: true),
                    ManagementFK = table.Column<string>(nullable: true),
                    DateVisit3 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FKMAMA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FKMTOTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Tarehe = table.Column<DateTime>(nullable: true),
                    IDNumber = table.Column<uint>(nullable: true),
                    SexMt = table.Column<int>(nullable: false),
                    TareheKuzaliwa = table.Column<DateTime>(nullable: true),
                    UmriMtotoMiezi = table.Column<uint>(nullable: true),
                    Q1 = table.Column<int>(nullable: false),
                    Q1_a = table.Column<uint>(nullable: true),
                    Q1_b = table.Column<int>(nullable: false),
                    Q1_c = table.Column<int>(nullable: false),
                    Q2 = table.Column<string>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    Q3_a = table.Column<uint>(nullable: true),
                    Q3_b = table.Column<uint>(nullable: true),
                    Q4 = table.Column<int>(nullable: false),
                    Q5_1_a = table.Column<string>(nullable: true),
                    Q5_1_b = table.Column<uint>(nullable: true),
                    Q5_1_c = table.Column<string>(nullable: true),
                    Q5_1_d = table.Column<string>(nullable: true),
                    Q5_1_e = table.Column<string>(nullable: true),
                    Q5_2_a = table.Column<string>(nullable: true),
                    Q5_2_b = table.Column<uint>(nullable: true),
                    Q5_2_c = table.Column<string>(nullable: true),
                    Q5_2_d = table.Column<string>(nullable: true),
                    Q5_2_e = table.Column<string>(nullable: true),
                    Q5_3_a = table.Column<string>(nullable: true),
                    Q5_3_b = table.Column<uint>(nullable: true),
                    Q5_3_c = table.Column<string>(nullable: true),
                    Q5_3_d = table.Column<string>(nullable: true),
                    Q5_3_e = table.Column<string>(nullable: true),
                    Q5_4_a = table.Column<string>(nullable: true),
                    Q5_4_b = table.Column<uint>(nullable: true),
                    Q5_4_c = table.Column<string>(nullable: true),
                    Q5_4_d = table.Column<string>(nullable: true),
                    Q5_4_e = table.Column<string>(nullable: true),
                    Q5_5_a = table.Column<string>(nullable: true),
                    Q5_5_b = table.Column<uint>(nullable: true),
                    Q5_5_c = table.Column<string>(nullable: true),
                    Q5_5_d = table.Column<string>(nullable: true),
                    Q5_5_e = table.Column<string>(nullable: true),
                    Q7_1 = table.Column<int>(nullable: false),
                    Q7_1_a = table.Column<uint>(nullable: true),
                    Q7_1_b = table.Column<uint>(nullable: true),
                    Q7_2 = table.Column<int>(nullable: false),
                    Q7_2_a = table.Column<uint>(nullable: true),
                    Q7_2_b = table.Column<uint>(nullable: true),
                    Q7_3 = table.Column<int>(nullable: false),
                    Q7_3_a = table.Column<uint>(nullable: true),
                    Q7_3_b = table.Column<uint>(nullable: true),
                    Q7_4 = table.Column<int>(nullable: false),
                    Q7_4_a = table.Column<uint>(nullable: true),
                    Q7_4_b = table.Column<uint>(nullable: true),
                    Q7_5 = table.Column<int>(nullable: false),
                    Q7_5_a = table.Column<uint>(nullable: true),
                    Q7_5_b = table.Column<uint>(nullable: true),
                    Q7_6 = table.Column<int>(nullable: false),
                    Q7_6_a = table.Column<uint>(nullable: true),
                    Q7_6_b = table.Column<uint>(nullable: true),
                    Q7_7 = table.Column<int>(nullable: false),
                    Q7_7_a = table.Column<uint>(nullable: true),
                    Q7_7_b = table.Column<uint>(nullable: true),
                    Q7_8 = table.Column<string>(nullable: true),
                    Q7_8_a = table.Column<uint>(nullable: true),
                    Q7_8_b = table.Column<uint>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q8_1 = table.Column<string>(nullable: true),
                    Q9 = table.Column<int>(nullable: false),
                    Q9_1 = table.Column<string>(nullable: true),
                    Q10_a = table.Column<int>(nullable: false),
                    Q10_b = table.Column<int>(nullable: false),
                    Q10_c = table.Column<int>(nullable: false),
                    Q10_d = table.Column<int>(nullable: false),
                    Q10_e = table.Column<int>(nullable: false),
                    Q11_a = table.Column<int>(nullable: false),
                    Q11_b = table.Column<int>(nullable: false),
                    Q11_c = table.Column<int>(nullable: false),
                    Q12_a = table.Column<int>(nullable: false),
                    Q12_b = table.Column<int>(nullable: false),
                    Q12_c = table.Column<int>(nullable: false),
                    Q13_a = table.Column<int>(nullable: false),
                    Q13_b = table.Column<int>(nullable: false),
                    Q13_c = table.Column<int>(nullable: false),
                    Q13_d = table.Column<int>(nullable: false),
                    Q13_e = table.Column<int>(nullable: false),
                    Q13_f = table.Column<int>(nullable: false),
                    Q14_a = table.Column<int>(nullable: false),
                    Q14_b = table.Column<int>(nullable: false),
                    Q14_c = table.Column<int>(nullable: false),
                    Q14_d = table.Column<int>(nullable: false),
                    Q14_e = table.Column<uint>(nullable: true),
                    Q14_f = table.Column<uint>(nullable: true),
                    Q14_g = table.Column<uint>(nullable: true),
                    Q15_a = table.Column<int>(nullable: false),
                    Q15_b = table.Column<int>(nullable: false),
                    Q15_c = table.Column<int>(nullable: false),
                    Q15_d = table.Column<int>(nullable: false),
                    Q15_e = table.Column<int>(nullable: false),
                    Q15_f = table.Column<int>(nullable: false),
                    Q15_g = table.Column<int>(nullable: false),
                    Q15_h = table.Column<int>(nullable: false),
                    Q16_a = table.Column<int>(nullable: false),
                    Q16_b = table.Column<int>(nullable: false),
                    Q16_c = table.Column<int>(nullable: false),
                    ProblemsDsis = table.Column<string>(nullable: true),
                    MedicationPres = table.Column<string>(nullable: true),
                    Date3Month = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FKMTOTO", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FKMAMA");

            migrationBuilder.DropTable(
                name: "FKMTOTO");
        }
    }
}
