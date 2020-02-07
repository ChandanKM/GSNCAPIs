using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GSCN.DataLayer.Migrations
{
    public partial class ininitialsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    RegisteredYear = table.Column<DateTime>(nullable: false),
                    RegistrationNo = table.Column<string>(nullable: true),
                    InternationalBoard = table.Column<string>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    Country = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    AboutMe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "BankInformations",
                columns: table => new
                {
                    BankinfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(nullable: true),
                    BankCode = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    BranchName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    BranchEmail = table.Column<string>(nullable: true),
                    IFSCCode = table.Column<string>(nullable: true),
                    MICRCode = table.Column<string>(nullable: true),
                    Notification = table.Column<bool>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInformations", x => x.BankinfoId);
                    table.ForeignKey(
                        name: "FK_BankInformations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeesAndTimings",
                columns: table => new
                {
                    FandTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeesAndTimings", x => x.FandTId);
                    table.ForeignKey(
                        name: "FK_FeesAndTimings_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissaleniousDocInfo",
                columns: table => new
                {
                    MissaleniousId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification = table.Column<string>(nullable: true),
                    College = table.Column<string>(nullable: true),
                    PassOutYear = table.Column<DateTime>(nullable: false),
                    Line1 = table.Column<string>(nullable: true),
                    Line2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    LandMark = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Organization = table.Column<int>(nullable: false),
                    Designation = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    Current = table.Column<bool>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Speciality = table.Column<string>(nullable: true),
                    Expertise = table.Column<string>(nullable: true),
                    ResearchAwards = table.Column<string>(nullable: true),
                    Others = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: false)
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
                name: "IX_BankInformations_DoctorId",
                table: "BankInformations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_FeesAndTimings_DoctorId",
                table: "FeesAndTimings",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MissaleniousDocInfo_DoctorId",
                table: "MissaleniousDocInfo",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankInformations");

            migrationBuilder.DropTable(
                name: "FeesAndTimings");

            migrationBuilder.DropTable(
                name: "MissaleniousDocInfo");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
