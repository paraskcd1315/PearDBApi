using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearDBApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDeviceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryCapacity",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "BatteryLife",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Biometrics",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Bluetooth",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "CPUCoreCount",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Camera",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Channels",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Charger",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ColorGamut",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "DataCache",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "DolbyAtmos",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "EfficiencyCores",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ExternalDisplayCount",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "GpuCoreCount",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "HeadphoneJack",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "InstructionCache",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "KeyCount",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "L2Cache",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Micophone",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Microphone",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "NeuralEngineCoreCount",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "OtherSensors",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "PeakBrightness",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "PerformanceCores",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "PixelsPerInch",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Ports",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ProMotion",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "RAM",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "RefreshRate",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ResolutionX",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ResolutionY",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ScreenSize",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Speakers",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Supports",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "TouchBar",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "TouchID",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Trackpad",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "TrueTone",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "WiFi",
                table: "Device");

            migrationBuilder.CreateTable(
                name: "DeviceInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CPUCoreCount = table.Column<int>(type: "int", nullable: true),
                    PerformanceCores = table.Column<int>(type: "int", nullable: true),
                    EfficiencyCores = table.Column<int>(type: "int", nullable: true),
                    InstructionCache = table.Column<string>(type: "longtext", nullable: true),
                    DataCache = table.Column<string>(type: "longtext", nullable: true),
                    L2Cache = table.Column<string>(type: "longtext", nullable: true),
                    GpuCoreCount = table.Column<string>(type: "longtext", nullable: true),
                    NeuralEngineCoreCount = table.Column<string>(type: "longtext", nullable: true),
                    RAM = table.Column<string>(type: "longtext", nullable: true),
                    Storage = table.Column<string>(type: "longtext", nullable: true),
                    BatteryCapacity = table.Column<string>(type: "longtext", nullable: true),
                    BatteryLife = table.Column<string>(type: "longtext", nullable: true),
                    Charger = table.Column<string>(type: "longtext", nullable: true),
                    WiFi = table.Column<string>(type: "longtext", nullable: true),
                    Bluetooth = table.Column<string>(type: "longtext", nullable: true),
                    ExternalDisplayCount = table.Column<int>(type: "int", nullable: true),
                    Supports = table.Column<string>(type: "longtext", nullable: true),
                    Ports = table.Column<string>(type: "longtext", nullable: true),
                    Camera = table.Column<string>(type: "longtext", nullable: true),
                    Biometrics = table.Column<string>(type: "longtext", nullable: true),
                    Microphone = table.Column<string>(type: "longtext", nullable: true),
                    OtherSensors = table.Column<string>(type: "longtext", nullable: true),
                    Speakers = table.Column<string>(type: "longtext", nullable: true),
                    Micophone = table.Column<string>(type: "longtext", nullable: true),
                    Channels = table.Column<string>(type: "longtext", nullable: true),
                    DolbyAtmos = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    HeadphoneJack = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    KeyCount = table.Column<string>(type: "longtext", nullable: true),
                    Trackpad = table.Column<string>(type: "longtext", nullable: true),
                    TouchBar = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TouchID = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ResolutionX = table.Column<int>(type: "int", nullable: true),
                    ResolutionY = table.Column<int>(type: "int", nullable: true),
                    ScreenSize = table.Column<string>(type: "longtext", nullable: true),
                    RefreshRate = table.Column<string>(type: "longtext", nullable: true),
                    PeakBrightness = table.Column<string>(type: "longtext", nullable: true),
                    ColorGamut = table.Column<string>(type: "longtext", nullable: true),
                    TrueTone = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ProMotion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    PixelsPerInch = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfo", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceInfoDevice");

            migrationBuilder.DropTable(
                name: "DeviceInfo");

            migrationBuilder.AddColumn<string>(
                name: "BatteryCapacity",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BatteryLife",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Biometrics",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bluetooth",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CPUCoreCount",
                table: "Device",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Camera",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Channels",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Charger",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorGamut",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataCache",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DolbyAtmos",
                table: "Device",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EfficiencyCores",
                table: "Device",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExternalDisplayCount",
                table: "Device",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GpuCoreCount",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HeadphoneJack",
                table: "Device",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstructionCache",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyCount",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "L2Cache",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Micophone",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Microphone",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NeuralEngineCoreCount",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherSensors",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PeakBrightness",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceCores",
                table: "Device",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PixelsPerInch",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ports",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ProMotion",
                table: "Device",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RAM",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshRate",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResolutionX",
                table: "Device",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResolutionY",
                table: "Device",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScreenSize",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speakers",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supports",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TouchBar",
                table: "Device",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TouchID",
                table: "Device",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trackpad",
                table: "Device",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrueTone",
                table: "Device",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WiFi",
                table: "Device",
                type: "longtext",
                nullable: true);
        }
    }
}
