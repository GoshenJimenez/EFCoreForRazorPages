using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreForRazorPages.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[] { new Guid("00965ecf-acae-46fe-8775-d7834b07fd96"), "Stf", "People who work in school but not teaching", "Staff" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[] { new Guid("1fb7085a-762f-440c-87de-59f75f85e935"), "Std", "People who learn in school", "Student" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[] { new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d"), "Fct", "People who teach in school", "Faculty" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), new DateTime(2022, 11, 5, 9, 26, 7, 790, DateTimeKind.Local).AddTicks(2075), "avengeant@mailinator.com", 1, "Ajani", new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), new DateTime(2022, 11, 5, 9, 26, 7, 790, DateTimeKind.Local).AddTicks(2086), "lvess@mailinator.com", 2, "Liliana", new Guid("00965ecf-acae-46fe-8775-d7834b07fd96") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), new DateTime(2022, 11, 5, 9, 26, 7, 790, DateTimeKind.Local).AddTicks(2088), "ktide@mailinator.com", 2, "Kiora", new Guid("1fb7085a-762f-440c-87de-59f75f85e935") });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
