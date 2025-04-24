using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearDBApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditDeviceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceInfoDevice");

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceId",
                table: "DeviceInfo",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_Device_DeviceId",
                table: "DeviceInfo",
                column: "DeviceId",
                principalTable: "Device",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_Device_DeviceId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "DeviceInfo");

            migrationBuilder.CreateTable(
                name: "DeviceInfoDevice",
                columns: table => new
                {
                    DeviceId = table.Column<Guid>(type: "char(36)", nullable: false),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoDevice", x => new { x.DeviceId, x.DeviceInfoId });
                    table.ForeignKey(
                        name: "FK_DeviceInfoDevice_DeviceInfo_DeviceInfoId",
                        column: x => x.DeviceInfoId,
                        principalTable: "DeviceInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceInfoDevice_Device_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Device",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoDevice_DeviceInfoId",
                table: "DeviceInfoDevice",
                column: "DeviceInfoId");
        }
    }
}
