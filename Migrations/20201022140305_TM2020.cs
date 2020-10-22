﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BHAMCApp.Migrations
{
    public partial class TM2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bhamc",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    QuestionnaireNo = table.Column<int>(nullable: false),
                    AntenatalCare = table.Column<string>(nullable: true),
                    GestationalAge = table.Column<string>(nullable: true),
                    DateMenstruation = table.Column<DateTime>(nullable: true),
                    ExpectedDate = table.Column<DateTime>(nullable: true),
                    HospitalName = table.Column<string>(nullable: true),
                    PostNatalCare = table.Column<string>(nullable: true),
                    InterviewerName = table.Column<string>(nullable: true),
                    InterviewDate = table.Column<DateTime>(nullable: false),
                    Q1 = table.Column<DateTime>(nullable: false),
                    Q2 = table.Column<long>(nullable: true),
                    Q3 = table.Column<int>(nullable: false),
                    OthersQ3 = table.Column<string>(nullable: true),
                    Q4 = table.Column<int>(nullable: false),
                    OthersQ4 = table.Column<string>(nullable: true),
                    Q5 = table.Column<int>(nullable: false),
                    Q6 = table.Column<int>(nullable: true),
                    Q7 = table.Column<long>(nullable: true),
                    Q8 = table.Column<int>(nullable: false),
                    Q9 = table.Column<int>(nullable: false),
                    Q10 = table.Column<int>(nullable: false),
                    OthersQ10 = table.Column<string>(nullable: true),
                    Q11 = table.Column<long>(nullable: true),
                    Q12_1 = table.Column<bool>(nullable: false),
                    Q12_2 = table.Column<bool>(nullable: false),
                    Q12_3 = table.Column<bool>(nullable: false),
                    Q12_4 = table.Column<bool>(nullable: false),
                    Q12_5 = table.Column<bool>(nullable: false),
                    Q12_6 = table.Column<bool>(nullable: false),
                    Q12_7 = table.Column<bool>(nullable: false),
                    Q13 = table.Column<int>(nullable: false),
                    OthersQ13 = table.Column<string>(nullable: true),
                    Q14 = table.Column<long>(nullable: true),
                    Q15 = table.Column<int>(nullable: false),
                    OthersQ15 = table.Column<string>(nullable: true),
                    Q16 = table.Column<int>(nullable: false),
                    Q17 = table.Column<int>(nullable: false),
                    Q18 = table.Column<int>(nullable: false),
                    OthersQ18 = table.Column<string>(nullable: true),
                    Q19 = table.Column<int>(nullable: false),
                    Q20 = table.Column<int>(nullable: false),
                    OthersQ20 = table.Column<string>(nullable: true),
                    Q21 = table.Column<int>(nullable: false),
                    Q22_1 = table.Column<bool>(nullable: false),
                    Q22_2 = table.Column<bool>(nullable: false),
                    Q22_3 = table.Column<bool>(nullable: false),
                    Q22_4 = table.Column<bool>(nullable: false),
                    OthersQ22_4 = table.Column<string>(nullable: true),
                    Q23 = table.Column<int>(nullable: false),
                    Q24 = table.Column<long>(nullable: false),
                    Q25 = table.Column<int>(nullable: true),
                    Q26 = table.Column<long>(nullable: true),
                    Q27 = table.Column<int>(nullable: true),
                    Q28 = table.Column<int>(nullable: true),
                    Q29 = table.Column<long>(nullable: true),
                    Q30 = table.Column<long>(nullable: true),
                    Q31 = table.Column<int>(nullable: true),
                    Q32 = table.Column<int>(nullable: true),
                    Q32_1 = table.Column<long>(nullable: true),
                    Q33 = table.Column<int>(nullable: false),
                    Q34 = table.Column<int>(nullable: true),
                    Q35 = table.Column<int>(nullable: true),
                    OthersQ35 = table.Column<string>(nullable: true),
                    Q36 = table.Column<int>(nullable: true),
                    OthersQ36 = table.Column<string>(nullable: true),
                    Q37 = table.Column<string>(nullable: true),
                    Q38 = table.Column<long>(nullable: true),
                    Q39 = table.Column<int>(nullable: false),
                    Q40 = table.Column<long>(nullable: true),
                    Q41 = table.Column<long>(nullable: true),
                    Q42 = table.Column<int>(nullable: false),
                    Q43_1 = table.Column<bool>(nullable: false),
                    Q43_2 = table.Column<bool>(nullable: false),
                    Q43_3 = table.Column<bool>(nullable: false),
                    Q43_4 = table.Column<bool>(nullable: false),
                    Q43_5 = table.Column<bool>(nullable: false),
                    Q43_6 = table.Column<bool>(nullable: false),
                    Q44 = table.Column<int>(nullable: false),
                    Q45 = table.Column<int>(nullable: true),
                    Q46 = table.Column<int>(nullable: true),
                    Q47 = table.Column<int>(nullable: false),
                    Q48 = table.Column<long>(nullable: true),
                    Q49 = table.Column<int>(nullable: false),
                    Q50 = table.Column<string>(nullable: true),
                    Q51 = table.Column<long>(nullable: true),
                    Q52 = table.Column<string>(nullable: true),
                    Q53 = table.Column<int>(nullable: false),
                    Q54 = table.Column<int>(nullable: true),
                    Q54_1 = table.Column<DateTime>(nullable: true),
                    Q54_2 = table.Column<int>(nullable: true),
                    Q54_3 = table.Column<int>(nullable: true),
                    Q54_4 = table.Column<int>(nullable: true),
                    Q55 = table.Column<int>(nullable: false),
                    Q56 = table.Column<int>(nullable: true),
                    Q56_1 = table.Column<bool>(nullable: false),
                    Q56_2 = table.Column<bool>(nullable: false),
                    Q56_3 = table.Column<bool>(nullable: false),
                    Q56_4 = table.Column<bool>(nullable: false),
                    Q56_5 = table.Column<bool>(nullable: false),
                    OthersQ56 = table.Column<string>(nullable: true),
                    Q58_1 = table.Column<bool>(nullable: false),
                    Q58_2 = table.Column<bool>(nullable: false),
                    Q58_3 = table.Column<bool>(nullable: false),
                    Q58_4 = table.Column<bool>(nullable: false),
                    Q59_1 = table.Column<bool>(nullable: false),
                    Q59_2 = table.Column<bool>(nullable: false),
                    Q59_3 = table.Column<bool>(nullable: false),
                    Q59_4 = table.Column<bool>(nullable: false),
                    Q59_5 = table.Column<bool>(nullable: false),
                    Q59_6 = table.Column<bool>(nullable: false),
                    Q60 = table.Column<int>(nullable: false),
                    Q60_1 = table.Column<DateTime>(nullable: true),
                    Q60_2 = table.Column<string>(nullable: true),
                    Q60_3 = table.Column<string>(nullable: true),
                    Q61_1 = table.Column<bool>(nullable: false),
                    Q61_2 = table.Column<bool>(nullable: false),
                    Q61_3 = table.Column<bool>(nullable: false),
                    Q61_4 = table.Column<bool>(nullable: false),
                    Q61_5 = table.Column<bool>(nullable: false),
                    Q61_6 = table.Column<bool>(nullable: false),
                    Q62 = table.Column<int>(nullable: false),
                    Q63 = table.Column<string>(nullable: true),
                    Q64_1 = table.Column<bool>(nullable: false),
                    Q64_2 = table.Column<bool>(nullable: false),
                    Q64_3 = table.Column<bool>(nullable: false),
                    Q64_4 = table.Column<bool>(nullable: false),
                    Q64_5 = table.Column<bool>(nullable: false),
                    Q65 = table.Column<long>(nullable: true),
                    Q66 = table.Column<int>(nullable: false),
                    Q67 = table.Column<int>(nullable: false),
                    OthersQ67 = table.Column<string>(nullable: true),
                    Q68 = table.Column<int>(nullable: false),
                    Q68Yes = table.Column<int>(nullable: true),
                    Q69 = table.Column<int>(nullable: false),
                    Q70_1 = table.Column<bool>(nullable: false),
                    Q70_2 = table.Column<bool>(nullable: false),
                    Q70_3 = table.Column<bool>(nullable: false),
                    Q70_4 = table.Column<bool>(nullable: false),
                    OthersQ70_4 = table.Column<string>(nullable: true),
                    Q71 = table.Column<int>(nullable: false),
                    Q71_1 = table.Column<long>(nullable: true),
                    Q72 = table.Column<int>(nullable: false),
                    Q73 = table.Column<int>(nullable: false),
                    Q74 = table.Column<int>(nullable: false),
                    Q75 = table.Column<int>(nullable: false),
                    Q76 = table.Column<int>(nullable: false),
                    Q77 = table.Column<int>(nullable: false),
                    Q78 = table.Column<int>(nullable: false),
                    Q79 = table.Column<string>(nullable: true),
                    Q80 = table.Column<int>(nullable: false),
                    Q81_1 = table.Column<bool>(nullable: false),
                    Q81_2 = table.Column<bool>(nullable: false),
                    Q81_3 = table.Column<bool>(nullable: false),
                    Q81_4 = table.Column<bool>(nullable: false),
                    Q81_5 = table.Column<bool>(nullable: false),
                    Q81_6 = table.Column<bool>(nullable: false),
                    Q82_1 = table.Column<bool>(nullable: false),
                    Q82_2 = table.Column<bool>(nullable: false),
                    Q82_3 = table.Column<bool>(nullable: false),
                    Q82_4 = table.Column<bool>(nullable: false),
                    Q82_5 = table.Column<bool>(nullable: false),
                    Q83 = table.Column<int>(nullable: false),
                    Q84 = table.Column<int>(nullable: false),
                    Q85 = table.Column<int>(nullable: false),
                    Q86 = table.Column<int>(nullable: false),
                    Q87 = table.Column<int>(nullable: false),
                    Q88 = table.Column<int>(nullable: false),
                    Q89 = table.Column<int>(nullable: true),
                    Q90 = table.Column<int>(nullable: true),
                    OthersQ90 = table.Column<string>(nullable: true),
                    Q91 = table.Column<int>(nullable: false),
                    Q92 = table.Column<int>(nullable: true),
                    OthersQ92 = table.Column<string>(nullable: true),
                    Q93 = table.Column<int>(nullable: true),
                    Q94 = table.Column<int>(nullable: false),
                    Q95 = table.Column<int>(nullable: false),
                    Q96 = table.Column<long>(nullable: true),
                    Q97 = table.Column<int>(nullable: false),
                    Q98_1 = table.Column<bool>(nullable: false),
                    Q98_2 = table.Column<bool>(nullable: false),
                    Q98_3 = table.Column<bool>(nullable: false),
                    Q98_4 = table.Column<bool>(nullable: false),
                    Q98_5 = table.Column<bool>(nullable: false),
                    Q98_6 = table.Column<bool>(nullable: false),
                    Q99_1 = table.Column<bool>(nullable: false),
                    Q99_2 = table.Column<bool>(nullable: false),
                    Q99_3 = table.Column<bool>(nullable: false),
                    Q99_4 = table.Column<bool>(nullable: false),
                    Q99_5 = table.Column<bool>(nullable: false),
                    Q100_1_1 = table.Column<int>(nullable: false),
                    Q100_2_1 = table.Column<bool>(nullable: false),
                    Q100_2_2 = table.Column<bool>(nullable: false),
                    Q100_2_3 = table.Column<bool>(nullable: false),
                    Q100_3_1 = table.Column<bool>(nullable: false),
                    Q100_3_2 = table.Column<bool>(nullable: false),
                    Q100_3_3 = table.Column<bool>(nullable: false),
                    Q100_3_4 = table.Column<bool>(nullable: false),
                    Q100_4_1 = table.Column<bool>(nullable: false),
                    Q100_4_2 = table.Column<bool>(nullable: false),
                    Q100_4_3 = table.Column<bool>(nullable: false),
                    Q100_4_4 = table.Column<bool>(nullable: false),
                    Q100_4_5 = table.Column<bool>(nullable: false),
                    Q100_5_1 = table.Column<int>(nullable: false),
                    Q100_6_1 = table.Column<int>(nullable: false),
                    Q101_1 = table.Column<bool>(nullable: false),
                    Q101_2 = table.Column<bool>(nullable: false),
                    Q101_3 = table.Column<bool>(nullable: false),
                    Q102 = table.Column<long>(nullable: true),
                    Q103 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bhamc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bhamc_QuestionnaireNo",
                table: "Bhamc",
                column: "QuestionnaireNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bhamc");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
