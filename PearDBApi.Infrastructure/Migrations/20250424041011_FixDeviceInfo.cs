using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearDBApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDeviceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoConnectivity_DeviceInfoConnectivityId",
                table: "DeviceInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoCores_DeviceInfoCoresId",
                table: "DeviceInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoDisplay_DeviceInfoDisplayId",
                table: "DeviceInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoInput_DeviceInfoInputId",
                table: "DeviceInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoMemory_DeviceInfoMemoryId",
                table: "DeviceInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoPower_DeviceInfoPowerId",
                table: "DeviceInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfo_DeviceInfoSensors_DeviceInfoSensorsId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoConnectivityId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoCoresId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoDisplayId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoInputId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoMemoryId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoPowerId",
                table: "DeviceInfo");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfo_DeviceInfoSensorsId",
                table: "DeviceInfo");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoSensors_DeviceInfoId",
                table: "DeviceInfoSensors",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoPower_DeviceInfoId",
                table: "DeviceInfoPower",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoMemory_DeviceInfoId",
                table: "DeviceInfoMemory",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoInput_DeviceInfoId",
                table: "DeviceInfoInput",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoDisplay_DeviceInfoId",
                table: "DeviceInfoDisplay",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoCores_DeviceInfoId",
                table: "DeviceInfoCores",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoConnectivity_DeviceInfoId",
                table: "DeviceInfoConnectivity",
                column: "DeviceInfoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoConnectivity_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoConnectivity",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoCores_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoCores",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoDisplay_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoDisplay",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoInput_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoInput",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoMemory_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoMemory",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoPower_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoPower",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfoSensors_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoSensors",
                column: "DeviceInfoId",
                principalTable: "DeviceInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoConnectivity_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoConnectivity");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoCores_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoCores");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoDisplay_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoDisplay");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoInput_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoInput");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoMemory_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoMemory");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoPower_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoPower");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceInfoSensors_DeviceInfo_DeviceInfoId",
                table: "DeviceInfoSensors");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoSensors_DeviceInfoId",
                table: "DeviceInfoSensors");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoPower_DeviceInfoId",
                table: "DeviceInfoPower");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoMemory_DeviceInfoId",
                table: "DeviceInfoMemory");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoInput_DeviceInfoId",
                table: "DeviceInfoInput");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoDisplay_DeviceInfoId",
                table: "DeviceInfoDisplay");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoCores_DeviceInfoId",
                table: "DeviceInfoCores");

            migrationBuilder.DropIndex(
                name: "IX_DeviceInfoConnectivity_DeviceInfoId",
                table: "DeviceInfoConnectivity");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoConnectivityId",
                table: "DeviceInfo",
                column: "DeviceInfoConnectivityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoCoresId",
                table: "DeviceInfo",
                column: "DeviceInfoCoresId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoDisplayId",
                table: "DeviceInfo",
                column: "DeviceInfoDisplayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoInputId",
                table: "DeviceInfo",
                column: "DeviceInfoInputId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoMemoryId",
                table: "DeviceInfo",
                column: "DeviceInfoMemoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoPowerId",
                table: "DeviceInfo",
                column: "DeviceInfoPowerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfo_DeviceInfoSensorsId",
                table: "DeviceInfo",
                column: "DeviceInfoSensorsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoConnectivity_DeviceInfoConnectivityId",
                table: "DeviceInfo",
                column: "DeviceInfoConnectivityId",
                principalTable: "DeviceInfoConnectivity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoCores_DeviceInfoCoresId",
                table: "DeviceInfo",
                column: "DeviceInfoCoresId",
                principalTable: "DeviceInfoCores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoDisplay_DeviceInfoDisplayId",
                table: "DeviceInfo",
                column: "DeviceInfoDisplayId",
                principalTable: "DeviceInfoDisplay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoInput_DeviceInfoInputId",
                table: "DeviceInfo",
                column: "DeviceInfoInputId",
                principalTable: "DeviceInfoInput",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoMemory_DeviceInfoMemoryId",
                table: "DeviceInfo",
                column: "DeviceInfoMemoryId",
                principalTable: "DeviceInfoMemory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoPower_DeviceInfoPowerId",
                table: "DeviceInfo",
                column: "DeviceInfoPowerId",
                principalTable: "DeviceInfoPower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceInfo_DeviceInfoSensors_DeviceInfoSensorsId",
                table: "DeviceInfo",
                column: "DeviceInfoSensorsId",
                principalTable: "DeviceInfoSensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
