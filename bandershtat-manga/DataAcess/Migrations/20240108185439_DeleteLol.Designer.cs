﻿// <auto-generated />
using System;
using DataAcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAcess.Migrations
{
    [DbContext(typeof(MangaDbContext))]
    [Migration("20240108185439_DeleteLol")]
    partial class DeleteLol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAcess.Entity.Ganr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ganrs");

                    b.HasData(
                        new
                        {
                            Id = 24,
                            Name = "Пригоди"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Кодомо"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Шьодзьо"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Шьонен"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Сейнен"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Дзьосей"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Махо-шьонен"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Шьоджьо-ай"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Шьоджьо-ай"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Юрі"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Шьонен-ай"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Яой"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Гарем"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Шьотакон"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Меха"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Наукова фантастика"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Кіберпанк"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Стімпанк"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Апокаліпсис"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Постапокаліпсикс"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Фентезі"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Хоррор"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Готика"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Вестерн"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Школа"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Бойовик"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Детектив"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Драма"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Історія"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Комедія"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Романтика"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Хентай"
                        });
                });

            modelBuilder.Entity("DataAcess.Entity.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePerecladachs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datePublish")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("yearCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("yearLimit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mangas");
                });

            modelBuilder.Entity("DataAcess.Entity.MangaGanr", b =>
                {
                    b.Property<int>("MangaId")
                        .HasColumnType("int");

                    b.Property<int>("GanrId")
                        .HasColumnType("int");

                    b.HasKey("MangaId", "GanrId");

                    b.HasIndex("GanrId");

                    b.ToTable("MangaGanr");
                });

            modelBuilder.Entity("DataAcess.Entity.Videos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Videoses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DataAcess.Entity.Roles", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.HasDiscriminator().HasValue("Roles");

                    b.HasData(
                        new
                        {
                            Id = "Admin",
                            ConcurrencyStamp = "60140d84-3866-4232-9dbd-e22b11da1d13",
                            Name = "Адмін"
                        },
                        new
                        {
                            Id = "Client",
                            ConcurrencyStamp = "bead7039-484f-4552-aedb-96a581bf3514",
                            Name = "Клієнт"
                        });
                });

            modelBuilder.Entity("DataAcess.Entity.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("RolesId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("RolesId");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("DataAcess.Entity.MangaGanr", b =>
                {
                    b.HasOne("DataAcess.Entity.Ganr", "Ganr")
                        .WithMany("Mangas")
                        .HasForeignKey("GanrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAcess.Entity.Manga", "Manga")
                        .WithMany("Ganrs")
                        .HasForeignKey("MangaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ganr");

                    b.Navigation("Manga");
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

            modelBuilder.Entity("DataAcess.Entity.User", b =>
                {
                    b.HasOne("DataAcess.Entity.Roles", null)
                        .WithMany("Users")
                        .HasForeignKey("RolesId");
                });

            modelBuilder.Entity("DataAcess.Entity.Ganr", b =>
                {
                    b.Navigation("Mangas");
                });

            modelBuilder.Entity("DataAcess.Entity.Manga", b =>
                {
                    b.Navigation("Ganrs");
                });

            modelBuilder.Entity("DataAcess.Entity.Roles", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
