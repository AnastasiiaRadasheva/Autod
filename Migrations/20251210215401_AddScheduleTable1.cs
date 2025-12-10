using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autod.Migrations
{
    /// <inheritdoc />
    public partial class AddScheduleTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Schedules_CarId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_StartTime",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices",
                columns: new[] { "CarId", "ServiceId", "DateOfService" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CarId_StartTime",
                table: "Schedules",
                columns: new[] { "CarId", "StartTime" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ServiceId",
                table: "Schedules",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Services_ServiceId",
                table: "Schedules",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Services_ServiceId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_CarId_StartTime",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_ServiceId",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Schedules");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarServices",
                table: "CarServices",
                columns: new[] { "CarId", "ServiceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CarId",
                table: "Schedules",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StartTime",
                table: "Schedules",
                column: "StartTime",
                unique: true);
        }
    }
}
