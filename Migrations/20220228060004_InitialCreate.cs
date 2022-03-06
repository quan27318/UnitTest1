using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person Class",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(name: "Student Name", type: "ntext", maxLength: 200, nullable: false),
                    Age = table.Column<string>(type: "ntext", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "ntext", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person Class", x => x.StudentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person Class");
        }
    }
}
