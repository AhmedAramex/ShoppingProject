using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureCQRs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "wishLists");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "wishLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
