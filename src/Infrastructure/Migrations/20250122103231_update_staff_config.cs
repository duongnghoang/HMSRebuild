using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update_staff_config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Roles_RoleId1",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_RoleId1",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "Staffs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoleId1",
                table: "Staffs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_RoleId1",
                table: "Staffs",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Roles_RoleId1",
                table: "Staffs",
                column: "RoleId1",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
