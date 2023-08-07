using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coobrates_Students_StudentId",
                table: "Coobrates");

            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_Students_StudentId",
                table: "Individuals");

            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Individuals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Coobrates",
                newName: "Id");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Sections",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Sections",
                type: "time",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coobrates_Students_Id",
                table: "Coobrates",
                column: "Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_Students_Id",
                table: "Individuals",
                column: "Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coobrates_Students_Id",
                table: "Coobrates");

            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_Students_Id",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Individuals",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Coobrates",
                newName: "StudentId");

            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.SectionId);
                    table.ForeignKey(
                        name: "FK_TimeSlots_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Coobrates_Students_StudentId",
                table: "Coobrates",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_Students_StudentId",
                table: "Individuals",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
