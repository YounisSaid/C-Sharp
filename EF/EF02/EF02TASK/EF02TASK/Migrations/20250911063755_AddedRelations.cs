using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "Departments",
                newName: "InstructorID");

            migrationBuilder.RenameColumn(
                name: "Top_ID",
                table: "Courses",
                newName: "TopicID");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourseID",
                table: "Topics",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_ID",
                table: "Students",
                column: "Dep_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_ID",
                table: "Students",
                column: "Dep_ID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Courses_CourseID",
                table: "Topics",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_ID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Courses_CourseID",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CourseID",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_ID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Topics");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "Departments",
                newName: "Ins_ID");

            migrationBuilder.RenameColumn(
                name: "TopicID",
                table: "Courses",
                newName: "Top_ID");
        }
    }
}
