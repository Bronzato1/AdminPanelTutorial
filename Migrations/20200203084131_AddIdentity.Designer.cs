﻿// <auto-generated />
using System;
using AdminPanelTutorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdminPanelTutorial.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200203084131_AddIdentity")]
    partial class AddIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminPanelTutorial.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Phone")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Admins","dbo");
                });

            modelBuilder.Entity("AdminPanelTutorial.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("Gender")
                        .HasColumnName("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Phone")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Specialist")
                        .IsRequired()
                        .HasColumnName("Specialist")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Doctors","dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 789, DateTimeKind.Local).AddTicks(906),
                            Email = "william@gmail.com",
                            Gender = 0,
                            Name = "William",
                            Password = "william",
                            Phone = "+034 76 87 42",
                            Specialist = "Pédiatre"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8332),
                            Email = "shakespeare@gmail.com",
                            Gender = 0,
                            Name = "Shakespeare",
                            Password = "shakespeare",
                            Phone = "+034 76 87 42",
                            Specialist = "Orthophoniste"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8374),
                            Email = "vanespen@gmail.com",
                            Gender = 0,
                            Name = "Vanespen",
                            Password = "vanespen",
                            Phone = "+034 76 87 42",
                            Specialist = "Podologue"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8380),
                            Email = "dehondt@gmail.com",
                            Gender = 0,
                            Name = "Dehondt",
                            Password = "dehondt",
                            Phone = "+034 76 87 42",
                            Specialist = "Chirurgien"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8384),
                            Email = "henri@gmail.com",
                            Gender = 0,
                            Name = "Henri",
                            Password = "henri",
                            Phone = "+034 76 87 42",
                            Specialist = "Cardiologue"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8388),
                            Email = "craemer@gmail.com",
                            Gender = 0,
                            Name = "Craemer",
                            Password = "craemer",
                            Phone = "+034 76 87 42",
                            Specialist = "Anesthésiste"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8392),
                            Email = "paul@gmail.com",
                            Gender = 0,
                            Name = "Paul",
                            Password = "paul",
                            Phone = "+034 76 87 42",
                            Specialist = "Gastroentérologue"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8395),
                            Email = "dupuit@gmail.com",
                            Gender = 0,
                            Name = "Dupuit",
                            Password = "dupuit",
                            Phone = "+034 76 87 42",
                            Specialist = "Gynécologue"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8399),
                            Email = "gérard@gmail.com",
                            Gender = 0,
                            Name = "Gérard",
                            Password = "gérard",
                            Phone = "+034 76 87 42",
                            Specialist = "Hématologue"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8402),
                            Email = "vaneste@gmail.com",
                            Gender = 0,
                            Name = "Vaneste",
                            Password = "vaneste",
                            Phone = "+034 76 87 42",
                            Specialist = "Néphrologue"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8448),
                            Email = "william@gmail.com",
                            Gender = 0,
                            Name = "William",
                            Password = "william",
                            Phone = "+034 76 87 42",
                            Specialist = "Pédiatre"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8452),
                            Email = "shakespeare@gmail.com",
                            Gender = 0,
                            Name = "Shakespeare",
                            Password = "shakespeare",
                            Phone = "+034 76 87 42",
                            Specialist = "Orthophoniste"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8456),
                            Email = "vanespen@gmail.com",
                            Gender = 0,
                            Name = "Vanespen",
                            Password = "vanespen",
                            Phone = "+034 76 87 42",
                            Specialist = "Podologue"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8460),
                            Email = "dehondt@gmail.com",
                            Gender = 0,
                            Name = "Dehondt",
                            Password = "dehondt",
                            Phone = "+034 76 87 42",
                            Specialist = "Chirurgien"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8465),
                            Email = "henri@gmail.com",
                            Gender = 0,
                            Name = "Henri",
                            Password = "henri",
                            Phone = "+034 76 87 42",
                            Specialist = "Cardiologue"
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8469),
                            Email = "craemer@gmail.com",
                            Gender = 0,
                            Name = "Craemer",
                            Password = "craemer",
                            Phone = "+034 76 87 42",
                            Specialist = "Anesthésiste"
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8475),
                            Email = "paul@gmail.com",
                            Gender = 0,
                            Name = "Paul",
                            Password = "paul",
                            Phone = "+034 76 87 42",
                            Specialist = "Gastroentérologue"
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8478),
                            Email = "dupuit@gmail.com",
                            Gender = 0,
                            Name = "Dupuit",
                            Password = "dupuit",
                            Phone = "+034 76 87 42",
                            Specialist = "Gynécologue"
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8482),
                            Email = "gérard@gmail.com",
                            Gender = 0,
                            Name = "Gérard",
                            Password = "gérard",
                            Phone = "+034 76 87 42",
                            Specialist = "Hématologue"
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8485),
                            Email = "vaneste@gmail.com",
                            Gender = 0,
                            Name = "Vaneste",
                            Password = "vaneste",
                            Phone = "+034 76 87 42",
                            Specialist = "Néphrologue"
                        },
                        new
                        {
                            Id = 21,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8489),
                            Email = "william@gmail.com",
                            Gender = 0,
                            Name = "William",
                            Password = "william",
                            Phone = "+034 76 87 42",
                            Specialist = "Pédiatre"
                        },
                        new
                        {
                            Id = 22,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8492),
                            Email = "shakespeare@gmail.com",
                            Gender = 0,
                            Name = "Shakespeare",
                            Password = "shakespeare",
                            Phone = "+034 76 87 42",
                            Specialist = "Orthophoniste"
                        },
                        new
                        {
                            Id = 23,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8496),
                            Email = "vanespen@gmail.com",
                            Gender = 0,
                            Name = "Vanespen",
                            Password = "vanespen",
                            Phone = "+034 76 87 42",
                            Specialist = "Podologue"
                        },
                        new
                        {
                            Id = 24,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8500),
                            Email = "dehondt@gmail.com",
                            Gender = 0,
                            Name = "Dehondt",
                            Password = "dehondt",
                            Phone = "+034 76 87 42",
                            Specialist = "Chirurgien"
                        },
                        new
                        {
                            Id = 25,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8504),
                            Email = "henri@gmail.com",
                            Gender = 0,
                            Name = "Henri",
                            Password = "henri",
                            Phone = "+034 76 87 42",
                            Specialist = "Cardiologue"
                        },
                        new
                        {
                            Id = 26,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8507),
                            Email = "craemer@gmail.com",
                            Gender = 0,
                            Name = "Craemer",
                            Password = "craemer",
                            Phone = "+034 76 87 42",
                            Specialist = "Anesthésiste"
                        },
                        new
                        {
                            Id = 27,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8513),
                            Email = "paul@gmail.com",
                            Gender = 0,
                            Name = "Paul",
                            Password = "paul",
                            Phone = "+034 76 87 42",
                            Specialist = "Gastroentérologue"
                        },
                        new
                        {
                            Id = 28,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8518),
                            Email = "dupuit@gmail.com",
                            Gender = 0,
                            Name = "Dupuit",
                            Password = "dupuit",
                            Phone = "+034 76 87 42",
                            Specialist = "Gynécologue"
                        },
                        new
                        {
                            Id = 29,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8521),
                            Email = "gérard@gmail.com",
                            Gender = 0,
                            Name = "Gérard",
                            Password = "gérard",
                            Phone = "+034 76 87 42",
                            Specialist = "Hématologue"
                        },
                        new
                        {
                            Id = 30,
                            Created = new DateTime(2020, 2, 3, 9, 41, 30, 791, DateTimeKind.Local).AddTicks(8524),
                            Email = "vaneste@gmail.com",
                            Gender = 0,
                            Name = "Vaneste",
                            Password = "vaneste",
                            Phone = "+034 76 87 42",
                            Specialist = "Néphrologue"
                        });
                });

            modelBuilder.Entity("AdminPanelTutorial.Models.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Phone")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Nurses","dbo");
                });

            modelBuilder.Entity("AdminPanelTutorial.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Created")
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("DoctorId")
                        .HasColumnName("Doctor_id")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnName("Gender")
                        .HasColumnType("int");

                    b.Property<string>("HealthCondition")
                        .IsRequired()
                        .HasColumnName("Health_condition")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("NurseId")
                        .HasColumnName("Nurse_id")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Phone")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("DoctorId")
                        .HasName("doctor_id");

                    b.HasIndex("NurseId")
                        .HasName("nurse_id");

                    b.ToTable("Patients","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AdminPanelTutorial.Models.Patient", b =>
                {
                    b.HasOne("AdminPanelTutorial.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("patients_ibfk_1")
                        .IsRequired();

                    b.HasOne("AdminPanelTutorial.Models.Nurse", "Nurse")
                        .WithMany("Patients")
                        .HasForeignKey("NurseId")
                        .HasConstraintName("patients_ibfk_2")
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
