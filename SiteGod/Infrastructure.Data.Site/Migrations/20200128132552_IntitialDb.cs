using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.App.Migrations
{
    public partial class IntitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TemporaryEmail = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    ActiveMobile = table.Column<bool>(nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    Study = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ActiveCode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserAvatar = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
