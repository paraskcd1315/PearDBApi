using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearDBApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeparateDeviceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryCapacity",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "BatteryLife",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Biometrics",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Bluetooth",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "CPUCoreCount",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Camera",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Channels",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Charger",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "ColorGamut",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DataCache",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DolbyAtmos",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "EfficiencyCores",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "ExternalDisplayCount",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "GpuCoreCount",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "HeadphoneJack",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "InstructionCache",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "KeyCount",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "L2Cache",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Micophone",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Microphone",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "NeuralEngineCoreCount",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "OtherSensors",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "PeakBrightness",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "PerformanceCores",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "PixelsPerInch",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Ports",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "ProMotion",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "RAM",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "RefreshRate",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "ResolutionX",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "ResolutionY",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "ScreenSize",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Speakers",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Supports",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "TouchBar",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "TouchID",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "Trackpad",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "TrueTone",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "WiFi",
                table: "DeviceInfo");

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoAudioId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoConnectivityId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoCoresId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoDisplayId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoInputId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoMemoryId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoPowerId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeviceInfoSensorsId",
                table: "DeviceInfo",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DeviceInfoAudio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Speakers = table.Column<string>(type: "longtext", nullable: true),
                    Micophone = table.Column<string>(type: "longtext", nullable: true),
                    Channels = table.Column<string>(type: "longtext", nullable: true),
                    DolbyAtmos = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HeadphoneJack = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoAudio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceInfoAudio_DeviceInfo_DeviceInfoId",
                        column: x => x.DeviceInfoId,
                        principalTable: "DeviceInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoConnectivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    WiFi = table.Column<string>(type: "longtext", nullable: true),
                    Bluetooth = table.Column<string>(type: "longtext", nullable: true),
                    ExternalDisplayCount = table.Column<int>(type: "int", nullable: true),
                    Supports = table.Column<string>(type: "longtext", nullable: true),
                    Ports = table.Column<string>(type: "longtext", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoConnectivity", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoCores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CPUCoreCount = table.Column<int>(type: "int", nullable: true),
                    PerformanceCores = table.Column<int>(type: "int", nullable: true),
                    EfficiencyCores = table.Column<int>(type: "int", nullable: true),
                    InstructionCache = table.Column<string>(type: "longtext", nullable: true),
                    DataCache = table.Column<string>(type: "longtext", nullable: true),
                    L2Cache = table.Column<string>(type: "longtext", nullable: true),
                    GpuCoreCount = table.Column<string>(type: "longtext", nullable: true),
                    NeuralEngineCoreCount = table.Column<string>(type: "longtext", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoCores", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoDisplay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ResolutionX = table.Column<int>(type: "int", nullable: true),
                    ResolutionY = table.Column<int>(type: "int", nullable: true),
                    ScreenSize = table.Column<string>(type: "longtext", nullable: true),
                    RefreshRate = table.Column<string>(type: "longtext", nullable: true),
                    PeakBrightness = table.Column<string>(type: "longtext", nullable: true),
                    ColorGamut = table.Column<string>(type: "longtext", nullable: true),
                    TrueTone = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ProMotion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    PixelsPerInch = table.Column<string>(type: "longtext", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoDisplay", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoInput",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    KeyCount = table.Column<string>(type: "longtext", nullable: true),
                    Trackpad = table.Column<string>(type: "longtext", nullable: true),
                    TouchBar = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TouchID = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoInput", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoMemory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    RAM = table.Column<string>(type: "longtext", nullable: true),
                    Storage = table.Column<string>(type: "longtext", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoMemory", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoPower",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    BatteryCapacity = table.Column<string>(type: "longtext", nullable: true),
                    BatteryLife = table.Column<string>(type: "longtext", nullable: true),
                    Charger = table.Column<string>(type: "longtext", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoPower", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceInfoSensors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Camera = table.Column<string>(type: "longtext", nullable: true),
                    Biometrics = table.Column<string>(type: "longtext", nullable: true),
                    Microphone = table.Column<string>(type: "longtext", nullable: true),
                    OtherSensors = table.Column<string>(type: "longtext", nullable: true),
                    DeviceInfoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfoSensors", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_DeviceInfoAudio_DeviceInfoId",
                table: "DeviceInfoAudio",
                column: "DeviceInfoId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "DeviceInfoAudio");

            migrationBuilder.DropTable(
                name: "DeviceInfoConnectivity");

            migrationBuilder.DropTable(
                name: "DeviceInfoCores");

            migrationBuilder.DropTable(
                name: "DeviceInfoDisplay");

            migrationBuilder.DropTable(
                name: "DeviceInfoInput");

            migrationBuilder.DropTable(
                name: "DeviceInfoMemory");

            migrationBuilder.DropTable(
                name: "DeviceInfoPower");

            migrationBuilder.DropTable(
                name: "DeviceInfoSensors");

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

            migrationBuilder.DropColumn(
                name: "DeviceInfoAudioId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoConnectivityId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoCoresId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoDisplayId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoInputId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoMemoryId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoPowerId",
                table: "DeviceInfo");

            migrationBuilder.DropColumn(
                name: "DeviceInfoSensorsId",
                table: "DeviceInfo");

            migrationBuilder.AddColumn<string>(
                name: "BatteryCapacity",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BatteryLife",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Biometrics",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bluetooth",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CPUCoreCount",
                table: "DeviceInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Camera",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Channels",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Charger",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorGamut",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataCache",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DolbyAtmos",
                table: "DeviceInfo",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EfficiencyCores",
                table: "DeviceInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExternalDisplayCount",
                table: "DeviceInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GpuCoreCount",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HeadphoneJack",
                table: "DeviceInfo",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstructionCache",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyCount",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "L2Cache",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Micophone",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Microphone",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NeuralEngineCoreCount",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherSensors",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PeakBrightness",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceCores",
                table: "DeviceInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PixelsPerInch",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ports",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ProMotion",
                table: "DeviceInfo",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RAM",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshRate",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResolutionX",
                table: "DeviceInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResolutionY",
                table: "DeviceInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScreenSize",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speakers",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supports",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TouchBar",
                table: "DeviceInfo",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TouchID",
                table: "DeviceInfo",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trackpad",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrueTone",
                table: "DeviceInfo",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WiFi",
                table: "DeviceInfo",
                type: "longtext",
                nullable: true);
        }
    }
}
