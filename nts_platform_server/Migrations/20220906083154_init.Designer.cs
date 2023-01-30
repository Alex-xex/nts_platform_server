﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nts_platform_server.Data;

namespace nts_platform_server.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220906083154_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("nts_platform_server.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "NTS"
                        });
                });

            modelBuilder.Entity("nts_platform_server.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("nts_platform_server.Entities.ContactProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ContactProject");
                });

            modelBuilder.Entity("nts_platform_server.Entities.DocHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityCodeTravel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectNumber")
                        .HasColumnType("int");

                    b.Property<float>("TravelTimeC")
                        .HasColumnType("real");

                    b.Property<float>("TraverTimeG")
                        .HasColumnType("real");

                    b.Property<float>("WTHour")
                        .HasColumnType("real");

                    b.Property<int?>("WeekId")
                        .HasColumnType("int");

                    b.Property<string>("Weekday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("WeekId");

                    b.ToTable("DocHour");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inn")
                        .HasColumnType("int");

                    b.Property<int>("IpCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("IpDateBack")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IpDateTaked")
                        .HasColumnType("datetime2");

                    b.Property<int>("IpNumber")
                        .HasColumnType("int");

                    b.Property<string>("IpPlaceBorned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpTaked")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoByte")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrfCode")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PrfDateBack")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrfDateTaked")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrfNumber")
                        .HasColumnType("int");

                    b.Property<string>("PrfPlaceBorned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrfPlaceLived")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrfPlaceRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrfSeries")
                        .HasColumnType("int");

                    b.Property<string>("PrfTaked")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<string>("Snils")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlmCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("UlmDateBack")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UlmDateTaked")
                        .HasColumnType("datetime2");

                    b.Property<int>("UlmNumber")
                        .HasColumnType("int");

                    b.Property<string>("UlmPlaceBorned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UlmTaked")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(1994, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inn = 1111,
                            IpCode = 111,
                            IpDateBack = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IpDateTaked = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IpNumber = 1111,
                            IpPlaceBorned = "Гор. КРАСНОЯСРК / RUSSIA",
                            IpTaked = "МВД 24003",
                            Phone = "89832068482",
                            PhotoName = "ava",
                            PrfCode = 240003,
                            PrfDateTaked = new DateTime(2014, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PrfNumber = 652893,
                            PrfPlaceBorned = "ГОР. МИНСК БЕЛАРУСЬ",
                            PrfPlaceLived = "Россия, г. Красняосрк, ул. Урванецва, д. 6А, кв. 74",
                            PrfPlaceRegistration = "Россия, г. Красняосрк, ул. Урванецва, д. 6А, кв. 74",
                            PrfSeries = 414,
                            PrfTaked = "Отделом УФМС РОССИИ ПО КРАСНОЯСРКОМУ КРАЮ В СОВЕТСКОМ Р-НЕ Г.КРАСНОЯСРКА",
                            Sex = false,
                            Snils = "1111",
                            UlmCode = 111,
                            UlmDateBack = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UlmDateTaked = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UlmNumber = 111,
                            UlmPlaceBorned = "Гор. КРАСНОЯСРК / RUSSIA",
                            UlmTaked = "МВД 24003"
                        });
                });

            modelBuilder.Entity("nts_platform_server.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActualHour")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnginerCreaterId")
                        .HasColumnType("int");

                    b.Property<int>("MaxHour")
                        .HasColumnType("int");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("indexAdd")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnginerCreaterId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("nts_platform_server.Entities.ReportCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoByte")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserProjectId");

                    b.ToTable("ReportChecks");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Title = "engineer"
                        },
                        new
                        {
                            Id = 3,
                            Title = "guest"
                        });
                });

            modelBuilder.Entity("nts_platform_server.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Email = "xok",
                            FirstName = "Сергей",
                            MiddleName = "Юрьевич",
                            Password = "$2a$11$E4SrbDko5uWH9F.UlS.PMu8eLa4R0cs6dRtrbG11nMOIpsnqLCota",
                            ProfileId = 1,
                            RoleId = 1,
                            SecondName = "Смоглюк"
                        });
                });

            modelBuilder.Entity("nts_platform_server.Entities.UserProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProject");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FrHourId")
                        .HasColumnType("int");

                    b.Property<int?>("MoHourId")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("NumberWeek")
                        .HasColumnType("int");

                    b.Property<int?>("SaHourId")
                        .HasColumnType("int");

                    b.Property<int?>("SuHourId")
                        .HasColumnType("int");

                    b.Property<int?>("ThHourId")
                        .HasColumnType("int");

                    b.Property<int?>("TuHourId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserProjectId")
                        .HasColumnType("int");

                    b.Property<int?>("WeHourId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FrHourId");

                    b.HasIndex("MoHourId");

                    b.HasIndex("SaHourId");

                    b.HasIndex("SuHourId");

                    b.HasIndex("ThHourId");

                    b.HasIndex("TuHourId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserProjectId");

                    b.HasIndex("WeHourId");

                    b.ToTable("Week");
                });

            modelBuilder.Entity("nts_platform_server.Entities.ContactProject", b =>
                {
                    b.HasOne("nts_platform_server.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");

                    b.HasOne("nts_platform_server.Entities.Project", "Project")
                        .WithMany("ContactProjects")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Contact");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("nts_platform_server.Entities.DocHour", b =>
                {
                    b.HasOne("nts_platform_server.Entities.Week", "Week")
                        .WithMany()
                        .HasForeignKey("WeekId");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Project", b =>
                {
                    b.HasOne("nts_platform_server.Entities.User", "EnginerCreater")
                        .WithMany()
                        .HasForeignKey("EnginerCreaterId");

                    b.Navigation("EnginerCreater");
                });

            modelBuilder.Entity("nts_platform_server.Entities.ReportCheck", b =>
                {
                    b.HasOne("nts_platform_server.Entities.UserProject", null)
                        .WithMany("ReportChecks")
                        .HasForeignKey("UserProjectId");
                });

            modelBuilder.Entity("nts_platform_server.Entities.User", b =>
                {
                    b.HasOne("nts_platform_server.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nts_platform_server.Entities.Profile", "Profile")
                        .WithOne("User")
                        .HasForeignKey("nts_platform_server.Entities.User", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nts_platform_server.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Profile");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("nts_platform_server.Entities.UserProject", b =>
                {
                    b.HasOne("nts_platform_server.Entities.Project", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("ProjectId");

                    b.HasOne("nts_platform_server.Entities.User", "User")
                        .WithMany("UserProjects")
                        .HasForeignKey("UserId");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Week", b =>
                {
                    b.HasOne("nts_platform_server.Entities.DocHour", "FrHour")
                        .WithMany()
                        .HasForeignKey("FrHourId");

                    b.HasOne("nts_platform_server.Entities.DocHour", "MoHour")
                        .WithMany()
                        .HasForeignKey("MoHourId");

                    b.HasOne("nts_platform_server.Entities.DocHour", "SaHour")
                        .WithMany()
                        .HasForeignKey("SaHourId");

                    b.HasOne("nts_platform_server.Entities.DocHour", "SuHour")
                        .WithMany()
                        .HasForeignKey("SuHourId");

                    b.HasOne("nts_platform_server.Entities.DocHour", "ThHour")
                        .WithMany()
                        .HasForeignKey("ThHourId");

                    b.HasOne("nts_platform_server.Entities.DocHour", "TuHour")
                        .WithMany()
                        .HasForeignKey("TuHourId");

                    b.HasOne("nts_platform_server.Entities.User", "User")
                        .WithMany("Weeks")
                        .HasForeignKey("UserId");

                    b.HasOne("nts_platform_server.Entities.UserProject", "UserProject")
                        .WithMany("Weeks")
                        .HasForeignKey("UserProjectId");

                    b.HasOne("nts_platform_server.Entities.DocHour", "WeHour")
                        .WithMany()
                        .HasForeignKey("WeHourId");

                    b.Navigation("FrHour");

                    b.Navigation("MoHour");

                    b.Navigation("SaHour");

                    b.Navigation("SuHour");

                    b.Navigation("ThHour");

                    b.Navigation("TuHour");

                    b.Navigation("User");

                    b.Navigation("UserProject");

                    b.Navigation("WeHour");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Profile", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Project", b =>
                {
                    b.Navigation("ContactProjects");

                    b.Navigation("UserProjects");
                });

            modelBuilder.Entity("nts_platform_server.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("nts_platform_server.Entities.User", b =>
                {
                    b.Navigation("UserProjects");

                    b.Navigation("Weeks");
                });

            modelBuilder.Entity("nts_platform_server.Entities.UserProject", b =>
                {
                    b.Navigation("ReportChecks");

                    b.Navigation("Weeks");
                });
#pragma warning restore 612, 618
        }
    }
}
