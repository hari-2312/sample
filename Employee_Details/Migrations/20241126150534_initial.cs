using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Details.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_Register",
                columns: table => new
                {
                    Emp_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emp_phone = table.Column<int>(type: "int", nullable: false),
                    Emp_dep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Register", x => x.Emp_no);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Register");
        }
    }
}
