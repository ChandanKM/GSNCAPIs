using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSCN.DataLayer.Migrations
{
    public partial class UpdatedDB4_2_2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissaleniousDocInfo");

            migrationBuilder.CreateTable(
                name: "ContactInformations",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Line1 = table.Column<string>(nullable: true),
                    Line2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    LandMark = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformations", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_ContactInformations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalDetails",
                columns: table => new
                {
                    EducationalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification = table.Column<string>(nullable: true),
                    College = table.Column<string>(nullable: true),
                    PassOutYear = table.Column<DateTime>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalDetails", x => x.EducationalId);
                    table.ForeignKey(
                        name: "FK_EducationalDetails_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceDetails",
                columns: table => new
                {
                    ExperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization = table.Column<int>(nullable: false),
                    Designation = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    Current = table.Column<bool>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceDetails", x => x.ExperId);
                    table.ForeignKey(
                        name: "FK_ExperienceDetails_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherInformations",
                columns: table => new
                {
                    OtherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Speciality = table.Column<string>(nullable: true),
                    Expertise = table.Column<string>(nullable: true),
                    ResearchAwards = table.Column<string>(nullable: true),
                    Others = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherInformations", x => x.OtherId);
                    table.ForeignKey(
                        name: "FK_OtherInformations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_DoctorId",
                table: "ContactInformations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalDetails_DoctorId",
                table: "EducationalDetails",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDetails_DoctorId",
                table: "ExperienceDetails",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInformations_DoctorId",
                table: "OtherInformations",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInformations");

            migrationBuilder.DropTable(
                name: "EducationalDetails");

            migrationBuilder.DropTable(
                name: "ExperienceDetails");

            migrationBuilder.DropTable(
                name: "OtherInformations");

            migrationBuilder.CreateTable(
                name: "MissaleniousDocInfo",
                columns: table => new
                {
                    MissaleniousId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Current = table.Column<bool>(type: "bit", nullable: false),
                    Designation = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    Expertise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LandMark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Organization = table.Column<int>(type: "int", nullable: false),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassOutYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResearchAwards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissaleniousDocInfo", x => x.MissaleniousId);
                    table.ForeignKey(
                        name: "FK_MissaleniousDocInfo_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissaleniousDocInfo_DoctorId",
                table: "MissaleniousDocInfo",
                column: "DoctorId");
        }
    }
}
