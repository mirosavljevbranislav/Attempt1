using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirt.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPKForSubjectStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectStudentId",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectStudentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubjectStudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectStudent", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectStudentId",
                table: "Subject",
                column: "SubjectStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectStudentId",
                table: "Students",
                column: "SubjectStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SubjectStudent_SubjectStudentId",
                table: "Students",
                column: "SubjectStudentId",
                principalTable: "SubjectStudent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_SubjectStudent_SubjectStudentId",
                table: "Subject",
                column: "SubjectStudentId",
                principalTable: "SubjectStudent",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_SubjectStudent_SubjectStudentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_SubjectStudent_SubjectStudentId",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "SubjectStudent");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SubjectStudentId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubjectStudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SubjectStudentId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SubjectStudentId",
                table: "Students");
        }
    }
}
