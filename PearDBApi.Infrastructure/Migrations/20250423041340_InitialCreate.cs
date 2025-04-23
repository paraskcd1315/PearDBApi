using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PearDBApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Architecture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architecture", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeviceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceType", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SOC",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    ArchitectureId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ManufacturingProcess = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOC_Architecture_ArchitectureId",
                        column: x => x.ArchitectureId,
                        principalTable: "Architecture",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Key = table.Column<string>(type: "longtext", nullable: false),
                    CpId = table.Column<string>(type: "longtext", nullable: true),
                    Board = table.Column<string>(type: "longtext", nullable: true),
                    BdId = table.Column<string>(type: "longtext", nullable: true),
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
                    PixelsPerInch = table.Column<string>(type: "longtext", nullable: true),
                    ReleasedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeviceTypeId = table.Column<Guid>(type: "char(36)", nullable: false),
                    SocId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ArchitectureId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Device_Architecture_ArchitectureId",
                        column: x => x.ArchitectureId,
                        principalTable: "Architecture",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Device_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Device_SOC_SocId",
                        column: x => x.SocId,
                        principalTable: "SOC",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Device_ArchitectureId",
                table: "Device",
                column: "ArchitectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Device_DeviceTypeId",
                table: "Device",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Device_SocId",
                table: "Device",
                column: "SocId");

            migrationBuilder.CreateIndex(
                name: "IX_SOC_ArchitectureId",
                table: "SOC",
                column: "ArchitectureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "DeviceType");

            migrationBuilder.DropTable(
                name: "SOC");

            migrationBuilder.DropTable(
                name: "Architecture");
        }
    }
}
