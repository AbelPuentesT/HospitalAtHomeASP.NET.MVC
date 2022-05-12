using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAtHome.App.Model.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VitalSigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalSigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Around = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuggestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Suggestions_SuggestionId",
                        column: x => x.SuggestionId,
                        principalTable: "Suggestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionalCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingHours = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DesignatedFamilyMemberId = table.Column<int>(type: "int", nullable: true),
                    MedicalId = table.Column<int>(type: "int", nullable: true),
                    MedicalRecordId = table.Column<int>(type: "int", nullable: true),
                    VitalSignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Persons_DesignatedFamilyMemberId",
                        column: x => x.DesignatedFamilyMemberId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Persons_MedicalId",
                        column: x => x.MedicalId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_VitalSigns_VitalSignId",
                        column: x => x.VitalSignId,
                        principalTable: "VitalSigns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_SuggestionId",
                table: "MedicalRecords",
                column: "SuggestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DesignatedFamilyMemberId",
                table: "Persons",
                column: "DesignatedFamilyMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Id",
                table: "Persons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MedicalId",
                table: "Persons",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MedicalRecordId",
                table: "Persons",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_VitalSignId",
                table: "Persons",
                column: "VitalSignId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "VitalSigns");

            migrationBuilder.DropTable(
                name: "Suggestions");
        }
    }
}
