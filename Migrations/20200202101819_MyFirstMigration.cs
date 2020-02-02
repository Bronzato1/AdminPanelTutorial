using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPanelTutorial.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Admins",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Specialist = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Health_condition = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Doctor_id = table.Column<int>(nullable: false),
                    Nurse_id = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "patients_ibfk_1",
                        column: x => x.Doctor_id,
                        principalSchema: "dbo",
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "patients_ibfk_2",
                        column: x => x.Nurse_id,
                        principalSchema: "dbo",
                        principalTable: "Nurses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "doctor_id",
                schema: "dbo",
                table: "Patients",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "nurse_id",
                schema: "dbo",
                table: "Patients",
                column: "Nurse_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Patients",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Doctors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Nurses",
                schema: "dbo");
        }
    }
}
