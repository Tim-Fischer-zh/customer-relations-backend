using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerRelations.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");
        }
    }
}
