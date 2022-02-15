using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbEntityL1.Migrations
{
    public partial class SecoundPhase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Human");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Human",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Human",
                newName: "nationalityId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Human",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Human",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Human",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Human",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Human",
                table: "Human",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Human_nationalityId",
                table: "Human",
                column: "nationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Human_Nationality_nationalityId",
                table: "Human",
                column: "nationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Human_Nationality_nationalityId",
                table: "Human");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Human",
                table: "Human");

            migrationBuilder.DropIndex(
                name: "IX_Human_nationalityId",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Human");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Human");

            migrationBuilder.RenameTable(
                name: "Human",
                newName: "students");

            migrationBuilder.RenameColumn(
                name: "nationalityId",
                table: "students",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "students",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");
        }
    }
}
