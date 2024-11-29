﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHub.DB;

#nullable disable

namespace SmartHub.DB.Migrations
{
    [DbContext(typeof(SmartHubAPIContext))]
    [Migration("20241024232447_UserRolesMigration")]
    partial class UserRolesMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LogoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Domain.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotosJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Devices", (string)null);

                    b.HasDiscriminator<string>("DeviceType").HasValue("Device");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Hardware", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<Guid>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Online")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("HomeId");

                    b.ToTable("Hardwares", (string)null);

                    b.HasDiscriminator<string>("HardwareType").HasValue("Hardware");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Home", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaxMembers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("Domain.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Event")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HardwareId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Seen")
                        .HasColumnType("bit");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HardwareId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Domain.NotificationMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("UserId");

                    b.ToTable("NotificationMembers");
                });

            modelBuilder.Entity("Domain.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("Domain.SessionUser", b =>
                {
                    b.Property<Guid>("Token")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolesJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.UserHomePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PermissionsJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserHomePermissions");
                });

            modelBuilder.Entity("PermissionUser", b =>
                {
                    b.Property<Guid>("PermissionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PermissionsId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions", (string)null);
                });

            modelBuilder.Entity("Domain.SecurityCam", b =>
                {
                    b.HasBaseType("Domain.Device");

                    b.Property<string>("CamSupportedActionsJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CamSupportedActionsJson");

                    b.Property<string>("UseTypeJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UseTypeJson");

                    b.HasDiscriminator().HasValue("SecurityCam");
                });

            modelBuilder.Entity("Domain.SmartLampHardware", b =>
                {
                    b.HasBaseType("Domain.Hardware");

                    b.Property<bool>("IsOn")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("SmartLamp");
                });

            modelBuilder.Entity("Domain.WindowSensorHardware", b =>
                {
                    b.HasBaseType("Domain.Hardware");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("WindowSensor");
                });

            modelBuilder.Entity("Domain.Company", b =>
                {
                    b.HasOne("Domain.User", "Owner")
                        .WithOne()
                        .HasForeignKey("Domain.Company", "OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Domain.Device", b =>
                {
                    b.HasOne("Domain.Company", "Company")
                        .WithMany("Devices")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Domain.Hardware", b =>
                {
                    b.HasOne("Domain.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Home", "Home")
                        .WithMany("Devices")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Home");
                });

            modelBuilder.Entity("Domain.Home", b =>
                {
                    b.HasOne("Domain.User", "Owner")
                        .WithMany("OwnedHomes")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Domain.UbicationGeo", "Ubication", b1 =>
                        {
                            b1.Property<Guid>("HomeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int?>("Lat")
                                .HasColumnType("int");

                            b1.Property<int?>("Lon")
                                .HasColumnType("int");

                            b1.HasKey("HomeId");

                            b1.ToTable("Homes");

                            b1.WithOwner()
                                .HasForeignKey("HomeId");
                        });

                    b.Navigation("Owner");

                    b.Navigation("Ubication")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Notification", b =>
                {
                    b.HasOne("Domain.Hardware", "Hardware")
                        .WithMany()
                        .HasForeignKey("HardwareId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Hardware");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.NotificationMember", b =>
                {
                    b.HasOne("Domain.Home", "Home")
                        .WithMany("NotificationMembers")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Home");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.SessionUser", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.UserHomePermission", b =>
                {
                    b.HasOne("Domain.Home", "Home")
                        .WithMany("Members")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany("HomePermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Home");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PermissionUser", b =>
                {
                    b.HasOne("Domain.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Company", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("Domain.Home", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("Members");

                    b.Navigation("NotificationMembers");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Navigation("HomePermissions");

                    b.Navigation("OwnedHomes");
                });
#pragma warning restore 612, 618
        }
    }
}
