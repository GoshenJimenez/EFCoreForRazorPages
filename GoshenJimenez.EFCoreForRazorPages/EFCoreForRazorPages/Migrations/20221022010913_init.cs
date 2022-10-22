using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreForRazorPages.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abbreviation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), new DateTime(2022, 10, 22, 9, 9, 13, 346, DateTimeKind.Local).AddTicks(2244), "avengeant@mailinator.com", 1, "Ajani", new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), new DateTime(2022, 10, 22, 9, 9, 13, 346, DateTimeKind.Local).AddTicks(2256), "lvess@mailinator.com", 2, "Liliana", new Guid("00965ecf-acae-46fe-8775-d7834b07fd96") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), new DateTime(2022, 10, 22, 9, 9, 13, 346, DateTimeKind.Local).AddTicks(2259), "ktide@mailinator.com", 2, "Kiora", new Guid("1fb7085a-762f-440c-87de-59f75f85e935") });

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
