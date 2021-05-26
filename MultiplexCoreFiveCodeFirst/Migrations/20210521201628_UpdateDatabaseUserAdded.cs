using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiplexCoreFiveCodeFirst.Migrations
{
    public partial class UpdateDatabaseUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "Country");
        }
    }
}
