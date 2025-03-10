using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractControl.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnsMediators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mediator_Companies_ComapnyId",
                table: "Mediator");

            migrationBuilder.DropForeignKey(
                name: "FK_Mediator_Contracts_ContractId",
                table: "Mediator");

            migrationBuilder.RenameColumn(
                name: "ContractId",
                table: "Mediator",
                newName: "ToComapnyId");

            migrationBuilder.RenameColumn(
                name: "ComapnyId",
                table: "Mediator",
                newName: "FromComapnyId");

            migrationBuilder.RenameIndex(
                name: "IX_Mediator_ContractId",
                table: "Mediator",
                newName: "IX_Mediator_ToComapnyId");

            migrationBuilder.RenameIndex(
                name: "IX_Mediator_ComapnyId",
                table: "Mediator",
                newName: "IX_Mediator_FromComapnyId");

            migrationBuilder.AddColumn<int>(
                name: "MediatorModelId",
                table: "Contracts",
                type: "integer",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_Contracts_MediatorModelId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "MediatorModelId",
                table: "Contracts");

            migrationBuilder.RenameColumn(
                name: "ToComapnyId",
                table: "Mediator",
                newName: "ContractId");

            migrationBuilder.RenameColumn(
                name: "FromComapnyId",
                table: "Mediator",
                newName: "ComapnyId");

            migrationBuilder.RenameIndex(
                name: "IX_Mediator_ToComapnyId",
                table: "Mediator",
                newName: "IX_Mediator_ContractId");

            migrationBuilder.RenameIndex(
                name: "IX_Mediator_FromComapnyId",
                table: "Mediator",
                newName: "IX_Mediator_ComapnyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mediator_Companies_ComapnyId",
                table: "Mediator",
                column: "ComapnyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mediator_Contracts_ContractId",
                table: "Mediator",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id");
        }
    }
}
