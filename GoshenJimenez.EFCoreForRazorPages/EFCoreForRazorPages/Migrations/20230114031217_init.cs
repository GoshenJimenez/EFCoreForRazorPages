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
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00965ecf-acae-46fe-8775-d7834b07fd96"), "Stf", "People who work in school but not teaching", "Staff" },
                    { new Guid("1fb7085a-762f-440c-87de-59f75f85e934"), "Adm", "Admin", "Admin" },
                    { new Guid("1fb7085a-762f-440c-87de-59f75f85e935"), "Std", "People who learn in school", "Student" },
                    { new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d"), "Fct", "People who teach in school", "Faculty" }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "Key", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0eba2a2b-55d7-4423-9cc5-0109eb20a0b7"), "IsActive", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), "true" },
                    { new Guid("33d52442-4554-4dbb-b468-68f2dcb6e4dc"), "LoginRetries", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), "0" },
                    { new Guid("550bca90-ede0-4c47-84a4-332a0f330ee7"), "IsActive", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), "true" },
                    { new Guid("584a815f-3243-4b57-b902-b14a1f48f265"), "LoginRetries", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), "0" },
                    { new Guid("62091306-2013-4d1d-b7a0-a215b1f48d7c"), "Password", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), "$2a$11$uyvSQcY9dawfoS2cWZMyPejVxz8iG32NapPEXEeTGpRRi5Dd27XSq" },
                    { new Guid("72c24816-f32d-4f7f-8824-073007663e6b"), "Password", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), "$2a$11$/SIKSaNDvZTZyfzisN3ZeuDxUFs6NfGDn0mg5EsLWy1H4nc/4u9aK" },
                    { new Guid("8318e258-7292-4386-9b5e-c853e9b8eca8"), "LoginRetries", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), "0" },
                    { new Guid("cc56c16e-3c4e-406d-bb22-9fb7ca1be801"), "IsActive", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), "true" },
                    { new Guid("d3fa581e-e674-48ee-a589-2b59f2d9a71f"), "Password", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), "$2a$11$wVrXuBep6CiMXT7HX3JHMOLnw78eLiaUa8iXSZDPmXmQZT4hHGfE." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), new DateTime(2023, 1, 14, 11, 12, 16, 575, DateTimeKind.Local).AddTicks(6781), "avengeant@mailinator.com", 1, "Ajani", new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), new DateTime(2023, 1, 14, 11, 12, 16, 689, DateTimeKind.Local).AddTicks(3091), "lvess@mailinator.com", 2, "Liliana", new Guid("00965ecf-acae-46fe-8775-d7834b07fd96") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), new DateTime(2023, 1, 14, 11, 12, 16, 804, DateTimeKind.Local).AddTicks(1316), "ktide@mailinator.com", 2, "Kiora", new Guid("1fb7085a-762f-440c-87de-59f75f85e935") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("4a6dde45-2a1a-4c31-8e70-0bf2df844da4"), new Guid("1fb7085a-762f-440c-87de-59f75f85e935"), new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("9ec7711c-3457-4fad-9b34-68f87258fd9b"), new Guid("00965ecf-acae-46fe-8775-d7834b07fd96"), new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("f0fbb9d4-abc3-4666-a775-cbe476b3bb7e"), new Guid("1fb7085a-762f-440c-87de-59f75f85e934"), new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1") });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
