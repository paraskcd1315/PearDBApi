﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PearDBApi.Infrastructure.Persistence;

#nullable disable

namespace PearDBApi.Infrastructure.Migrations
{
    [DbContext(typeof(PearDBApiDbContext))]
    [Migration("20250424040009_SeparateDeviceInfo")]
    partial class SeparateDeviceInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PearDBApi.Domain.ArchitectureAggregate.Architecture", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Architecture", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceAggregate.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ArchitectureId")
                        .HasColumnType("char(36)");

                    b.Property<string>("BdId")
                        .HasColumnType("longtext");

                    b.Property<string>("Board")
                        .HasColumnType("longtext");

                    b.Property<string>("CpId")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("DeviceTypeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("ReleasedDate")
                        .HasColumnType("date");

                    b.Property<Guid?>("SocId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ArchitectureId");

                    b.HasIndex("DeviceTypeId");

                    b.HasIndex("SocId");

                    b.ToTable("Device", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoAudioId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoConnectivityId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoCoresId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoDisplayId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoInputId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoMemoryId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoPowerId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeviceInfoSensorsId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("DeviceInfoConnectivityId")
                        .IsUnique();

                    b.HasIndex("DeviceInfoCoresId")
                        .IsUnique();

                    b.HasIndex("DeviceInfoDisplayId")
                        .IsUnique();

                    b.HasIndex("DeviceInfoInputId")
                        .IsUnique();

                    b.HasIndex("DeviceInfoMemoryId")
                        .IsUnique();

                    b.HasIndex("DeviceInfoPowerId")
                        .IsUnique();

                    b.HasIndex("DeviceInfoSensorsId")
                        .IsUnique();

                    b.ToTable("DeviceInfo", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoAudio", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Channels")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<bool?>("DolbyAtmos")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("HeadphoneJack")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Micophone")
                        .HasColumnType("longtext");

                    b.Property<string>("Speakers")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DeviceInfoId")
                        .IsUnique();

                    b.ToTable("DeviceInfoAudio", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoConnectivity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Bluetooth")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("ExternalDisplayCount")
                        .HasColumnType("int");

                    b.Property<string>("Ports")
                        .HasColumnType("longtext");

                    b.Property<string>("Supports")
                        .HasColumnType("longtext");

                    b.Property<string>("WiFi")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoConnectivity", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoCores", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int?>("CPUCoreCount")
                        .HasColumnType("int");

                    b.Property<string>("DataCache")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("EfficiencyCores")
                        .HasColumnType("int");

                    b.Property<string>("GpuCoreCount")
                        .HasColumnType("longtext");

                    b.Property<string>("InstructionCache")
                        .HasColumnType("longtext");

                    b.Property<string>("L2Cache")
                        .HasColumnType("longtext");

                    b.Property<string>("NeuralEngineCoreCount")
                        .HasColumnType("longtext");

                    b.Property<int?>("PerformanceCores")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoCores", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoDisplay", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("ColorGamut")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("PeakBrightness")
                        .HasColumnType("longtext");

                    b.Property<string>("PixelsPerInch")
                        .HasColumnType("longtext");

                    b.Property<bool?>("ProMotion")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshRate")
                        .HasColumnType("longtext");

                    b.Property<int?>("ResolutionX")
                        .HasColumnType("int");

                    b.Property<int?>("ResolutionY")
                        .HasColumnType("int");

                    b.Property<string>("ScreenSize")
                        .HasColumnType("longtext");

                    b.Property<bool?>("TrueTone")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoDisplay", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoInput", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("KeyCount")
                        .HasColumnType("longtext");

                    b.Property<bool?>("TouchBar")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("TouchID")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Trackpad")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoInput", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoMemory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RAM")
                        .HasColumnType("longtext");

                    b.Property<string>("Storage")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoMemory", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoPower", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("BatteryCapacity")
                        .HasColumnType("longtext");

                    b.Property<string>("BatteryLife")
                        .HasColumnType("longtext");

                    b.Property<string>("Charger")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoPower", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoSensors", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Biometrics")
                        .HasColumnType("longtext");

                    b.Property<string>("Camera")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DeviceInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Microphone")
                        .HasColumnType("longtext");

                    b.Property<string>("OtherSensors")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeviceInfoSensors", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceTypeAggregate.DeviceType", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeviceType", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.SOCAggregate.Soc", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ArchitectureId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ManufacturingProcess")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArchitectureId");

                    b.ToTable("SOC", (string)null);
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceAggregate.Device", b =>
                {
                    b.HasOne("PearDBApi.Domain.ArchitectureAggregate.Architecture", "Architecture")
                        .WithMany()
                        .HasForeignKey("ArchitectureId");

                    b.HasOne("PearDBApi.Domain.DeviceTypeAggregate.DeviceType", "DeviceType")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PearDBApi.Domain.SOCAggregate.Soc", "Soc")
                        .WithMany()
                        .HasForeignKey("SocId");

                    b.Navigation("Architecture");

                    b.Navigation("DeviceType");

                    b.Navigation("Soc");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", b =>
                {
                    b.HasOne("PearDBApi.Domain.DeviceAggregate.Device", "Device")
                        .WithMany("DeviceInfo")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoConnectivity", "DeviceInfoConnectivity")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoConnectivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoCores", "DeviceInfoCores")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoCoresId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoDisplay", "DeviceInfoDisplay")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoDisplayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoInput", "DeviceInfoInput")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoInputId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoMemory", "DeviceInfoMemory")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoMemoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoPower", "DeviceInfoPower")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoPowerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoSensors", "DeviceInfoSensors")
                        .WithOne("DeviceInfo")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfoSensorsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Device");

                    b.Navigation("DeviceInfoConnectivity");

                    b.Navigation("DeviceInfoCores");

                    b.Navigation("DeviceInfoDisplay");

                    b.Navigation("DeviceInfoInput");

                    b.Navigation("DeviceInfoMemory");

                    b.Navigation("DeviceInfoPower");

                    b.Navigation("DeviceInfoSensors");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoAudio", b =>
                {
                    b.HasOne("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", "DeviceInfo")
                        .WithOne("DeviceInfoAudio")
                        .HasForeignKey("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoAudio", "DeviceInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.SOCAggregate.Soc", b =>
                {
                    b.HasOne("PearDBApi.Domain.ArchitectureAggregate.Architecture", "Architecture")
                        .WithMany()
                        .HasForeignKey("ArchitectureId");

                    b.Navigation("Architecture");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceAggregate.Device", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfo", b =>
                {
                    b.Navigation("DeviceInfoAudio");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoConnectivity", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoCores", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoDisplay", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoInput", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoMemory", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoPower", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials.DeviceInfoSensors", b =>
                {
                    b.Navigation("DeviceInfo");
                });

            modelBuilder.Entity("PearDBApi.Domain.DeviceTypeAggregate.DeviceType", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
