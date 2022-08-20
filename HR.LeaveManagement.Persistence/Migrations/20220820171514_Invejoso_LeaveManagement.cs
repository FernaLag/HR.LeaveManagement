using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    public partial class Invejoso_LeaveManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocation",
                table: "LeaveAllocation");

            migrationBuilder.RenameTable(
                name: "LeaveAllocation",
                newName: "LeaveAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocation_LeaveTypeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                newName: "LeaveAllocation");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocation",
                newName: "IX_LeaveAllocation_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocation",
                table: "LeaveAllocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocation_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocation",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
