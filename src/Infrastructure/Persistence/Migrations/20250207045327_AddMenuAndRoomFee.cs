using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuAndRoomFee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Permissions_ParentPermissionId",
                table: "Permissions");

            migrationBuilder.CreateTable(
                name: "FeePolicies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeePolicies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IConName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNumber = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsPresentInSideBar = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsAllowAnonymous = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DayFees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeePolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CheckInAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckOutAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdultAdditionalFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ChildAdditionalFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsResideIn24h = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayFees_FeePolicies_FeePolicyId",
                        column: x => x.FeePolicyId,
                        principalTable: "FeePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HourFees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeePolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourFees_FeePolicies_FeePolicyId",
                        column: x => x.FeePolicyId,
                        principalTable: "FeePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonthFees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WhenToCalculate = table.Column<bool>(type: "bit", nullable: false),
                    FeePolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthFees_FeePolicies_FeePolicyId",
                        column: x => x.FeePolicyId,
                        principalTable: "FeePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NightFees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckOut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeePolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NightFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NightFees_FeePolicies_FeePolicyId",
                        column: x => x.FeePolicyId,
                        principalTable: "FeePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeekFees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeePolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeekFees_FeePolicies_FeePolicyId",
                        column: x => x.FeePolicyId,
                        principalTable: "FeePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenus",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenus", x => new { x.RoleId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_RoleMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenus_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HourFeePrices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HourFeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourFeePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourFeePrices_HourFees_HourFeeId",
                        column: x => x.HourFeeId,
                        principalTable: "HourFees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PunishFee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayFeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NightFeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NumOfHour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCheckInEarlyOrCheckOutLate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunishFee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PunishFee_DayFees_DayFeeId",
                        column: x => x.DayFeeId,
                        principalTable: "DayFees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PunishFee_NightFees_NightFeeId",
                        column: x => x.NightFeeId,
                        principalTable: "NightFees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayFees_FeePolicyId",
                table: "DayFees",
                column: "FeePolicyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HourFeePrices_HourFeeId",
                table: "HourFeePrices",
                column: "HourFeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HourFees_FeePolicyId",
                table: "HourFees",
                column: "FeePolicyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentId",
                table: "Menus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthFees_FeePolicyId",
                table: "MonthFees",
                column: "FeePolicyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NightFees_FeePolicyId",
                table: "NightFees",
                column: "FeePolicyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PunishFee_DayFeeId",
                table: "PunishFee",
                column: "DayFeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PunishFee_NightFeeId",
                table: "PunishFee",
                column: "NightFeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenus_MenuId",
                table: "RoleMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekFees_FeePolicyId",
                table: "WeekFees",
                column: "FeePolicyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Permissions_ParentPermissionId",
                table: "Permissions",
                column: "ParentPermissionId",
                principalTable: "Permissions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Permissions_ParentPermissionId",
                table: "Permissions");

            migrationBuilder.DropTable(
                name: "HourFeePrices");

            migrationBuilder.DropTable(
                name: "MonthFees");

            migrationBuilder.DropTable(
                name: "PunishFee");

            migrationBuilder.DropTable(
                name: "RoleMenus");

            migrationBuilder.DropTable(
                name: "WeekFees");

            migrationBuilder.DropTable(
                name: "HourFees");

            migrationBuilder.DropTable(
                name: "DayFees");

            migrationBuilder.DropTable(
                name: "NightFees");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "FeePolicies");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Permissions_ParentPermissionId",
                table: "Permissions",
                column: "ParentPermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
