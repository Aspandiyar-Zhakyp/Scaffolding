using Microsoft.EntityFrameworkCore.Migrations;

namespace ScaffoldingMigrationHometask.Migrations
{
    public partial class AgeCountryPopularityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "Authors");
        }
    }
}
