using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenProfileAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAIRelatedFieldsinMessageTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AIToolId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AIToolModelId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AIToolId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "AIToolModelId",
                table: "Message");
        }
    }
}
