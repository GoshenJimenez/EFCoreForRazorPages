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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00965ecf-acae-46fe-8775-d7834b07fd96"), "Stf", "People who work in school but not teaching", "Staff" },
                    { new Guid("1fb7085a-762f-440c-87de-59f75f85e935"), "Std", "People who learn in school", "Student" },
                    { new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d"), "Fct", "People who teach in school", "Faculty" }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "Key", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("06be8cb4-02de-4ab1-b574-49e017f5b255"), "Password", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), "$2a$11$.yd9h52TEt7R/Yi4ten5y.AkYhkQACzGTda18xpQt0j3vg2I0VXoK" },
                    { new Guid("11a37b16-c08f-40b6-bb2b-402fe0540d2b"), "LoginRetries", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), "0" },
                    { new Guid("2a1ba526-1cf0-4672-8a9b-0dec239eb31c"), "IsActive", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), "true" },
                    { new Guid("3b39a47d-2d91-4f7d-9fe5-e355c0f02b23"), "Password", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), "$2a$11$hI.W3KNJb2Vh2dknAr94luGYJK/bHO5DjmVBUWPOgokuiDGxVFD3O" },
                    { new Guid("7b2b9f86-2dfd-442f-b859-0746e6fb6ca6"), "LoginRetries", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), "0" },
                    { new Guid("869de353-8700-4fa7-a305-23be87620815"), "LoginRetries", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), "0" },
                    { new Guid("8e147fd8-4606-4420-a69c-56ac9e7c92ab"), "Password", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), "$2a$11$rcJcAXC43E88gnsl0kwssOntWGgyCR/hfg.C8QJjut8CDgH0lXrPS" },
                    { new Guid("bed461fb-3563-46fc-9071-53f01bf6a311"), "IsActive", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), "true" },
                    { new Guid("c6ea7aa9-e127-4c48-ab51-380422dc16a3"), "IsActive", "General", new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), "true" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"), new DateTime(2023, 1, 7, 10, 17, 6, 340, DateTimeKind.Local).AddTicks(651), "avengeant@mailinator.com", 1, "Ajani", new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"), new DateTime(2023, 1, 7, 10, 17, 6, 458, DateTimeKind.Local).AddTicks(2468), "lvess@mailinator.com", 2, "Liliana", new Guid("00965ecf-acae-46fe-8775-d7834b07fd96") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EmailAddress", "Gender", "Name", "RoleId" },
                values: new object[] { new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"), new DateTime(2023, 1, 7, 10, 17, 6, 578, DateTimeKind.Local).AddTicks(7146), "ktide@mailinator.com", 2, "Kiora", new Guid("1fb7085a-762f-440c-87de-59f75f85e935") });

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
