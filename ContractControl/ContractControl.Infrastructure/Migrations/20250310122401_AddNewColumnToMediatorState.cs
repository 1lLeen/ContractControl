using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractControl.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnToMediatorState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Mediator",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Mediator");
        }
    }
}
