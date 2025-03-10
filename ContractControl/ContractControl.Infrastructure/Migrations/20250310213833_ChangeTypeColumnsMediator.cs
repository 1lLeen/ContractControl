using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractControl.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeColumnsMediator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Mediator_MediatorModelId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Mediator_Companies_FromComapnyId",
                table: "Mediator");

            migrationBuilder.DropForeignKey(
                name: "FK_Mediator_Companies_ToComapnyId",
                table: "Mediator");

            migrationBuilder.DropIndex(
                name: "IX_Mediator_FromComapnyId",
                table: "Mediator");

            migrationBuilder.DropIndex(
                name: "IX_Mediator_ToComapnyId",
                table: "Mediator");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_MediatorModelId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "MediatorModelId",
                table: "Contracts");

            migrationBuilder.RenameColumn(
                name: "ToComapnyId",
                table: "Mediator",
                newName: "ToCompanyId");

            migrationBuilder.RenameColumn(
                name: "FromComapnyId",
                table: "Mediator",
                newName: "FromCompanyId");

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Mediator",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Mediator");

            migrationBuilder.RenameColumn(
                name: "ToCompanyId",
                table: "Mediator",
                newName: "ToComapnyId");

            migrationBuilder.RenameColumn(
                name: "FromCompanyId",
                table: "Mediator",
                newName: "FromComapnyId");

            migrationBuilder.AddColumn<int>(
                name: "MediatorModelId",
                table: "Contracts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mediator_FromComapnyId",
                table: "Mediator",
                column: "FromComapnyId");

            migrationBuilder.CreateIndex(
                name: "IX_Mediator_ToComapnyId",
                table: "Mediator",
                column: "ToComapnyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_MediatorModelId",
                table: "Contracts",
                column: "MediatorModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Mediator_MediatorModelId",
                table: "Contracts",
                column: "MediatorModelId",
                principalTable: "Mediator",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mediator_Companies_FromComapnyId",
                table: "Mediator",
                column: "FromComapnyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mediator_Companies_ToComapnyId",
                table: "Mediator",
                column: "ToComapnyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
